using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;
using BuffTemplate = CodeGenerator.Stub.Template.Stub.Source.Part;

namespace Source.Part.BufferDeclareTemplate.test
{
	[TestClass]
	public class BufferDeclareTemplate_test
	{
		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_001()
		{
			var function = new Function()
			{
				DataType = "FuncType",
				Name = "TargetFunction",
				Arguments = new List<Parameter>()
				{
					new Parameter()
					{
						DataType = "ArgType1",
						Name = "Arg1"
					},
				},
			};
			var template = new BuffTemplate.BufferDeclareTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long TargetFunction_called_count;\r\n" +
				"ArgType1 TargetFunction_Arg1[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_002()
		{
			var function = new Function()
			{
				DataType = "FuncType",
				Name = "TargetFunction",

				Arguments = new List<Parameter>()
				{
					new Parameter()
					{
						DataType = "ArgType1",
						Name = "Arg1"
					},
					new Parameter()
					{
						DataType = "ArgType2",
						Name = "Arg2"
					},
				},
			};
			var template = new BuffTemplate.BufferDeclareTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long TargetFunction_called_count;\r\n" +
				"ArgType1 TargetFunction_Arg1[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2 TargetFunction_Arg2[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_003()
		{
			var function = new Function()
			{
				DataType = "void",
				Name = "TargetFunction",
				Arguments = new List<Parameter>()
				{
					new Parameter()
					{
						DataType = "ArgType1",
						Name = "Arg1"
					},
					new Parameter()
					{
						DataType = "ArgType2",
						Name = "Arg2",
						PointerNum = 1,
						Mode = Parameter.AccessMode.In,
					},
				},
			};
			var template = new BuffTemplate.BufferDeclareTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long TargetFunction_called_count;\r\n" +
				"ArgType1 TargetFunction_Arg1[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2* TargetFunction_Arg2[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2 TargetFunction_Arg2_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long TargetFunction_Arg2_value_size[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_004()
		{
			var function = new Function()
			{
				DataType = "FuncType",
				Name = "TargetFunction",
				Arguments = new List<Parameter>()
				{
					new Parameter()
					{
						DataType = "ArgType1",
						Name = "Arg1"
					},
					new Parameter()
					{
						DataType = "ArgType2",
						Name = "Arg2",
						PointerNum = 1,
						Mode = Parameter.AccessMode.Out,
					},
				},
			};
			var template = new BuffTemplate.BufferDeclareTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"long TargetFunction_called_count;\r\n" +
				"ArgType1 TargetFunction_Arg1[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2* TargetFunction_Arg2[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2 TargetFunction_Arg2_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long TargetFunction_Arg2_value_size[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2 TargetFunction_Arg2_return_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long TargetFunction_Arg2_return_value_size[STUB_BUFFER_SIZE_1];\r\n",
				output);
		}
	}
}
