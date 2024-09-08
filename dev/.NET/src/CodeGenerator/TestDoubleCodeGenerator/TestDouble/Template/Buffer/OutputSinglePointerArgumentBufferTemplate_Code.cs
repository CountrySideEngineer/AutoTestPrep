using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.Rule;

namespace TestDoubleCodeGenerator.TestDouble.Template.Buffer
{
	public partial class OutputSinglePointerArgumentBufferTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public OutputSinglePointerArgumentBufferTemplate() : base() { }

		/// <summary>
		/// Get code to declare buffer to hold the value passes via pointer argument.
		/// </summary>
		/// <returns>Code to declare buffer.</returns>
		public override string BufferDeclareCode()
		{
			Log.TRACE();

			string buffDataType = Function.DataType;
			string buffName = NameRule.SingglePointerArgumentReturnValueBuffer(Function, Argument);
			string buffDeclare = NameRule.DeclareFormat(buffDataType, buffName);
			string code = $"{buffDeclare}[{NameRule.BufferSize1MacroName}][{NameRule.BufferSize2MacroName}];";

			Log.DEBUG($"{nameof(code),16} = \"{code}\"");

			return code;
		}

		/// <summary>
		/// Get code to declare variable about size of data to get from region the pointer argument points.
		/// </summary>
		/// <returns>Code to declare buffer size.</returns>
		public override string BuffSizeDeclare()
		{
			Log.TRACE();

			string buffDataType = "long";
			string buffName = NameRule.SingglePointerArgumentReturnValueSizeBuffer(Function, Argument);
			string buffDeclare = NameRule.DeclareFormat(buffDataType, buffName);
			string code = $"{buffDeclare}[{NameRule.BufferSize1MacroName}];";

			Log.DEBUG($"{nameof(code),16} = \"{code}\"");

			return code;
		}
	}
}
