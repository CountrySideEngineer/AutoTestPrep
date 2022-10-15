using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using Declare = CodeGenerator.Stub.Template.BufferDeclare;
namespace StubCodeGenerator.DoublePointerArgumentWithOutputBufferTemplate.utest
{
	[TestClass]
	public class DoublePointerArgumentWithOutputBufferTemplate_utest
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
				PointerNum = 2,
			};
			var rule = new NameRule();
			var template = new Declare.DoublePointerArgumentWithOutputBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"int** Function_Argument[STUB_BUFFER_SIZE_1];\r\n" +
				"int Function_Argument_return_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long Function_Argument_return_value_size[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}
	}
}
