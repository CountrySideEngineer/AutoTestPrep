using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.BufferDeclare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;
using BufferTemplate = CodeGenerator.Stub.Template.BufferDeclare;

namespace CodeGenerator.Stub.Template.Factory
{
	public class ArgBufferDecExternTemplateFactory : ATemplateFactory
	{
		public ArgBufferDecExternTemplateFactory(NameRule rule) : base(rule) { }

		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			try
			{
				ArgumentBufferTemplate template = null;
				if (0 == argument.PointerNum)
				{
					template = new BufferTemplate.ExternArgumentBufferTemplate();
				}
				else if (1 == argument.PointerNum)
				{
					if (Parameter.AccessMode.In.Equals(argument.Mode))
					{
						template = new BufferTemplate.ExternSinglePointerArgumentBufferTemplate();
					}
					else if ((Parameter.AccessMode.Out.Equals(argument.Mode)) ||
						(Parameter.AccessMode.Both.Equals(argument.Mode)))
					{
						template = new BufferTemplate.ExternSinglePointerArgumentWithOutputBufferTemplate();
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
						template = new BufferTemplate.ExternDoublePointerArgumentBufferTemplate();
					}
					else if ((Parameter.AccessMode.Out.Equals(argument.Mode)) ||
						(Parameter.AccessMode.Both.Equals(argument.Mode)))
					{
						template = new BufferTemplate.ExternDoublePointerArgumentWithOutputBufferTemplate();
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
