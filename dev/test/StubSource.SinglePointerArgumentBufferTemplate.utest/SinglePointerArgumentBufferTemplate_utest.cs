using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using StubBody = CodeGenerator.Stub.Template.StubSource;

namespace StubSource.SinglePointerArgumentBufferTemplate.utest
{
	[TestClass]
	public class SinglePointerArgumentBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_utest_001()
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
			var template = new StubBody.SinglePointerArgumentBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"	Function_Argument[Function_called_count] = Argument;\r\n" +
				"\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < Function_Argument_value_size[Function_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		Function_Argument_value[Function_called_count][index] = *(Argument + index);\r\n" +
				"	}\r\n",
				output);
		}
	}
}
