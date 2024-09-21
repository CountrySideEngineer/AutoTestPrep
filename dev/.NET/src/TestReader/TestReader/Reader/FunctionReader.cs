using System.Data;
using TestReader.Model;
using Logger;
using TestReader.Config;
using System.Globalization;
using System.Net;
using TestReader.Converter;
using System.Dynamic;

namespace TestReader.Reader
{
	public class FunctionReader : ATableReader<Function>
	{
		public override Function Convert(DataTable data)
		{
			Log.TRACE();

			Function function = GetFunction(data);
			IEnumerable<Function> subFuncs = GetSubFunction(data);
			IEnumerable<Parameter> externalVariable = GetExternalVariable(data);
			IEnumerable<Parameter> internalVariable = GetInternalVariable(data);

			function.SubFunctions = subFuncs;
			function.ExternalVariables = externalVariable;
			function.InternalVariables = internalVariable;

			return function;
		}

		/// <summary>
		/// Get table configuration 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="InvalidDataException"></exception>
		public override (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig()
		{
			Log.TRACE();

			TestConfigurationElement? config = TestConfiguration.Get().Function;
            if (null != config)
			{
				return (config.Name, 
					config.RowOffset ?? -1, config.ColOffset ?? -1, 
					config.RowSize ?? -1, config.ColSize ?? -1);
			}
			else
			{
				Log.WARN("Function table configuration not found.");

				throw new InvalidDataException();
			}
		}

		protected Function GetFunction(DataTable src)
		{
			Log.TRACE();

			var converter = new FunctionConverter();
			Function function = converter.Convert(src);

			return function;
		}

		protected virtual IEnumerable<Function> GetSubFunction(DataTable src)
		{
			Log.TRACE();

			var converter = new SubFunctionConverter();
			IEnumerable<Function> subFuncs = converter.Convert(src);

			return subFuncs;
		}

		protected virtual IEnumerable<Parameter> GetExternalVariable(DataTable src)
		{
			Log.TRACE();

			var converter = new ExternalVariableConverter();
			IEnumerable<Parameter> externalVariables = converter.Convert(src);
			return externalVariables;
		}

		protected virtual IEnumerable<Parameter> GetInternalVariable(DataTable src)
		{
			Log.TRACE();

			var converter = new InternalVariableConverter();
			IEnumerable<Parameter> externalVariables = converter.Convert(src);
			return externalVariables;
		}
	}
}
