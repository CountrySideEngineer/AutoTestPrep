using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using BuffInitTemplate = CodeGenerator.Stub.Template.BufferInit;

namespace StubCodeGenerator.BuffInit.ArgumentBufferTemplate.utest
{
	[TestClass]
	public class ArgumentBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_001()
		{
			var function = new Function()
			{
				DataType = "short",
				Name = "SampleFunction",
			};
			var argument = new Parameter()
			{
				DataType = "long",
				Name = "SampleArgument",
			};
			var rule = new NameRule();
			var template = new BuffInitTemplate.ArgumentBufferTemplate()
			{
				Target = function,
				Argument = argument,
				Rule = rule,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"	//Initialize the buffer for argument SampleArgument.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		SampleFunction_SampleArgument[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n",
				output);
		}
	}
}
