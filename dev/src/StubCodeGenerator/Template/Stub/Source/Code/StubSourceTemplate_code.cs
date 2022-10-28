using CodeGenerator.Data;
using CodeGenerator.Stub.Template.Stub.Source.Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Stub.Source
{
	public partial class StubSourceTemplate
	{
		public Function ParentFunction { get; set; }

		public CodeConfiguration Config { get; set; }

		public string StubHeaderFileName { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public StubSourceTemplate()
		{
			ParentFunction = new Function();
			Config = new CodeConfiguration();
		}

		public StubSourceTemplate(Function function)
		{
			ParentFunction = function;
			Config = new CodeConfiguration();
		}

		public StubSourceTemplate(CodeConfiguration config)
		{
			ParentFunction = new Function();
			Config = config;
		}

		public StubSourceTemplate(Function function, CodeConfiguration config)
		{
			ParentFunction = function;
			Config = config;
		}
	}
}
