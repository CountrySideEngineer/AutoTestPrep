using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.BufferInit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;

namespace StubCodeGenerator.BuffInit.FunctionBufferTemplate.utest
{
	[TestClass]
	public class FunctionBufferInitTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_test_001()
		{
			var function = new Function()
			{
				DataType = "void",
				Name = "SampleFunction",
			};
			var rule = new NameRule();
			var template = new FunctionBufferInitTemplate()
			{
				Target = function,
				Rule = rule,
			};
			string output = template.TransformText();

			Assert.AreEqual(
				"	SampleFunction_called_count = 0;\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_test_002()
		{
			var function = new Function()
			{
				DataType = "short",
				Name = "SampleFunction",
			};
			var rule = new NameRule();
			var template = new FunctionBufferInitTemplate()
			{
				Target = function,
				Rule = rule,
			};
			string output = template.TransformText();

			Assert.AreEqual(
				"	SampleFunction_called_count = 0;\r\n",
				output);
		}
	}
}
