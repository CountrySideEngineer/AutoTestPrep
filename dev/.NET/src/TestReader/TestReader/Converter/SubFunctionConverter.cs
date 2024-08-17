using Logger;
using System.ComponentModel;
using System.Data;
using Function = TestParser.Model.Function;
using Parameter = TestParser.Model.Parameter;

namespace TestReader.Converter
{
	internal class SubFunctionConverter : AParameterTableConverter<IEnumerable<Function>>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public SubFunctionConverter() : base() { }

		/// <summary>
		/// Convert DataTable object into collection of Function object about "sub function".
		/// </summary>
		/// <param name="data">DataTable object.</param>
		/// <returns>Collection of Function object about sub function.</returns>
		public override IEnumerable<Function> Convert(DataTable data)
		{
			var subFuncs = new List<Function>();

			IEnumerable<DataRow> subFuncRows = GetSubFunctionRows(data);
			foreach (DataRow subFuncRow in subFuncRows)
			{
				Function subFunction = GetFunctionBody(subFuncRow);
				IEnumerable<DataRow> argRows = GetArgumentRowsOf(data, subFuncRow);
				IEnumerable<Parameter> args = GetArguments(argRows);

				subFunction.Arguments = args;
				subFuncs.Add(subFunction);
			}
			return subFuncs;
		}

		/// <summary>
		/// Get DataRow in DataTable object about sub function.
		/// </summary>
		/// <param name="data">DataTable object.</param>
		/// <returns>Collection of sub function.</returns>
		protected virtual IEnumerable<DataRow> GetSubFunctionRows(DataTable data)
		{
			Log.TRACE();

			IEnumerable<DataRow> subFunctionRows = data
				.AsEnumerable()
				.Where(_ => _["種類"].ToString() == "子関数")
				.ToList();
			IEnumerable<DataRow> subFuncBodyRows = GetFunctionBodyRows(subFunctionRows);

			return subFuncBodyRows;
		}

		/// <summary>
		/// Get DataRow objects about sub function body.
		/// </summary>
		/// <param name="rows">Collection of DataRow object about sub function.</param>
		/// <returns>Collection of data row, DataRow object, about sub function body.</returns>
		protected virtual IEnumerable<DataRow> GetFunctionBodyRows(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			IEnumerable<DataRow> subFunctionBodyRows = rows
				.Where(_ => _["内容"].ToString() == "本体")
				.ToList();

			return subFunctionBodyRows;
		}

		/// <summary>
		/// Get DataRow objects about sub function argument.
		/// </summary>
		/// <param name="data">DataTable object.</param>
		/// <param name="subFuncRow">Information on the function for which you want to search for arguments.</param>
		/// <returns></returns>
		protected virtual IEnumerable<DataRow> GetArgumentRowsOf(DataTable data, DataRow subFuncRow)
		{
			Log.TRACE();

			IEnumerable<DataRow> rows = data.AsEnumerable().Where(_ => _["種類"].ToString() == "子関数").ToList();
			IEnumerable<DataRow> rowsAfterSubFuncRow = rows.Where(_ => data.Rows.IndexOf(subFuncRow) < data.Rows.IndexOf(_)).ToList();

			var argRows = new List<DataRow>();
            for (int index = 0; index < rowsAfterSubFuncRow.Count(); index++)
            {
				DataRow argRow = rowsAfterSubFuncRow.ElementAt(index);
				if (argRow["内容"].ToString() == "引数")
				{
					argRows.Add(argRow);
				}
				else
				{
					break;
				}
            }
			return argRows;
        }

		/// <summary>
		/// Get arguments as collection of Parameter object.
		/// </summary>
		/// <param name="rows">DataRow object collection about arguments.</param>
		/// <returns></returns>
		protected virtual IEnumerable<Parameter> GetArguments(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			IEnumerable<DataRow> argumentRows = rows.Where(_ => _["内容"].ToString() == "引数").ToList();
			var arguments = new List<Parameter>();
			foreach (DataRow argumentRow in argumentRows)
			{
				Parameter argument = GetArgument(argumentRow);
				arguments.Add(argument);
			}

			return arguments;
		}

		/// <summary>
		/// Get argument data as Parameter object.
		/// </summary>
		/// <param name="row">Argument DataRow object.</param>
		/// <returns>Argument in Parameter object.</returns>
		protected virtual Parameter GetArgument(DataRow row)
		{
			Log.TRACE();

			Parameter parameter = Row2Parameter(row);

			return parameter;
		}

		/// <summary>
		/// Get Function object.
		/// </summary>
		/// <param name="row">Function DataRow object.</param>
		/// <returns>Function in Function object.</returns>
		protected virtual Function GetFunctionBody(DataRow row)
		{
			Log.TRACE();

			Parameter parameter = Row2Parameter(row);

			Function function = new Function()
			{
				Prefix = parameter.Prefix,
				DataType = parameter.DataType,
				Postfix = parameter.Postfix,
				PointerNum = parameter.PointerNum,
				Name = parameter.Name
			};
			return function;
		}
	}
}
