using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using StubBody = CodeGenerator.Stub.Template.StubSource;

namespace StubSource.FunctionReturnValueLatchTemplate.utest
{
	[TestClass]
	public class FunctionReturnValueLatchTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_utest_001()
		{
			var function = new Function()
			{
				DataType = "int",
				Name = "Function",
			};
			var rule = new NameRule();
			var template = new StubBody.FunctionReturnValueLatchTemplate()
			{
				Rule = rule,
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"	int latchReturn = Function_return_value[Function_called_count];\r\n", 
				output);
		}
	}
}
