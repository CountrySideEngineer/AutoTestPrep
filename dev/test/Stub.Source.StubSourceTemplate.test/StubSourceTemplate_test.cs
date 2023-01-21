using CodeGenerator.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;
using SourceTemplate = CodeGenerator.Stub.Template.Stub.Source;

namespace Stub.Source.StubSourceTemplate.test
{
	[TestClass]
	public class StubSourceTemplate_test
	{
		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_001()
		{
			var parentFunction = new Function()
			{
				DataType = "ParentFuncType1",
				Name = "ParentFunction1",
				SubFunctions = new List<Function>()
				{
					new Function()
					{
						DataType = "FuncType1",
						Name = "Function1",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								DataType = "ArgType1",
								Name = "Arg1",
							},
						}
					}
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				StandardHeaderFiles = new List<string>()
				{
					"stdio.h",
				},
				UserHeaderFiles = new List<string>()
				{
					"sampleHeader.h",
				}
			};
			var template = new SourceTemplate.StubSourceTemplate(parentFunction, config)
			{
				StubHeaderFileName = "StubHeader.h",
			};
			string output = template.TransformText();

			Assert.AreEqual(
				"#include <stdio.h>\r\n" +
				"#include \"sampleHeader.h\"\r\n" +
				"#include \"StubHeader.h\"\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"long			Function1_called_count;\r\n" +
				"FuncType1		Function1_return_value[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType1		Function1_Arg1[STUB_BUFFER_SIZE_1];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" + 
				" */\r\n" +
				"void Function1_init()\r\n" +
				"{\r\n" +
				"	//Initialize the number of function calls.\r\n" +
				"	Function1_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the Function1 stub method will return.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function1_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Initialize the buffer for argument Arg1.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function1_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Stub method of Function1\r\n" +
				" */\r\n" +
				"FuncType1 Function1(ArgType1 Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType1 latchReturn = Function1_return_value[Function1_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	Function1_Arg1[Function1_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	Function1_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n" +
				"\r\n",
			output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_002()
		{
			var parentFunction = new Function()
			{
				DataType = "ParentFuncType1",
				Name = "ParentFunction1",
				SubFunctions = new List<Function>()
				{
					new Function()
					{
						DataType = "FuncType1",
						Name = "Function1",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								DataType = "ArgType1",
								Name = "Arg1",
							},
						}
					},
					new Function()
					{
						DataType = "FuncType2",
						Name = "Function2",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								DataType = "ArgType2",
								Name = "Arg2",
								PointerNum = 1,
								Mode = Parameter.AccessMode.In
							},
						}
					},
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				StandardHeaderFiles = new List<string>()
				{
					"stdio.h",
				},
				UserHeaderFiles = new List<string>()
				{
					"sampleHeader.h",
				}
			};
			var template = new SourceTemplate.StubSourceTemplate(parentFunction, config)
			{
				StubHeaderFileName = "StubHeader.h",
			};
			string output = template.TransformText();

			Assert.AreEqual(
				"#include <stdio.h>\r\n" +
				"#include \"sampleHeader.h\"\r\n" +
				"#include \"StubHeader.h\"\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"long			Function1_called_count;\r\n" +
				"FuncType1		Function1_return_value[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType1		Function1_Arg1[STUB_BUFFER_SIZE_1];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init()\r\n" +
				"{\r\n" +
				"	//Initialize the number of function calls.\r\n" +
				"	Function1_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the Function1 stub method will return.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function1_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Initialize the buffer for argument Arg1.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function1_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Stub method of Function1\r\n" +
				" */\r\n" +
				"FuncType1 Function1(ArgType1 Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType1 latchReturn = Function1_return_value[Function1_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	Function1_Arg1[Function1_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	Function1_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"long			Function2_called_count;\r\n" +
				"FuncType2		Function2_return_value[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2*		Function2_Arg2[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2		Function2_Arg2_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long			Function2_Arg2_value_size[STUB_BUFFER_SIZE_1];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"void Function2_init()\r\n" +
				"{\r\n" +
				"	//Initialize the number of function calls.\r\n" +
				"	Function2_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the Function2 stub method will return.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function2_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Initialize the buffers for argument Arg2.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function2_Arg2[index] = 0;\r\n" +
				"		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n" +
				"			Function2_Arg2_value[index][index2] = 0;\r\n" +
				"		}\r\n" +
				"		Function2_Arg2_value_size[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Stub method of Function2\r\n" +
				" */\r\n" +
				"FuncType2 Function2(ArgType2* Arg2)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType2 latchReturn = Function2_return_value[Function2_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	Function2_Arg2[Function2_called_count] = Arg2;\r\n" +
				"\r\n" +
				"	//Set values in an area specified by pointer argument to buffer.\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < Function2_Arg2_value_size[Function2_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		Function2_Arg2_value[Function2_called_count][index] = *(Arg2 + index);\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	Function2_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n" +
				"\r\n",
			output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_003()
		{
			var parentFunction = new Function()
			{
				DataType = "ParentFuncType1",
				Name = "ParentFunction1",
				SubFunctions = new List<Function>()
				{
					new Function()
					{
						DataType = "FuncType1",
						Name = "Function1",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								DataType = "ArgType1",
								Name = "Arg1",
							},
						}
					},
					new Function()
					{
						DataType = "FuncType2",
						Name = "Function2",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								DataType = "ArgType2",
								Name = "Arg2",
								PointerNum = 1,
								Mode = Parameter.AccessMode.In
							},
						}
					},
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				StandardHeaderFiles = new List<string>()
				{
					"stdio.h",
				},
				UserHeaderFiles = new List<string>()
				{
					"sampleHeader.h",
				}
			};
			if (!(string.IsNullOrEmpty("")) && !(string.IsNullOrWhiteSpace("")))
			{ }
				var template = new SourceTemplate.StubSourceTemplate(parentFunction, config);
			string output = template.TransformText();

			Assert.AreEqual(
				"#include <stdio.h>\r\n" +
				"#include \"sampleHeader.h\"\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"long			Function1_called_count;\r\n" +
				"FuncType1		Function1_return_value[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType1		Function1_Arg1[STUB_BUFFER_SIZE_1];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init()\r\n" +
				"{\r\n" +
				"	//Initialize the number of function calls.\r\n" +
				"	Function1_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the Function1 stub method will return.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function1_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Initialize the buffer for argument Arg1.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function1_Arg1[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Stub method of Function1\r\n" +
				" */\r\n" +
				"FuncType1 Function1(ArgType1 Arg1)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType1 latchReturn = Function1_return_value[Function1_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	Function1_Arg1[Function1_called_count] = Arg1;\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	Function1_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"long			Function2_called_count;\r\n" +
				"FuncType2		Function2_return_value[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2*		Function2_Arg2[STUB_BUFFER_SIZE_1];\r\n" +
				"ArgType2		Function2_Arg2_value[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\n" +
				"long			Function2_Arg2_value_size[STUB_BUFFER_SIZE_1];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"void Function2_init()\r\n" +
				"{\r\n" +
				"	//Initialize the number of function calls.\r\n" +
				"	Function2_called_count = 0;\r\n" +
				"\r\n" +
				"	//Initialize the buffer to hold the values the Function2 stub method will return.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function2_return_value[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Initialize the buffers for argument Arg2.\r\n" +
				"	for (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n" +
				"		Function2_Arg2[index] = 0;\r\n" +
				"		for (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n" +
				"			Function2_Arg2_value[index][index2] = 0;\r\n" +
				"		}\r\n" +
				"		Function2_Arg2_value_size[index] = 0;\r\n" +
				"	}\r\n" +
				"\r\n" +
				"}\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Stub method of Function2\r\n" +
				" */\r\n" +
				"FuncType2 Function2(ArgType2* Arg2)\r\n" +
				"{\r\n" +
				"	//Get and latch the value from buffer.\r\n" +
				"	FuncType2 latchReturn = Function2_return_value[Function2_called_count];\r\n" +
				"\r\n" +
				"	//Set argument value to buffer.\r\n" +
				"	Function2_Arg2[Function2_called_count] = Arg2;\r\n" +
				"\r\n" +
				"	//Set values in an area specified by pointer argument to buffer.\r\n" +
				"	for (int index = 0;\r\n" +
				"		index < Function2_Arg2_value_size[Function2_called_count];\r\n" +
				"		index++)\r\n" +
				"	{\r\n" +
				"		Function2_Arg2_value[Function2_called_count][index] = *(Arg2 + index);\r\n" +
				"	}\r\n" +
				"\r\n" +
				"	//Update function call count variable.\r\n" +
				"	Function2_called_count++;\r\n" +
				"\r\n" +
				"	//Return latched value.\r\n" +
				"	return latchReturn;\r\n" +
				"}\r\n" +
				"\r\n",
			output);
		}
	}
}
