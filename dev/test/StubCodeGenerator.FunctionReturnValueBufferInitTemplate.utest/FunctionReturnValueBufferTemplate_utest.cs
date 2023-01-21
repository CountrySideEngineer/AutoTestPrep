using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.BufferInit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;

namespace StubCodeGenerator.FunctionReturnValueBufferInitTemplate.utest
{
	[TestClass]
	public class FunctionReturnValueBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_utest_001()
		{
			var function = new Function()
			{
				DataType = "void",
				PointerNum = 0,
				Name = "SampleFunction",
			};
			var rule = new NameRule();
			var template = new FunctionReturnValueBufferTemplate()
			{
				Target = function,
				Rule = rule,
			};
			string output = template.TransformText();

			Assert.AreEqual(
				"	//Initialize the number of function calls.\r\n" +
				"	SampleFunction_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the SampleFunction stub method will return.\r\n" + 
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		SampleFunction_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n",
				output
				);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_utest_002()
		{
			var function = new Function()
			{
				DataType = "void",
				PointerNum = 1,
				Name = "SampleFunction",
			};
			var rule = new NameRule();
			var template = new FunctionReturnValueBufferTemplate()
			{
				Target = function,
				Rule = rule,
			};
			string output = template.TransformText();

			Assert.AreEqual(
				"	//Initialize the number of function calls.\r\n" +
				"	SampleFunction_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the SampleFunction stub method will return.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		SampleFunction_return_value[index] = NULL;\r\n" +
				"	}\r\n" +
				"\r\n",
				output
				);
		}
	}
}
