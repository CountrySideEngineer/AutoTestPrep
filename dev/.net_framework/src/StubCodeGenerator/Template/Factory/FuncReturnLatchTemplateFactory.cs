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
	public class FuncReturnLatchTemplateFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public FuncReturnLatchTemplateFactory(NameRule rule) : base(rule) { }

		/// <summary>
		/// Returns template for stub method returns.
		/// </summary>
		/// <param name="function"></param>
		/// <param name="argument"></param>
		/// <returns></returns>
		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			ABufferTemplate template = null;
			try
			{
				if (function.HasReturn())
				{
					template = new FunctionReturnValueLatchTemplate();
				}
				else
				{
					template = new FunctionBufferTemplate();
				}
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
