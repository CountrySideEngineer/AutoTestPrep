using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template;
using CodeGenerator.Stub.Template.BufferDeclare;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestParser.Target;

namespace StubCodeGenerator.AbstractDeclareBufferTemplateFactory.utest
{
	public partial class AbstractDeclareBufferTemplateFactory_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_001()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 0,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsFalse(template is SinglePointerArgumentBufferTemplate);
			Assert.IsFalse(template is DoublePointerArgumentBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_002()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 1,
				Mode = Parameter.AccessMode.In,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsTrue(template is SinglePointerArgumentBufferTemplate);
			Assert.IsFalse(template is SinglePointerArgumentWithOutputBufferTemplate);
			Assert.IsFalse(template is DoublePointerArgumentBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_003()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 1,
				Mode = Parameter.AccessMode.Out,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsTrue(template is SinglePointerArgumentBufferTemplate);
			Assert.IsTrue(template is SinglePointerArgumentWithOutputBufferTemplate);
			Assert.IsFalse(template is DoublePointerArgumentBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_004()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 1,
				Mode = Parameter.AccessMode.Both,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsTrue(template is SinglePointerArgumentBufferTemplate);
			Assert.IsTrue(template is SinglePointerArgumentWithOutputBufferTemplate);
			Assert.IsFalse(template is DoublePointerArgumentBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[ExpectedException(typeof(ArgumentException))]
		public void GetTemplateForArgument_utest_005()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 1,
				Mode = Parameter.AccessMode.None,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_006()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 2,
				Mode = Parameter.AccessMode.In,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsFalse(template is SinglePointerArgumentBufferTemplate);
			Assert.IsTrue(template is DoublePointerArgumentBufferTemplate);
			Assert.IsFalse(template is SinglePointerArgumentWithOutputBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_007()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 2,
				Mode = Parameter.AccessMode.Out,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsFalse(template is SinglePointerArgumentBufferTemplate);
			Assert.IsTrue(template is DoublePointerArgumentBufferTemplate);
			Assert.IsTrue(template is DoublePointerArgumentWithOutputBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		public void GetTemplateForArgument_utest_008()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 2,
				Mode = Parameter.AccessMode.Both,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);

			Assert.IsTrue(template is ArgumentBufferTemplate);
			Assert.IsFalse(template is SinglePointerArgumentBufferTemplate);
			Assert.IsTrue(template is DoublePointerArgumentBufferTemplate);
			Assert.IsTrue(template is DoublePointerArgumentWithOutputBufferTemplate);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[ExpectedException(typeof(ArgumentException))]
		public void GetTemplateForArgument_utest_009()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 2,
				Mode = Parameter.AccessMode.None,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[ExpectedException(typeof(ArgumentException))]
		public void GetTemplateForArgument_utest_010()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = 3,
				Mode = Parameter.AccessMode.In,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[ExpectedException(typeof(ArgumentException))]
		public void GetTemplateForArgument_utest_011()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = -1,
				Mode = Parameter.AccessMode.In,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, argument);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[ExpectedException(typeof(ArgumentNullException))]
		public void GetTemplateForArgument_utest_012()
		{
			var rule = new NameRule();
			var target = new Function();
			var argument = new Parameter()
			{
				PointerNum = -1,
				Mode = Parameter.AccessMode.In,
			};
			var factory = new CodeGenerator.Stub.Template.Factory.AbstractDeclareBufferTemplateFactory(rule);
			ABufferTemplate template = factory.GetTemplateForArgument(target, null);
		}
	}
}
