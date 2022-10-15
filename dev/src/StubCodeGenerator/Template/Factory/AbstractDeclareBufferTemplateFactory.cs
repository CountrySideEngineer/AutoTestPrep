using CodeGenerator.Stub.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Factory
{
	public class AbstractDeclareBufferTemplateFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public AbstractDeclareBufferTemplateFactory(NameRule rule) : base(rule) { }

		/// <summary>
		/// Returns template for function code.
		/// </summary>
		/// <param name="target">Target function object.</param>
		/// <returns>Template to generate code about stub function buffer.</returns>
		public override ABufferTemplate GetTemplateForFunc(Function target)
		{
			var template = new FunctionBufferTemplate()
			{
				Rule = Rule,
				Target = target,
			};
			return template;
		}

		/// <summary>
		/// Returns template for argument buffer.
		/// </summary>
		/// <param name="function">Target function data.</param>
		/// <param name="argument">Target argument data.</param>
		/// <returns>Template to generate code to declare buffer of stub function argument.</returns>
		public override ABufferTemplate GetTemplateForArgument(Function function, Parameter argument)
		{
			try
			{
				ArgumentBufferTemplate template = null;
				if (0 == argument.PointerNum)
				{
					template = new ArgumentBufferTemplate();
				}
				else if (1 == argument.PointerNum)
				{
					if (Parameter.AccessMode.In.Equals(argument.Mode))
					{
						template = new SinglePointerArgumentBufferTemplate();
					}
					else if ((Parameter.AccessMode.Out.Equals(argument.Mode)) ||
						(Parameter.AccessMode.Both.Equals(argument.Mode)))
					{
						template = new SinglePointerArgumentWithOutputBufferTemplate();
					}
					else
					{
						throw new ArgumentException();
					}
				}
				else if (2 == argument.PointerNum)
				{
					if (Parameter.AccessMode.In.Equals(argument.Mode))
					{
						template = new DoublePointerArgumentBufferTemplate();
					}
					else if ((Parameter.AccessMode.Out.Equals(argument.Mode)) ||
						(Parameter.AccessMode.Both.Equals(argument.Mode)))
					{
						template = new DoublePointerArgumentWithOutputBufferTemplate();
					}
					else
					{
						throw new ArgumentException();
					}
				}
				else
				{
					throw new ArgumentException();
				}
				template.Rule = Rule;
				template.Target = function;
				template.Argument = argument;

				return template;
			}
			catch (NullReferenceException)
			{
				throw new ArgumentNullException();
			}
		}
	}
}
