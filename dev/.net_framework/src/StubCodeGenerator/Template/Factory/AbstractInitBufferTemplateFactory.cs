using CodeGenerator.Stub.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Factory
{
	public class AbstractInitBufferTemplateFactory : ATemplateFactory
	{
		public AbstractInitBufferTemplateFactory(NameRule rule) : base(rule) { }

		public override ABufferTemplate Create(Function function, Parameter argument)
		{
			throw new NotImplementedException();
		}
	}
}
