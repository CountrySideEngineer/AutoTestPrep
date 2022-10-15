using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;

namespace StubCodeGenerator.AbstractDeclareBufferTemplateFactory.utest
{
	[TestClass]
	public partial class AbstractDeclareBufferTemplateFactory_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForFunc_utest_001()
		{
			var rule = new NameRule();
			var target = new Function();
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForFunc(target);

			Assert.IsTrue(template is FunctionBufferTemplate);
		}
	}
}
