using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;
using CodeGenerator.Stub.Template.Factory;
using CodeGenerator.Stub.Rule;
using BufferTemplate = CodeGenerator.Stub.Template.Stub.Source.Part;

namespace Stub.Source.Part.ArgumentBufferTemplate.test
{
	[TestClass]
	public class ArgumentBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("Template test")]
		public void TransformText_test_001()
		{
			var function = new Function()
			{
				DataType = "int",
				Name = "Func1",
				Arguments = new List<Parameter>
				{
					new Parameter()
					{
						DataType = "Type1",
						Name = "Arg1",
					}
				}
			};
			var templateFactory = new ArgBufferDecTemplateFactory(new NameRule());
			var template = new BufferTemplate.ArgumentBufferTemplate()
			{
				Target = function,
				TemplateFactory = templateFactory,
			};
			string output = template.TransformText();
		}
	}
}
