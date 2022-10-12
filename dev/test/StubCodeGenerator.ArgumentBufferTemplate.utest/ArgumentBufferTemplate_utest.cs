using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;

namespace StubCodeGenerator.ArgumentBufferTemplate.utest
{
	[TestClass]
	public class ArgumentBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void Transform_test_001()
		{
			var function = new Function()
			{
				Name = "Function",
			};
			var argument = new Parameter()
			{
				DataType = "int",
				Name = "Argument",
			};
			var rule = new NameRule();
			var template = new CodeGenerator.Stub.Template.ArgumentBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"int Function_Argument[STUB_BUFFER_SIZE_1];\r\n",
				output);

		}
	}
}
