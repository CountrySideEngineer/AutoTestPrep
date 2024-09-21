using Logger;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.Rule;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template
{
	public partial class TestDoubleSourceDeclareBufferPartTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestDoubleSourceDeclareBufferPartTemplate() : base() { }

		/// <summary>
		/// Get code to declare buffer to keep track of the number of times the function has been called.
		/// </summary>
		/// <returns>The code to declare buffer to keep track of the number of times the function has been called.</returns>
		public virtual string CalledCountDeclare()
		{
			Log.TRACE();

			string calledCounter = $"{NameRule.CalledCount(TestDoubleFunction)}[{NameRule.BufferSize1MacroName}];";

			Log.DEBUG($"{nameof(calledCounter),16} = {calledCounter}");

			return calledCounter;
		}

		/// <summary>
		/// Get code to declare buffer to keep the values the test double will return.
		/// </summary>
		/// <returns>The code to declare buffer to keep the values the test double will return.</returns>
		public virtual string TestDoubleReturnValueDeclare()
		{
			Log.TRACE();

			if ((0 == TestDoubleFunction.PointerNum) && ("void" == TestDoubleFunction.DataType.ToLower()))
			{
				Log.DEBUG($"The function \"{TestDoubleFunction.Name}\" does not return value.");

				string message = $"// The function \"{TestDoubleFunction.Name}\" does not return value.";

				return message;
			}
			else
			{
				string bufferName = $"{NameRule.ReturnValue(TestDoubleFunction)}[{NameRule.BufferSize1MacroName}]";
				string declareCode = $"{TestDoubleFunction.ActualDataType()}\t{bufferName};";

				Log.DEBUG($"{nameof(declareCode),16} = {declareCode}");

				return declareCode;
			}
		}

		public virtual string ArgumentBufferDeclare()
		{
			Log.TRACE();

			if ((null != TestDoubleFunction.Arguments) && TestDoubleFunction.Arguments.Any())
			{
				string code = string.Empty;
				foreach (var argument in TestDoubleFunction.Arguments)
				{
					string declareCode = ArgumentBufferDeclare(argument);
					code += declareCode;
				}
				return code;
			}
			else
			{
				Log.DEBUG("The function \"{TestDoubleFunction.Name}\"does not have any argument.");
				string message = $"// The function \"{TestDoubleFunction.Name}\"does not have any argument.";

				return message;
			}
		}

		protected virtual string ArgumentBufferDeclare(Parameter argument)
		{
			Log.TRACE();

			if (("void" == argument.DataType) && (argument.PointerNum == 0))
			{
				Log.DEBUG($"The argument \"void\" type and skip generate buffer.");

				return string.Empty;
			}
			else if ((string.IsNullOrEmpty(argument.Name)) || (string.IsNullOrEmpty(argument.Name)))
			{
				Log.WARN($"Invalid argument whose \"Name\" has not been set is found in the \"{TestDoubleFunction.Name}\"");

				throw new ArgumentException("The arugment name invalid.");
			}
			else if ((string.IsNullOrEmpty(argument.DataType)) || (string.IsNullOrEmpty(argument.DataType)))
			{
				Log.WARN($"Invalid argument whose \"Data type\" has not been set is found in the \"{TestDoubleFunction.Name}\"");

				throw new ArgumentException("The arugment data type invalid.");
			}
			else
			{
				string declareCode = $"{argument.ActualDataType}\t" +
					$"{NameRule.ArgumentBuffer(TestDoubleFunction, argument)}" +
					$"[{NameRule.BufferSize1MacroName}];" +
					Environment.NewLine;
				if (1 == argument.PointerNum)
				{
					Log.DEBUG($"The argument \"{argument.Name}\" in \"{TestDoubleFunction.Name}\" is pointer.");
					string inputBufferDeclare = $"{argument.DataType}*\t" +
						$"{NameRule.SinglePointerArgumentValueBuffer(TestDoubleFunction, argument)}" +
						$"[{NameRule.BufferSize1MacroName}][{NameRule.BufferSize2MacroName}];" +
						Environment.NewLine;
					declareCode += inputBufferDeclare;
				}


				return declareCode;
			}
		}
	}
}
