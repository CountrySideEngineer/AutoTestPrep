using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;

namespace SinglePointerArgumentBufferTemplate.utest
{
	[TestClass]
	public class SinglePointerArgumentBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_test_001()
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
			var template = new CodeGenerator.Stub.Template.SinglePointerArgumentBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"int Function_Argument[STUB_BUFFER_SIZE_1];\r\n" +
				"int Function_Argument_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long Function_Argument_value_size[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_test_002()
		{
			var function = new Function()
			{
				Name = "Function",
			};
			var argument = new Parameter()
			{
				DataType = "short",
				Name = "Argument",
			};
			var rule = new NameRule();
			var template = new CodeGenerator.Stub.Template.SinglePointerArgumentBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"short Function_Argument[STUB_BUFFER_SIZE_1];\r\n" +
				"short Function_Argument_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long Function_Argument_value_size[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}
	}
}
