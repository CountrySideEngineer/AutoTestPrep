using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using StubBody = CodeGenerator.Stub.Template.StubSource;

namespace StubSource.ArgumentBufferTemplate.utest
{
	[TestClass]
	public class ArgumentBufferTemplate_utest
	{
		[TestMethod]
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
			var template = new StubBody.ArgumentBufferTemplate()
			{
				Rule = rule,
				Target = function,
				Argument = argument,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"	//Set argument value to buffer.\r\n" +
				"	Function_Argument[Function_called_count] = Argument;\r\n" +
				"\r\n",
				output);
		}
	}

}
