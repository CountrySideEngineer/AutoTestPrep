using CodeGenerator.Stub.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;
using BufferTemplate = CodeGenerator.Stub.Template.BufferDeclare;

namespace CodeGenerator.Stub.Template.Factory
{
	public class FuncBufferDecTemplateFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule"></param>
		public FuncBufferDecTemplateFactory(NameRule rule) : base(rule) { }

		/// <summary>
		/// Returns template for function buffer.
		/// </summary>
		/// <param name="function">Target function data.</param>
		/// <param name="argument">Not used.</param>
		/// <returns>Template to generate codes to declare buffert of stub function.</returns>
		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			ABufferTemplate template = null;
			if (function.HasReturn())
			{
				template = new BufferTemplate.FunctionReturnValueBufferTemplate();
			}
			else
			{
				template = new BufferTemplate.FunctionBufferTemplate();
			}
			template.Rule = Rule;
			template.Target = function;

			return template;
		}	
	}
}
