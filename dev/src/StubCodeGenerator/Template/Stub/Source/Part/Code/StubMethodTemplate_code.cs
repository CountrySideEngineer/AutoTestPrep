using CodeGenerator.Stub.Template.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Stub.Source.Part
{
	public partial class StubMethodTemplate
	{
		public ATemplateFactory FuncReturnLatchFactory { get; set; }

		public ATemplateFactory ArgumentFactory { get; set; }

		public ATemplateFactory CalledCountFactory { get; set; }

		public ATemplateFactory ReturnCodeFactory { get; set; }

		public StubMethodTemplate() : base()
		{
			var rule = new Rule.NameRule();
			FuncReturnLatchFactory = new FuncReturnLatchTemplateFactory(rule);
			ArgumentFactory = new ArgBufferInStubSourceTemplateFactory(rule);
			CalledCountFactory = new FuncCalledCountUpdateTemplateFactory(rule);
			ReturnCodeFactory = new FuncReturnValueCodeFactory(rule);
		}
	}
}
