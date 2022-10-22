using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.BufferDeclare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;
using BufferTemplate = CodeGenerator.Stub.Template.BufferInit;

namespace CodeGenerator.Stub.Template.Factory
{
	public class ArgBufferInitTemplateFactory : ATemplateFactory
	{
		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public ArgBufferInitTemplateFactory(NameRule rule) : base(rule) { }

		/// <summary>
		/// Returns template for argument buffer.
		/// </summary>
		/// <param name="function">Target function data.</param>
		/// <param name="argument">Target argument data.</param>
		/// <returns>Template to generate code to declare buffer of stub function argument.</returns>
		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			try
			{
				BufferTemplate.ArgumentBufferTemplate template = null;
				if (0 == argument.PointerNum)
				{
					template = new BufferTemplate.ArgumentBufferTemplate();
				}
				else if (1 == argument.PointerNum)
				{
					if (Parameter.AccessMode.In.Equals(argument.Mode))
					{
						template = new BufferTemplate.SinglePointerArgumentBufferTemplate();
					}
					else if ((Parameter.AccessMode.Out.Equals(argument.Mode)) ||
						(Parameter.AccessMode.Both.Equals(argument.Mode)))
					{
						template = new BufferTemplate.SinglePointerArgumentWithOutputBufferTemplate();
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
						template = new BufferTemplate.DoublePointerArgumentBufferTemplate();
					}
					else if ((Parameter.AccessMode.Out.Equals(argument.Mode)) ||
						(Parameter.AccessMode.Both.Equals(argument.Mode)))
					{
						template = new BufferTemplate.DoublePointerArgumentWithOutputBufferTemplate();
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
