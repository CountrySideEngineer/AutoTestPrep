using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.BufferDeclare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Factory
{
	public class FuncBufferDecExternTemplateFactory : ATemplateFactory
	{
		public FuncBufferDecExternTemplateFactory(NameRule rule) : base(rule) { }

		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			ABufferTemplate template = null;
			if (function.HasReturn())
			{
				template = new ExternFunctionReturnValueBufferTemplate();
			}
			else
			{
				template = new ExternFunctionBufferTemplate();
			}
			template.Rule = Rule;
			template.Target = function;

			return template;
		}
	}
}
