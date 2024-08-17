using System.Data;
using TestParser.Model;
using Logger;
using System.Globalization;

namespace TestReader.Converter
{
	internal class FunctionConverter : AParameterTableConverter<Function>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public FunctionConverter() : base() { }

		/// <summary>
		/// Converter DataTable data into Function object.
		/// </summary>
		/// <param name="data">Data table object to convert.</param>
		/// <returns>Function object the DataTable object converted.</returns>
		public override Function Convert(DataTable data)
		{
			Log.TRACE();

			Function function = GetFunction(data);

			return function;
		}

		/// <summary>
		/// Get Function object from DataTable object.
		/// </summary>
		/// <param name="table"></param>
		/// <param name="data">Data table object to convert.</param>
		/// <returns>Function object the DataTable object converted.</returns>
		protected virtual Function GetFunction(DataTable table)
		{
			Log.TRACE();

			IEnumerable<DataRow> functionRows = table
				.AsEnumerable()
				.Where(_ => _["種類"].ToString() == "テスト対象関数")
				.ToList();
			Function function = GetFunction(functionRows);

			return function;
		}

		/// <summary>
		/// Get Function object from collection of DataRow object.
		/// </summary>
		/// <param name="rows">Collection of DataRow object to convert.</param>
		/// <returns>Function object the collection of DataRow object converted.</returns>
		protected virtual Function GetFunction(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			Function function = GetFunctionBody(rows);
			IEnumerable<Parameter> arguments = GetArguments(rows);
			function.Arguments = arguments;

			return function;
		}

		/// <summary>
		/// Get name and data type of function.
		/// </summary>
		/// <param name="rows">Collection of DataRow object to convert.</param>
		/// <returns>Function object only name and data type contains.</returns>
		protected virtual Function GetFunctionBody(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			DataRow bodyRow = rows.Where(_ => _["内容"].ToString() == "本体").First();
			Function function = GetFunctionBody(bodyRow);

			return function;
		}

		/// <summary>
		/// Get name and data type of function.
		/// </summary>
		/// <param name="row">The DataRow object to convert.</param>
		/// <returns>Function object only name and data type contains.</returns>
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

		/// <summary>
		/// Get arguments of function.
		/// </summary>
		/// <param name="rows">Collection of DataRow object.</param>
		/// <returns>Collection of parameter object of arguemnt.</returns>
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
		/// Get an argument from DataRow object.
		/// </summary>
		/// <param name="row">DataRow object to convert.</param>
		/// <returns>Parameter object converted from DataRow.</returns>
		protected virtual Parameter GetArgument(DataRow row)
		{
			Log.TRACE();

			Parameter parameter= Row2Parameter(row);

			return parameter;
		}
	}
}
