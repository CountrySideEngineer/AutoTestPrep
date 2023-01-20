using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;
using StubTemplate = CodeGenerator.Stub.Template.Stub.Source.Part;

namespace Source.Part.StubMethodTemplate.test
{
	[TestClass]
	public class StubMethodTemplate_test
	{
		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_001()
		{
			var function = new Function()
			{
				DataType = "void",
				Name = "TargetFunction",
				Arguments = new List<Parameter>(),
			};
			var template = new StubTemplate.StubMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"/*\r\n" +
				" *	Stub method of TargetFunction\r\n" +
				" */\r\n" +
				"void TargetFunction()\r\n" +
				"{\r\n" +
				"	//Update function call count variable.\r\n" +
				"	TargetFunction_called_count++;\r\n" +
				"\r\n" +
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
						Name = "Arg1",
					}
				}
			};
			var template = new StubTemplate.StubMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"/*\r\n" +
				" *	Stub method of TargetFunction\r\n" +
				" */\r\n" +
				"void TargetFunction(ArgType1 Arg1)\r\n" +
				"{\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	TargetFunction_Arg1[TargetFunction_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	TargetFunction_called_count++;\r\n" +
				"\r\n" +
				"}\r\n",
				output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_003()
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
						Name = "Arg1",
					}
				}
			};
			var template = new StubTemplate.StubMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"/*\r\n" +
				" *	Stub method of TargetFunction\r\n" +
				" */\r\n" +
				"FuncType TargetFunction(ArgType1 Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType latchReturn = TargetFunction_return_value[TargetFunction_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	TargetFunction_Arg1[TargetFunction_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	TargetFunction_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n",
				output); ;
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
						Name = "Arg1",
						PointerNum = 1,
						Mode = Parameter.AccessMode.In,
					}
				}
			};
			var template = new StubTemplate.StubMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"/*\r\n" +
				" *	Stub method of TargetFunction\r\n" +
				" */\r\n" +
				"FuncType TargetFunction(ArgType1* Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType latchReturn = TargetFunction_return_value[TargetFunction_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	TargetFunction_Arg1[TargetFunction_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Set values in an area specified by pointer argument to buffer.\r\n" + 
				"	for (int index = 0;\r\n" +
				"		index < TargetFunction_Arg1_value_size[TargetFunction_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		TargetFunction_Arg1_value[TargetFunction_called_count][index] = *(Arg1 + index);\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	TargetFunction_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n",
				output); ;
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_005()
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
						Name = "Arg1",
						PointerNum = 1,
						Mode = Parameter.AccessMode.Out,
					}
				}
			};
			var template = new StubTemplate.StubMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"/*\r\n" +
				" *	Stub method of TargetFunction\r\n" +
				" */\r\n" +
				"FuncType TargetFunction(ArgType1* Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType latchReturn = TargetFunction_return_value[TargetFunction_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	TargetFunction_Arg1[TargetFunction_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Set values in an area specified by pointer argument to buffer.\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < TargetFunction_Arg1_value_size[TargetFunction_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		TargetFunction_Arg1_value[TargetFunction_called_count][index] = *(Arg1 + index);\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Set values in buffer to area specified by pointer argument.\r\n" + 
				"	for (int index = 0;\r\n" +
				"		index < TargetFunction_Arg1_return_value_size[TargetFunction_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		*(Arg1 + index) = TargetFunction_Arg1_return_value[TargetFunction_called_count][index];\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	TargetFunction_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n",
				output); ;
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_006()
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
						Name = "Arg1",
						PointerNum = 2,
						Mode = Parameter.AccessMode.Out,
					}
				}
			};
			var template = new StubTemplate.StubMethodTemplate()
			{
				Target = function,
			};
			string output = template.TransformText();
			Assert.AreEqual(
				"/*\r\n" +
				" *	Stub method of TargetFunction\r\n" +
				" */\r\n" +
				"FuncType TargetFunction(ArgType1** Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType latchReturn = TargetFunction_return_value[TargetFunction_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	TargetFunction_Arg1[TargetFunction_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Set addresses to area specified by double pointer arguments.\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < TargetFunction_Arg1_return_value_size[TargetFunction_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		*(Arg1 + index) = &TargetFunction_Arg1_return_value[TargetFunction_called_count][index];\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	TargetFunction_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n",
				output); ;
		}
	}
}
