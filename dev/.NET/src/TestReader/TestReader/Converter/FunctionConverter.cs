using System.Data;
using TestParser.Model;
using Logger;
using System.Globalization;

namespace TestReader.Converter
{
	internal class FunctionConverter : AParameterTableConverter<Function>
	{
		public override Function Convert(DataTable data)
		{
			Log.TRACE();

			Function function = GetFunction(data);

			return function;
		}

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

		protected virtual Function GetFunction(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			Function function = GetFunctionBody(rows);
			IEnumerable<Parameter> arguments = GetArguments(rows);
			function.Arguments = arguments;


			return function;
		}

		protected virtual Function GetFunctionBody(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			DataRow bodyRow = rows.Where(_ => _["内容"].ToString() == "本体").First();
			Function function = GetFunctionBody(bodyRow);

			return function;
		}

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

		protected virtual IEnumerable<Parameter> GetArguments(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			IEnumerable<DataRow> argumentRows = rows.Where(_ => _["内容"].ToString() == "引数").ToList();
			var arguments = new List<Parameter>();
			foreach (DataRow argumentRow in argumentRows)
			{
				Parameter argument = Row2Parameter(argumentRow);
				arguments.Add(argument);
			}

			return arguments;
		}
	}
}
