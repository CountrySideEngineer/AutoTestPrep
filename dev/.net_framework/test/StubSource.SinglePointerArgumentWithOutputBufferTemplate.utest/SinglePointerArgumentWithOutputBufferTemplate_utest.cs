using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using StubBody = CodeGenerator.Stub.Template.StubSource;

namespace StubSource.SinglePointerArgumentWithOutputBufferTemplate.utest
{
	[TestClass]
	public class SinglePointerArgumentWithOutputBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
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
			var template = new StubBody.SinglePointerArgumentWithOutputBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"	//Set argument value to buffer.\r\n" +
				"	Function_Argument[Function_called_count] = Argument;\r\n" +
				"\r\n" +
				"	//Set values in an area specified by pointer argument to buffer.\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < Function_Argument_value_size[Function_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		Function_Argument_value[Function_called_count][index] = *(Argument + index);\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Set values in buffer to area specified by pointer argument.\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < Function_Argument_return_value_size[Function_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		*(Argument + index) = Function_Argument_return_value[Function_called_count][index];\r\n" +
				"	}\r\n" +
				"\r\n",
				output);

		}
	}
}
