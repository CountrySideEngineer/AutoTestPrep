using CodeGenerator.Stub.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;
using BufferTemplate = CodeGenerator.Stub.Template.StubSource;

namespace CodeGenerator.Stub.Template.Factory
{
	public class FuncCalledCountUpdateTemplateFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public FuncCalledCountUpdateTemplateFactory(NameRule rule) : base(rule) { }

		/// <summary>
		/// Returns template for function called counter buffer.
		/// </summary>
		/// <param name="function">Target function data.</param>
		/// <param name="argument">Not used.</param>
		/// <returns>Template to generate codes to update the number of times the method called.</returns>
		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			ABufferTemplate template = null;
			template = new BufferTemplate.FunctionCalledCountUpdateTemplate();
			template.Rule = Rule;
			template.Target = function;

			return template;
		}
	}
}
