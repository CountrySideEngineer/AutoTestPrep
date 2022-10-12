using CodeGenerator.Data;
using CodeGenerator.Stub.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace StubCodeGenerator.IncludeHeaderTemplate.utest
{
	[TestClass]
	public class InlucdeHeaderTemplate_utest
	{
		[TestMethod]
		public void TransformText_001()
		{
			var config = new CodeConfiguration();
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"No standard header files specified to include.\r\n" +
				"No user header files specified to include.\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_002()
		{
			var config = new CodeConfiguration();
			config.StandardHeaderFiles = new List<string>
			{
				"standardHeader"
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"#include <standardHeader>\r\n" +
				"No user header files specified to include.\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_003()
		{
			var config = new CodeConfiguration();
			config.StandardHeaderFiles = new List<string>
			{
				"standardHeader_001",
				"standardHeader_002",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"#include <standardHeader_001>\r\n" +
				"#include <standardHeader_002>\r\n" +
				"No user header files specified to include.\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_004()
		{
			var config = new CodeConfiguration();
			config.UserHeaderFiles = new List<string>()
			{
				"userHeader_001",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"No standard header files specified to include.\r\n" +
				"#include \"userHeader_001\"\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_005()
		{
			var config = new CodeConfiguration();
			config.UserHeaderFiles = new List<string>()
			{
				"userHeader_001",
				"userHeader_002",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"No standard header files specified to include.\r\n" +
				"#include \"userHeader_001\"\r\n" +
				"#include \"userHeader_002\"\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_006()
		{
			var config = new CodeConfiguration();
			config.StandardHeaderFiles = new List<string>
			{
				"standardHeader_001",
			};
			config.UserHeaderFiles = new List<string>()
			{
				"userHeader_001",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"#include <standardHeader_001>\r\n" +
				"#include \"userHeader_001\"\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_007()
		{
			var config = new CodeConfiguration();
			config.StandardHeaderFiles = new List<string>
			{
				"standardHeader_001",
				"standardHeader_002",
			};
			config.UserHeaderFiles = new List<string>()
			{
				"userHeader_001",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"#include <standardHeader_001>\r\n" +
				"#include <standardHeader_002>\r\n" +
				"#include \"userHeader_001\"\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_008()
		{
			var config = new CodeConfiguration();
			config.StandardHeaderFiles = new List<string>
			{
				"standardHeader_001",
			};
			config.UserHeaderFiles = new List<string>()
			{
				"userHeader_001",
				"userHeader_002",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"#include <standardHeader_001>\r\n" +
				"#include \"userHeader_001\"\r\n" +
				"#include \"userHeader_002\"\r\n",
				output);
		}

		[TestMethod]
		public void TransformText_009()
		{
			var config = new CodeConfiguration();
			config.StandardHeaderFiles = new List<string>
			{
				"standardHeader_001",
				"standardHeader_002",
			};
			config.UserHeaderFiles = new List<string>()
			{
				"userHeader_001",
				"userHeader_002",
			};
			var template = new CodeGenerator.Stub.Template.IncludeHeaderTemplate(config);

			string output = template.TransformText();
			Assert.AreEqual(
				"\r\n" +
				"#include <standardHeader_001>\r\n" +
				"#include <standardHeader_002>\r\n" +
				"#include \"userHeader_001\"\r\n" +
				"#include \"userHeader_002\"\r\n",
				output);
		}
	}
}
