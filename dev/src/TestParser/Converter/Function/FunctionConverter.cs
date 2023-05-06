using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Config;
using TestParser.Target;

namespace TestParser.Converter.Function
{
	public class FunctionConverter : IContentConverter
	{
		protected enum FUNC_TABLE_COL_INDEX : int
		{
			COL_INDEX_CATEGORY = 0,
			COL_INDEX_TYPE,
			COL_INDEX_PREFIXES,
			COL_INDEX_DATA_TYPE,
			COL_INDEX_POSTFIXES,
			COL_INDEX_NAME,
			COL_INDEX_IN_OUT,
			COL_INDEX_DESCRIPTION,
		};

		protected FunctionTableConfig _config;

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <param name="config"></param>
		public FunctionConverter(FunctionTableConfig config)
		{
			_config = config;
		}

		/// <summary>
		/// Convert function to Function object.
		/// </summary>
		/// <param name="src">Content of function table.</param>
		/// <returns>Function information data.</returns>
		public object Convert(Content src)
		{
			var function = new TestParser.Target.Function();
			SetTo(src, ref function);

			return function;
		}

		/// <summary>
		/// Convert function to Function 
		/// </summary>
		/// <param name="src"></param>
		/// <param name="dst"></param>
		protected void SetTo(Content src, ref TestParser.Target.Function dst)
		{
			int rowCount = src.RowCount();

			//Skip 1st row, it will be a header.
			for (int rowIndex = 1; rowIndex < rowCount; rowIndex++)
			{
				IEnumerable<string> item = src.GetContentsInRow(rowIndex);
				SetTo(item, ref dst);
			}
		}

		/// <summary>
		/// Set content to Function object.
		/// </summary>
		/// <param name="src">Collection of content to .</param>
		/// <param name="dst">Function object to be set to.</param>
		protected void SetTo(IEnumerable<string> src, ref TestParser.Target.Function dst)
		{
			Parameter item = Convert(src);
			IParameterSetter setter = GetSetter(src);
			setter.Set(item, ref dst);
		}

		/// <summary>
		/// Retunrs setter to set src content to Function object.
		/// </summary>
		/// <param name="src">Source content to be set .</param>
		/// <returns>IParmaeterSetter implement object.</returns>
		protected IParameterSetter GetSetter(IEnumerable<string> src)
		{
			try
			{
				IParameterSetter setter = null;
				string category = src.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_CATEGORY);
				string type = src.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_TYPE);

				if (category.Equals(_config.TargetFunction.Category))
				{
					if (type.Equals(_config.TargetFunction.Function))
					{
						setter = new FunctionSetter();
					}
					else if (type.Equals(_config.TargetFunction.Argument))
					{
						setter = new FunctionArgSetter();
					}
					else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				else if (category.Equals(_config.SubFunction.Category))
				{
					if (type.Equals(_config.SubFunction.Function))
					{
						setter = new SubFunctionSetter();
					}
					else if (type.Equals(_config.SubFunction.Argument))
					{
						setter = new SubFunctionArgSetter();
					}
					else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				else if (category.Equals(_config.Variable.Category))
				{
					if (type.Equals(_config.Variable.External))
					{
						setter = new ExternalVariableSetter();
					}
					else if (type.Equals(_config.Variable.Internal))
					{
						setter = new InternalVariableSetter();
					}
					else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				else
				{
					throw new ArgumentOutOfRangeException();
				}
				return setter;
			}
			catch (Exception ex)
			when ((ex is NullReferenceException) || (ex is ArgumentOutOfRangeException))
			{
				throw;
			}
		}

		/// <summary>
		/// Convert a set of string read from table into Parameter object.
		/// </summary>
		/// <param name="src"></param>
		/// <returns>Parameter objected converted.</returns>
		/// <exception cref="ArgumentException">Argument or argument vaue is invalid.</exception>
		protected Parameter Convert(IEnumerable<string> src)
		{
			try
			{
				IEnumerable<string> prefixes = 
					src
					.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_PREFIXES)
					.Split(' ')
					.Where(_ => ((!string.IsNullOrEmpty(_)) && (!string.IsNullOrWhiteSpace(_))));
				string dataType = src.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_DATA_TYPE);
				IEnumerable<string> postfixes =
					src
					.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_POSTFIXES)
					.Split(' ')
					.Where(_ => ((!string.IsNullOrEmpty(_)) && (!string.IsNullOrWhiteSpace(_))));
				string name = src.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_NAME);
				string in_out = src.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_IN_OUT);
				Parameter.AccessMode mode = Parameter.AccessMode.None;
				try
				{
					mode = Parameter.ToMode(in_out);
				}
				catch (ArgumentException)
				{
					mode = Parameter.AccessMode.In;
				}
				string description = src.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_DESCRIPTION);
				int pointerNum = 0;
				try
				{
					pointerNum =
						src
						.ElementAt((int)FUNC_TABLE_COL_INDEX.COL_INDEX_POSTFIXES)
						.Where(_ => _ == '*')
						.Count();
				}
				catch (ArgumentNullException)
				{
					pointerNum = 0;
				}

				var parameter = new Parameter()
				{
					Prefix = new List<string>(prefixes),
					DataType = dataType,
					Postfix = new List<string>(postfixes),
					Name = name,
					Mode = mode,
					Description = description,
					PointerNum = pointerNum
				};
				return parameter;
			}
			catch (Exception ex)
			when ((ex is ArgumentNullException) ||
				(ex is ArgumentOutOfRangeException) ||
				(ex is NullReferenceException))
			{
				throw new ArgumentException();
			}
		}

		#region inner class and interface.
		protected interface IParameterSetter
		{
			void Set(Parameter src, ref TestParser.Target.Function dst);
		}

		protected class FunctionSetter : IParameterSetter
		{
			/// <summary>
			/// Set properties of src object to dst object.
			/// </summary>
			/// <param name="src">Source object to set.</param>
			/// <param name="dst">Destination obejct to be set.</param>
			public void Set(Parameter src, ref Target.Function dst)
			{
				var dstParam = dst as Parameter;
				src.CopyTo(ref dstParam);
			}
		}

		protected class FunctionArgSetter : IParameterSetter
		{
			/// <summary>
			/// Set Parameter object to properties to argument of target function.
			/// </summary>
			/// <param name="src">Source object to set.</param>
			/// <param name="dst">Destination obhect to be set.</param>
			public void Set(Parameter src, ref Target.Function dst)
			{
				try
				{
					dst.Arguments = dst.Arguments.Append(src);
				}
				catch (NullReferenceException)
				{
					throw;
				}
			}
		}

		protected class SubFunctionSetter : IParameterSetter
		{
			/// <summary>
			/// Set src parameter into dst object.
			/// </summary>
			/// <param name="src">Source object to set.</param>
			/// <param name="dst">Destination object to be set.</param>
			/// <exception cref="ArgumentException"></exception>
			/// <exception cref="OutOfMemoryException"></exception>
			public void Set(Parameter src, ref Target.Function dst)
			{
				try
				{
					Target.Function func = dst.SubFunctions.Last();
					func.CopyFrom(src);
				}
				catch (InvalidOperationException)
				{
					var srcFunction = new Target.Function();
					srcFunction.CopyFrom(src);
					dst.SubFunctions = dst.SubFunctions.Append(srcFunction);
				}
				catch (InvalidCastException)
				{
					throw new ArgumentException();
				}
				catch (OutOfMemoryException)
				{
					throw;
				}
			}
		}

		protected class SubFunctionArgSetter : IParameterSetter
		{
			/// <summary>
			/// Set src parameter into argument of subfunction.
			/// </summary>
			/// <param name="src">Source object to set.</param>
			/// <param name="dst">Destination object to be set.</param>
			/// <exception cref="InvalidOperationException"></exception>
			public void Set(Parameter src, ref Target.Function dst)
			{
				try
				{
					Target.Function lastItem = dst.SubFunctions.Last();
					lastItem.Arguments = lastItem.Arguments.Append(src);
				}
				catch (InvalidOperationException)
				{
					throw;
				}
			}
		}

		protected class InternalVariableSetter : IParameterSetter
		{
			/// <summary>
			/// Set src parameter into internal variable.
			/// </summary>
			/// <param name="src">Source object to set.</param>
			/// <param name="dst">Destination object to set.</param>
			public void Set(Parameter src, ref Target.Function dst)
			{
				dst.InternalVariables = dst.InternalVariables.Append(src);
			}
		}

		protected class ExternalVariableSetter : IParameterSetter
		{
			/// <summary>
			/// Set src parameter into external variable.
			/// </summary>
			/// <param name="src">Source object to set.</param>
			/// <param name="dst">Destination object to set.</param>
			public void Set(Parameter src, ref Target.Function dst)
			{
				dst.ExternalVariables = dst.ExternalVariables.Append(src);
			}
		}
		#endregion
	}
}
