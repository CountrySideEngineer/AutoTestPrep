using CodeGenerator.Data;
using CodeGenerator.Stub.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BufferDeclare.FunctionBufferSizeMacroTemplate_utest
{
	[TestClass]
	public class FunctionBufferSizeMacroTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TrasnsformText_test_001()
		{
			var config = new CodeConfiguration()
			{
				BufferSize1 = 1,
				BufferSize2 = 2,
			};
			var template = new FunctionBufferSizeMacroTemplate(config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(1)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(2)\r\n" +
				"#endif\r\n",
				output);
		}
	}
}
