using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;
using Declare = CodeGenerator.Stub.Template.BufferDeclare;
namespace StubCodeGenerator.FunctionBufferTemplate.utest
{
	[TestClass]
	public class FunctionBufferTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TestTransformText_test_001()
		{
			var function = new Function()
			{
				DataType = "void",
				Name = "TestFunction"
			};
			var template = new Declare.FunctionBufferTemplate()
			{
				Target = function,
				Rule = new NameRule(),
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long			TestFunction_called_count;\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void TestTransformText_test_002()
		{
			var function = new Function()
			{
				DataType = "int",
				Name = "TestFunction"
			};
			var template = new Declare.FunctionBufferTemplate()
			{
				Target = function,
				Rule = new NameRule(),
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long			TestFunction_called_count;\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void TestTransformText_test_003()
		{
			var function = new Function()
			{
				DataType = "void",
				PointerNum = 1,
				Name = "TestFunction"
			};
			var template = new Declare.FunctionBufferTemplate()
			{
				Target = function,
				Rule = new NameRule(),
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long			TestFunction_called_count;\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void TestTransformText_test_004()
		{
			var function = new Function()
			{
				DataType = "int",
				PointerNum = 1,
				Name = "TestFunction"
			};
			var template = new Declare.FunctionBufferTemplate()
			{
				Target = function,
				Rule = new NameRule(),
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long			TestFunction_called_count;\r\n",
				output);
		}
	}
}
