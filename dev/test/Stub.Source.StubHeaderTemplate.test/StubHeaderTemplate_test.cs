using CodeGenerator.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;
using HeaderTemplate = CodeGenerator.Stub.Template.Stub.Source;

namespace Stub.Source.StubHeaderTemplate.test
{
	[TestClass]
	public class StubHeaderTemplate_test
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
						}
					}
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n"
				, output);
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
					}
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1		Function1_Arg1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n"
				, output);
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
								PointerNum = 1,
								Mode = Parameter.AccessMode.In,
							},
						}
					}
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1*		Function1_Arg1[];\r\n" +
				"extern	ArgType1		Function1_Arg1_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function1_Arg1_value_size[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n"
				, output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_004()
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
								PointerNum = 2,
								Mode = Parameter.AccessMode.In,
							},
						}
					}
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1**		Function1_Arg1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n"
				, output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_005()
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
								PointerNum = 2,
								Mode = Parameter.AccessMode.Out,
							},
						}
					}
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1**		Function1_Arg1[];\r\n" +
				"extern	ArgType1		Function1_Arg1_return_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function1_Arg1_return_value_size[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n"
				, output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_006()
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
								DataType = "ArgType2_1",
								Name = "Arg2_1",
							},
						}
					},
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1		Function1_Arg1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function2_called_count;\r\n" +
				"extern	FuncType2		Function2_return_value[];\r\n" +
				"extern	ArgType2_1		Function2_Arg2_1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"void Function2_init();\r\n" +
				"\r\n"
				, output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_007()
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
								DataType = "ArgType2_1",
								Name = "Arg2_1",
								PointerNum = 1,
								Mode = Parameter.AccessMode.In
							},
						}
					},
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1		Function1_Arg1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function2_called_count;\r\n" +
				"extern	FuncType2		Function2_return_value[];\r\n" +
				"extern	ArgType2_1*		Function2_Arg2_1[];\r\n" +
				"extern	ArgType2_1		Function2_Arg2_1_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function2_Arg2_1_value_size[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"void Function2_init();\r\n" +
				"\r\n"
				, output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_008()
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
								DataType = "ArgType2_1",
								Name = "Arg2_1",
								PointerNum = 1,
								Mode = Parameter.AccessMode.Out,
							},
						}
					},
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1		Function1_Arg1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function2_called_count;\r\n" +
				"extern	FuncType2		Function2_return_value[];\r\n" +
				"extern	ArgType2_1*		Function2_Arg2_1[];\r\n" +
				"extern	ArgType2_1		Function2_Arg2_1_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function2_Arg2_1_value_size[];\r\n" +
				"extern	ArgType2_1		Function2_Arg2_1_return_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function2_Arg2_1_return_value_size[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"void Function2_init();\r\n" +
				"\r\n"
				, output);
		}

		[TestMethod]
		[TestCategory("Test")]
		public void TransformText_test_009()
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
								DataType = "ArgType2_1",
								Name = "Arg2_1",
								PointerNum = 1,
								Mode = Parameter.AccessMode.Both,
							},
						}
					},
				},
			};
			CodeConfiguration config = new CodeConfiguration()
			{
				BufferSize1 = 10,
				BufferSize2 = 100,
			};
			var template = new HeaderTemplate.StubHeaderTemplate(parentFunction, config);
			string output = template.TransformText();
			Assert.AreEqual(
				"#pragma once\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_1\r\n" +
				"#define	STUB_BUFFER_SIZE_1			(10)\r\n" +
				"#endif\r\n" +
				"#ifndef	STUB_BUFFER_SIZE_2\r\n" +
				"#define	STUB_BUFFER_SIZE_2			(100)\r\n" +
				"#endif\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function1_called_count;\r\n" +
				"extern	FuncType1		Function1_return_value[];\r\n" +
				"extern	ArgType1		Function1_Arg1[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function1 stub method.\r\n" +
				" */\r\n" +
				"void Function1_init();\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	Buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"extern	long			Function2_called_count;\r\n" +
				"extern	FuncType2		Function2_return_value[];\r\n" +
				"extern	ArgType2_1*		Function2_Arg2_1[];\r\n" +
				"extern	ArgType2_1		Function2_Arg2_1_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function2_Arg2_1_value_size[];\r\n" +
				"extern	ArgType2_1		Function2_Arg2_1_return_value[][STUB_BUFFER_SIZE_2];\r\n" +
				"extern	long			Function2_Arg2_1_return_value_size[];\r\n" +
				"\r\n" +
				"/*\r\n" +
				" *	A function to initialize the buffers for the Function2 stub method.\r\n" +
				" */\r\n" +
				"void Function2_init();\r\n" +
				"\r\n"
				, output);
		}
	}
}
