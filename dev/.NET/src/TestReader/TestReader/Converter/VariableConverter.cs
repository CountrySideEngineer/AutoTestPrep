using System.Data;
using Logger;
using Parameter = TestParser.Model.Parameter;

namespace TestReader.Converter
{
	internal abstract class VariableConverter : AParameterTableConverter<IEnumerable<Parameter>>
	{
		/// <summary>
		/// Convert DataTable object into collectin of Parameter objects.
		/// </summary>
		/// <param name="data">DataTable object to convert.</param>
		/// <returns>Collection of Parameter object.</returns>
		public override IEnumerable<Parameter> Convert(DataTable data)
		{
			Log.TRACE();

			IEnumerable<Parameter> paramteres = GetVariable(data);

			return paramteres;
		}

		protected virtual IEnumerable<Parameter> GetVariable(DataTable data)
		{
			Log.TRACE();

			IEnumerable<DataRow> variableRows = data
				.AsEnumerable()
				.Where(_ => _["種類"].ToString() == "グローバル変数")
				.ToList();
			IEnumerable<Parameter> parameters = GetVariables(variableRows);
			return parameters;
		}

		protected virtual IEnumerable<Parameter> GetVariables(IEnumerable<DataRow> rows)
		{
			Log.TRACE();

			string typeName = GetTypeName();
			List<Parameter> parameters = new List<Parameter>();
			IEnumerable<DataRow> variableRows = rows.Where(_ => _["内容"].ToString() == typeName);
            foreach (DataRow row in variableRows)
            {
				Parameter parameter = GetVariable(row);
				parameters.Add(parameter);
            }
			return parameters;
        }

		protected virtual Parameter GetVariable(DataRow row)
		{
			Log.TRACE();

			Parameter parameter = Row2Parameter(row);

			return parameter;
		}

		internal abstract string GetTypeName();
		
	}
}
