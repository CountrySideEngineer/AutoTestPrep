using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;
using BuffTemplate = CodeGenerator.Stub.Template.Stub.Source.Part;

namespace Source.Part.BufferInitMethodTemplate.test
{
	[TestClass]
	public class BufferInitMethodTemplate_test
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
			var template = new BuffTemplate.BufferInitMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"void TargetFunction_init()\r\n" +
				"{\r\n" +
				"	TargetFunction_called_count = 0;\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"}\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_002()
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
						Name = "Arg2"
					},
				},
			};
			var template = new BuffTemplate.BufferInitMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"void TargetFunction_init()\r\n" +
				"{\r\n" +
				"	TargetFunction_called_count = 0;\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg2[index] = 0;\r\n" +
				"	}\r\n" +
				"}\r\n",
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
			var template = new BuffTemplate.BufferInitMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"void TargetFunction_init()\r\n" +
				"{\r\n" +
				"	TargetFunction_called_count = 0;\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg2[index] = 0;\r\n" +
				"		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n" +
				"			TargetFunction_Arg2_value[index][index2] = 0;\r\n" +
				"		}\r\n" +
				"		TargetFunction_Arg2_value_size[index] = 0;\r\n" +
				"	}\r\n" +
				"}\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_004()
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
						Mode = Parameter.AccessMode.Out,
					},
				},
			};
			var template = new BuffTemplate.BufferInitMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"void TargetFunction_init()\r\n" +
				"{\r\n" +
				"	TargetFunction_called_count = 0;\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg2[index] = 0;\r\n" +
				"		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n" +
				"			TargetFunction_Arg2_value[index][index2] = 0;\r\n" +
				"			TargetFunction_Arg2_return_value[index][index2] = 0;\r\n" +
				"		}\r\n" +
				"		TargetFunction_Arg2_value_size[index] = 0;\r\n" +
				"		TargetFunction_Arg2_return_value_size[index] = 0;\r\n" +
				"	}\r\n" +
				"}\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_005()
		{
			var function = new Function()
			{
				DataType = "void",
				Name = "TargetFunction",
				PointerNum = 1,
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
			var template = new BuffTemplate.BufferInitMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"void TargetFunction_init()\r\n" +
				"{\r\n" +
				"	TargetFunction_called_count = 0;\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_return_value[index] = NULL;\r\n" +
				"	}\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		TargetFunction_Arg2[index] = 0;\r\n" +
				"		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n" +
				"			TargetFunction_Arg2_value[index][index2] = 0;\r\n" +
				"			TargetFunction_Arg2_return_value[index][index2] = 0;\r\n" +
				"		}\r\n" +
				"		TargetFunction_Arg2_value_size[index] = 0;\r\n" +
				"		TargetFunction_Arg2_return_value_size[index] = 0;\r\n" +
				"	}\r\n" +
				"}\r\n",
				output);
		}
	}
}
