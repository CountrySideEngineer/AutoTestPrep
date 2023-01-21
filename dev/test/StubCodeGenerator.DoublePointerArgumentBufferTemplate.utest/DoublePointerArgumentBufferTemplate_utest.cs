using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using Declare = CodeGenerator.Stub.Template.BufferDeclare;

namespace StubCodeGenerator.DoublePointerArgumentBufferTemplate.utest
{
	[TestClass]
	public class DoublePointerArgumentBufferTemplate_utest
	{
		[TestMethod]
		public void TransformText_test_001()
		{
			var function = new Function()
			{
				Name = "TestFunction",
			};
			var argument = new Parameter()
			{
				DataType = "short",
				Name = "Argument",
				PointerNum = 2,
			};
			var template = new Declare.DoublePointerArgumentBufferTemplate()
			{
				Rule = new NameRule(),
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"short**			TestFunction_Argument[STUB_BUFFER_SIZE_1];\r\n",
				output
				);
		}
	}
}
