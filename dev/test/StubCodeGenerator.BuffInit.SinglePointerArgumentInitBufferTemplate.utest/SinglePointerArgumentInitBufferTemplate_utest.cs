using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using BufferInit = CodeGenerator.Stub.Template.BufferInit; 

namespace StubCodeGenerator.BuffInit.SinglePointerArgumentInitBufferTemplate.utest
{
	[TestClass]
	public class SinglePointerArgumentInitBufferTemplate_utest
	{
		[TestMethod]
		public void TransformText_utest_001()
		{
			var function = new Function()
			{
				DataType = "short",
				Name = "SampleFunction"
			};
			var argument = new Parameter()
			{
				DataType = "long",
				PointerNum = 1,
				Name = "SampleArgument",
			};
			var rule = new NameRule();
			var template = new BufferInit.SinglePointerArgumentBufferTemplate()
			{
				Target = function,
				Argument = argument,
				Rule = rule,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"	//Initialize the buffers for argument SampleArgument.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		SampleFunction_SampleArgument[index] = 0;\r\n" +
				"		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n" +
				"			SampleFunction_SampleArgument_value[index][index2] = 0;\r\n" +
				"		}\r\n" +
				"		SampleFunction_SampleArgument_value_size[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n",
				output);
		}
	}
}
