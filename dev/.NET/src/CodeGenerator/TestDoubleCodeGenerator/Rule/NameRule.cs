using Logger;
using TestReader.Model;
using Function = TestReader.Model.Function;

namespace TestDoubleCodeGenerator.Rule
{
	internal class NameRule
	{
		public static string InitializeMethodName(Function function)
		{
			Log.TRACE();

			string initFuncName = $"{function.Name}_init";

			Log.DEBUG($"{nameof(initFuncName),16} = \"{initFuncName}\"");

			return initFuncName;
		}

		/// <summary>
		/// Get the name fo variable that keeps track of the number of times the function has been called.
		/// </summary>
		/// <param name="function">Target function.</param>
		/// <returns>The name of variable.</returns>
		public static string CalledCount(Function function)
		{
			Log.TRACE();

			string calledCount = $"{function.Name}_called_count";

			Log.DEBUG($"{nameof(calledCount),16} = \"{calledCount}\"");

			return calledCount;
		}

		/// <summary>
		/// Get the name of variable that holds the values returned by the function.
		/// </summary>
		/// <param name="function">Target function.</param>
		/// <returns>The variable name.</returns>
		public static string ReturnValue(Function function)
		{
			Log.TRACE();

			string returnValue = $"{function.Name}_return_value";

			Log.DEBUG($"{nameof(returnValue),16} = \"{returnValue}\"");

			return returnValue;
		}

		/// <summary>
		/// Get the name of variable that holds the argument value.
		/// </summary>
		/// <param name="function">Target function.</param>
		/// <param name="argument">The argument.</param>
		/// <returns>The variable name.</returns>
		public static string ArgumentBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Get the name of variable that hold the value of the memory region pointed to by a pointer.
		/// </summary>
		/// <param name="function">Target function</param>
		/// <param name="argument">The argument.</param>
		/// <returns>The variable name.</returns>
		public static string SinglePointerArgumentValueBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}_value";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Get the name of variable that holds the value 
		/// </summary>
		/// <param name="function">Target function.</param>
		/// <param name="argument">Argument.</param>
		/// <returns>The variable name.</returns>
		public static string SinglePointerArgumentValueSizeBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}_value_size";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Get the name of variable that hold the value the test double will return via pointer argument.
		/// </summary>
		/// <param name="function">Target function</param>
		/// <param name="argument">The argument.</param>
		/// <returns>The variable name.</returns>
		public static string SinglePointerArgumentReturnValueBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}_return_value";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Get the name of variable that hold the value the test double will return via pointer argument.
		/// </summary>
		/// <param name="function">Target function</param>
		/// <param name="argument">The argument.</param>
		/// <returns>The variable name.</returns>
		public static string SinglePointerArgumentReturnValueSizeBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}_return_value_size";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Get the name of variable that hold the value the test double will return via pointer argument.
		/// </summary>
		/// <param name="function">Target function</param>
		/// <param name="argument">The argument.</param>
		/// <returns>The variable name.</returns>
		public static string DoublePointerArgumentReturnValueBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}_return_value";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Get the name of variable that hold the value the test double will return via pointer argument.
		/// </summary>
		/// <param name="function">Target function</param>
		/// <param name="argument">The argument.</param>
		/// <returns>The variable name.</returns>
		public static string DobulePointerArgumentReturnValueSizeBuffer(Function function, Parameter argument)
		{
			Log.TRACE();

			string argumentBuffer = $"{function.Name}_{argument.Name}_return_value_size";

			Log.DEBUG($"{nameof(argumentBuffer),16} = \"{argumentBuffer}\"");

			return argumentBuffer;
		}

		/// <summary>
		/// Generate code to declare parameter in a format.
		/// </summary>
		/// <param name="dataType">Data type of parameter.</param>
		/// <param name="name">Parameter name.</param>
		/// <returns>Code to declare parameter in a specified format.</returns>
		public static string DeclareFormat(string dataType, string name)
		{
			Log.TRACE();

			string declareCode = $"{dataType,-16}\t{name}";

			Log.DEBUG($"{nameof(declareCode),16} = \"{declareCode}\"");

			return declareCode;
		}

		public static string BufferSize1MacroName
		{
			get
			{
				return "BUFFER_SIZE_1";
			}
		}

		public static string BufferSize2MacroName
		{
			get
			{
				return "BUFFER_SIZE_2";
			}
		}
	}
}
