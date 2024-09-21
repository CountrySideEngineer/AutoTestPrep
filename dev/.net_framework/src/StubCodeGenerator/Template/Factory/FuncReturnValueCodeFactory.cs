using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.StubSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Factory
{
	public class FuncReturnValueCodeFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public FuncReturnValueCodeFactory(NameRule rule) : base(rule) { }

		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			ABufferTemplate template = null;
			try
			{
				template = new FunctionReturnValueCodeTemplate();
				template.Rule = Rule;
				template.Target = function;

				return template;
			}
			catch (NullReferenceException)
			{
				throw new ArgumentNullException();
			}
		}
	}
}
