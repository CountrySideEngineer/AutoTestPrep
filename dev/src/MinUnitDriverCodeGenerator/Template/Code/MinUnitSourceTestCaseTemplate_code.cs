using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Data;
using TestParser.Target;

namespace CodeGenerator.TestDriver.Template
{
	public partial class MinUnitSourceTestCaseTemplate
	{
		public Function TargetFunction { get; set; }

		public TestCase TestCase { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected MinUnitSourceTestCaseTemplate()
		{
			this.TargetFunction = new Function();
			this.TestCase = new TestCase();
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="function">Test target function data.</param>
		/// <param name="testCase">Test case data.</param>
		public MinUnitSourceTestCaseTemplate(Function function, TestCase testCase)
		{
			this.TargetFunction = function;
			this.TestCase = testCase;
		}

		/// <summary>
		/// Create code to declare return value buffer.
		/// </summary>
		/// <param name="function">Test target function.</param>
		/// <returns>Return value buffer declare code.</returns>
		public virtual string CreateReturnValueBufferDeclare(Function function)
		{
			string bufferDeclareCode = string.Empty;
			if (function.HasReturn())
			{
				bufferDeclareCode = $"{function.ActualDataType()} returnValue";
			}
			else
			{
				bufferDeclareCode = $"//{function.Name} does not return value.";
			}
			return bufferDeclareCode;
		}

		/// <summary>
		/// Create code to call test target function.
		/// </summary>
		/// <param name="function">Test target function data.</param>
		/// <returns>Function call code.</returns>
		public virtual string CreateTargetFunctionCall(Function function)
		{
			if ((string.IsNullOrEmpty(function.Name)) || (string.IsNullOrWhiteSpace(function.Name)))
			{
				throw new ArgumentException();
			}

			string functionCall = string.Empty;
			if (function.HasReturn())
			{
				functionCall = $"{function.ActualDataType()} _ret_val = ";
			}
			functionCall += $"{function.Name}(";
			bool isTop = true;
			foreach (var argument in function.Arguments)
			{
				if (!isTop)
				{
					functionCall += ", ";
				}
				functionCall += argument.Name;
				isTop = false;
			}
			functionCall += ")";
			return functionCall;
		}

		/// <summary>
		/// Create codes to declare argument variable.s
		/// </summary>
		/// <param name="argument">Argument data.</param>
		/// <returns>Codes to declare argument.</returns>
		protected virtual string CreateCodeToDeclareArgument(Parameter argument)
		{
			string declare = string.Empty;
			if (1 == argument.PointerNum)
			{
				declare = $"\t{argument.DataType} _{argument.Name}[100];"
					+ Environment.NewLine;
			}
			else if (2 == argument.PointerNum)
			{
				declare = $"\t{argument.DataType}* _{argument.Name}[100];"
					+ Environment.NewLine;
			}
			declare += $"\t{argument.ActualDataType()} {argument.Name};";
			return declare;
		}
	}
}
