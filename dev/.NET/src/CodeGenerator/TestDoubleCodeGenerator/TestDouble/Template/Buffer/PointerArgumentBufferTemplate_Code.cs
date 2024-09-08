using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.Rule;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Buffer
{
	public partial class PointerArgumentBufferTemplate
	{
		/// <summary>
		/// Default template.
		/// </summary>
		public PointerArgumentBufferTemplate() : base() { }

		/// <summary>
		/// Get code to declare buffer to hold the value passes via pointer argument.
		/// </summary>
		/// <returns>Code to declare buffer.</returns>
		public virtual string BufferDeclareCode()
		{
			Log.TRACE();

			string buffDataType = Argument.DataType;
			string buffName = NameRule.SinglePointerArgumentValueBuffer(Function, Argument);
			string buffDeclare = NameRule.DeclareFormat(buffDataType, buffName);
			string code = $"{buffDeclare}[{NameRule.BufferSize1MacroName}][{NameRule.BufferSize2MacroName}];";

			Log.DEBUG($"{nameof(code),16} = \"{code}\"");

			return code;
		}

		/// <summary>
		/// Get code to declare variable about size of data to get from region the pointer argument points.
		/// </summary>
		/// <returns>Code to declare buffer size.</returns>
		public virtual string BuffSizeDeclare()
		{
			Log.TRACE();

			string buffDataType = "long";
			string buffName = NameRule.SinglePointerArgumentValueSizeBuffer(Function, Argument);
			string buffDeclare = NameRule.DeclareFormat(buffDataType, buffName);
			string code = $"{buffDeclare}[{NameRule.BufferSize1MacroName}];";

			Log.DEBUG($"{nameof(code),16} = \"{code}\"");

			return code;
		}
	}
}
