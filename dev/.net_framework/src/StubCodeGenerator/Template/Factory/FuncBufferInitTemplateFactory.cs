using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.BufferInit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Factory
{
	public class FuncBufferInitTemplateFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule"></param>
		public FuncBufferInitTemplateFactory(NameRule rule) : base(rule) { }

		/// <summary>
		/// Return template for function initialize buffer.
		/// </summary>
		/// <param name="function">Target function data.</param>
		/// <param name="argument">Not used.</param>
		/// <returns>Template for initializing function buffer.</returns>
		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			ABufferTemplate template = null;
			try
			{
				if (function.HasReturn())
				{
					template = new FunctionReturnValueBufferTemplate();
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
