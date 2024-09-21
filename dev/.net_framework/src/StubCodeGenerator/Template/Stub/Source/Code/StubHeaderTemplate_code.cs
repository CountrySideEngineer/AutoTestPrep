using CodeGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Stub.Source
{
	public partial class StubHeaderTemplate
	{
		public Function ParentFunction { get; set; }

		public CodeConfiguration Config { get; set; }

		public StubHeaderTemplate()
		{
			ParentFunction = new Function();
			Config = new CodeConfiguration();
		}

		public StubHeaderTemplate(Function function)
		{
			ParentFunction = function;
			Config = new CodeConfiguration();
		}

		public StubHeaderTemplate(CodeConfiguration config)
		{
			ParentFunction = new Function();
			Config = config;
		}

		public StubHeaderTemplate(Function function, CodeConfiguration config)
		{
			ParentFunction = function;
			Config = config;
		}

	}
}
