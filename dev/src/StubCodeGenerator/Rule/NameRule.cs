using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Rule
{
	public class NameRule
	{
		public string GetCalledCounter(Function function)
		{
			string bufferName = $"{function.Name}_called_count";

			return bufferName;
		}

		public string GetReturnValue(Function function)
		{
			string bufferName = $"{function.Name}_return_value";

			return bufferName;
		}

		public string GetArgumentBuffer(Function function, Parameter argument)
		{
			string bufferName = $"{function.Name}_{argument.Name}";

			return bufferName;
		}

		public string GetSinglePointerArgumentValueBuffer(Function function, Parameter argument)
		{
			string bufferName = $"{function.Name}_{argument.Name}_value";

			return bufferName;
		}

		public string GetSinglePointerArgumentValueSizeBuffer(Function function, Parameter argument)
		{
			string bufferName = $"{function.Name}_{argument.Name}_value_size";

			return bufferName;
		}

		public string GetSinglePointerArgumentReturnValueBuffer(Function function, Parameter argument)
		{
			string bufferName = $"{function.Name}_{argument.Name}_return_value";

			return bufferName;
		}

		public string GetSinglePointerArgumentReturnValueSizeBuffer(Function function, Parameter argument)
		{
			string bufferName = $"{function.Name}_{argument.Name}_return_value_size";

			return bufferName;
		}

		public string GetDoublePointerArgumentReturnValueBuffer(Function function, Parameter argument)
		{
			string bufferName = GetSinglePointerArgumentReturnValueBuffer(function, argument);

			return bufferName;
		}

		public string GetDoublePointerArgumentReturnValueSizeBuffer(Function function, Parameter argument)
		{
			string bufferName = GetSinglePointerArgumentReturnValueSizeBuffer(function, argument);

			return bufferName;
		}
	}
}
