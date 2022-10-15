using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using Declare = CodeGenerator.Stub.Template.BufferDeclare;
namespace StubCodeGenerator.SinglePointerArgumentWithOutputBufferTemplate.utest
{
	[TestClass]
	public class SinglePointerArgumentBufferTemplate_utest
	{
		[TestMethod]
		public void TranformText_test_001()
		{
			var function = new Function()
			{
				Name = "Function",
			};
			var argument = new Parameter()
			{
				DataType = "int",
				Name = "Argument",
				PointerNum = 1,
			};
			var rule = new NameRule();
			var template = new Declare.SinglePointerArgumentWithOutputBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"int* Function_Argument[STUB_BUFFER_SIZE_1];\r\n" +
				"int Function_Argument_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long Function_Argument_value_size[STUB_BUFFER_SIZE_1];\r\n" +
				"int Function_Argument_return_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long Function_Argument_return_value_size[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}
	}
}
