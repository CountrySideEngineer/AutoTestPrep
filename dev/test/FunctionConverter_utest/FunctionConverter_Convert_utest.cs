using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TestParser.Config;
using TestParser.Converter.Function;
using TestParser.Target;

namespace FunctionConverter_utest
{
	public partial class FunctionConverter_utest
	{
		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_001()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", "Prefix", "DataType", "Postfix", "Name", "in", "description"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(1, parameter.Prefix.Count());
			Assert.AreEqual("Prefix", parameter.Prefix.ElementAt(0));
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(1, parameter.Postfix.Count());
			Assert.AreEqual("Postfix", parameter.Postfix.ElementAt(0));
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.In, parameter.Mode);
			Assert.AreEqual("description", parameter.Description);
			Assert.AreEqual(0, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_002()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", "Prefix ", "DataType", " Postfix", "Name", "out", "description"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(1, parameter.Prefix.Count());
			Assert.AreEqual("Prefix", parameter.Prefix.ElementAt(0));
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(1, parameter.Postfix.Count());
			Assert.AreEqual("Postfix", parameter.Postfix.ElementAt(0));
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.Out, parameter.Mode);
			Assert.AreEqual("description", parameter.Description);
			Assert.AreEqual(0, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_003()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", " Prefix ", "DataType", "  Postfix", "Name", "in/out", "description"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(1, parameter.Prefix.Count());
			Assert.AreEqual("Prefix", parameter.Prefix.ElementAt(0));
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(1, parameter.Postfix.Count());
			Assert.AreEqual("Postfix", parameter.Postfix.ElementAt(0));
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.Both, parameter.Mode);
			Assert.AreEqual("description", parameter.Description);
			Assert.AreEqual(0, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_004()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", "WINDLL CALL_SAFE", "DataType", "* WINAPI", "Name", "In", "description"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(2, parameter.Prefix.Count());
			Assert.AreEqual("WINDLL", parameter.Prefix.ElementAt(0));
			Assert.AreEqual("CALL_SAFE", parameter.Prefix.ElementAt(1));
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(2, parameter.Postfix.Count());
			Assert.AreEqual("*", parameter.Postfix.ElementAt(0));
			Assert.AreEqual("WINAPI", parameter.Postfix.ElementAt(1));
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.In, parameter.Mode);
			Assert.AreEqual("description", parameter.Description);
			Assert.AreEqual(1, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_005()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", "WINDLL CALL_SAFE", "DataType", "* * WINAPI", "Name", "Out", "description"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(2, parameter.Prefix.Count());
			Assert.AreEqual("WINDLL", parameter.Prefix.ElementAt(0));
			Assert.AreEqual("CALL_SAFE", parameter.Prefix.ElementAt(1));
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(3, parameter.Postfix.Count());
			Assert.AreEqual("*", parameter.Postfix.ElementAt(0));
			Assert.AreEqual("*", parameter.Postfix.ElementAt(1));
			Assert.AreEqual("WINAPI", parameter.Postfix.ElementAt(2));
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.Out, parameter.Mode);
			Assert.AreEqual("description", parameter.Description);
			Assert.AreEqual(2, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_006()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", "WINDLL CALL_SAFE", "DataType", "** WINAPI", "Name", "In/Out", "description"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(2, parameter.Prefix.Count());
			Assert.AreEqual("WINDLL", parameter.Prefix.ElementAt(0));
			Assert.AreEqual("CALL_SAFE", parameter.Prefix.ElementAt(1));
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(2, parameter.Postfix.Count());
			Assert.AreEqual("**", parameter.Postfix.ElementAt(0));
			Assert.AreEqual("WINAPI", parameter.Postfix.ElementAt(1));
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.Both, parameter.Mode);
			Assert.AreEqual("description", parameter.Description);
			Assert.AreEqual(2, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_007()
		{
			var config = new FunctionTableConfig();
			List<string> src = new List<string>()
			{
				"Category", "Type", "", "DataType", "", "Name", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			Parameter parameter = (Parameter)converterPrivate.Invoke("Convert", src);

			Assert.AreEqual(0, parameter.Prefix.Count());
			Assert.AreEqual("DataType", parameter.DataType);
			Assert.AreEqual(0, parameter.Postfix.Count());
			Assert.AreEqual("Name", parameter.Name);
			Assert.AreEqual(Parameter.AccessMode.In, parameter.Mode);
			Assert.AreEqual("", parameter.Description);
			Assert.AreEqual(0, parameter.PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_008()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(1, function.Prefix.Count());
			Assert.AreEqual("Prefix", function.Prefix.ElementAt(0));
			Assert.AreEqual("Postfix", function.Postfix.ElementAt(0));
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_009()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var argumentRow = new List<string>()
			{
				"テスト対象関数", "引数",
				"WinBase", "ArgType", "WINAPI", "FuncArg", "", ""
			};
			jig.AddRow(argumentRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(1, function.Prefix.Count());
			Assert.AreEqual("Prefix", function.Prefix.ElementAt(0));
			Assert.AreEqual("Postfix", function.Postfix.ElementAt(0));
			Assert.AreEqual(1, function.Arguments.Count());
			Assert.AreEqual(1, function.Arguments.ElementAt(0).Prefix.Count());
			Assert.AreEqual("WinBase", function.Arguments.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("ArgType", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(1, function.Arguments.ElementAt(0).Postfix.Count());
			Assert.AreEqual("WINAPI", function.Arguments.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("FuncArg", function.Arguments.ElementAt(0).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_010()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var argumentRow1 = new List<string>()
			{
				"テスト対象関数", "引数",
				"WinBase", "ArgType", "WINAPI", "FuncArg", "", ""
			};
			jig.AddRow(argumentRow1);
			var argumentRow2 = new List<string>()
			{
				"テスト対象関数", "引数",
				"WinBase", "ArgType", "WINAPI _in_", "FuncArg2", "", ""
			};
			jig.AddRow(argumentRow2);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(1, function.Prefix.Count());
			Assert.AreEqual("Prefix", function.Prefix.ElementAt(0));
			Assert.AreEqual("Postfix", function.Postfix.ElementAt(0));
			Assert.AreEqual(2, function.Arguments.Count());
			Assert.AreEqual(1, function.Arguments.ElementAt(0).Prefix.Count());
			Assert.AreEqual("WinBase", function.Arguments.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("ArgType", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(1, function.Arguments.ElementAt(0).Postfix.Count());
			Assert.AreEqual("WINAPI", function.Arguments.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("FuncArg", function.Arguments.ElementAt(0).Name);
			Assert.AreEqual(1, function.Arguments.ElementAt(1).Prefix.Count());
			Assert.AreEqual("WinBase", function.Arguments.ElementAt(1).Prefix.ElementAt(0));
			Assert.AreEqual("ArgType", function.Arguments.ElementAt(1).DataType);
			Assert.AreEqual(2, function.Arguments.ElementAt(1).Postfix.Count());
			Assert.AreEqual("WINAPI", function.Arguments.ElementAt(1).Postfix.ElementAt(0));
			Assert.AreEqual("_in_", function.Arguments.ElementAt(1).Postfix.ElementAt(1));
			Assert.AreEqual("FuncArg2", function.Arguments.ElementAt(1).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_011()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var subFunctionRow = new List<string>()
			{
				"子関数", "本体",
				"Prefix", "SubType", "Postfix", "SubFunction", "", ""
			};
			jig.AddRow(subFunctionRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(1, function.SubFunctions.Count());
			Assert.AreEqual("SubFunction", function.SubFunctions.ElementAt(0).Name);
			Assert.AreEqual("SubType", function.SubFunctions.ElementAt(0).DataType);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", function.SubFunctions.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", function.SubFunctions.ElementAt(0).Postfix.ElementAt(0));
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_012()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var subFunctionRow = new List<string>()
			{
				"子関数", "本体",
				"Prefix", "SubType", "Postfix", "SubFunction", "", ""
			};
			jig.AddRow(subFunctionRow);
			var subArgumentRow = new List<string>()
			{
				"子関数", "引数",
				"Prefix", "SubArgType", "* _in_", "SubArgument", "", ""
			};
			jig.AddRow(subArgumentRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(1, function.SubFunctions.Count());
			Assert.AreEqual("SubFunction", function.SubFunctions.ElementAt(0).Name);
			Assert.AreEqual("SubType", function.SubFunctions.ElementAt(0).DataType);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", function.SubFunctions.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", function.SubFunctions.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.Count());
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("SubArgType", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType);
			Assert.AreEqual(2, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.Count());
			Assert.AreEqual("*", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("_in_", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.ElementAt(1));
			Assert.AreEqual("SubArgument", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).PointerNum);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_013()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var subFunctionRow = new List<string>()
			{
				"子関数", "本体",
				"Prefix", "SubType", "Postfix", "SubFunction", "", ""
			};
			jig.AddRow(subFunctionRow);
			var subArgumentRow = new List<string>()
			{
				"子関数", "引数",
				"Prefix", "SubArgType", "* _in_", "SubArgument1", "", ""
			};
			jig.AddRow(subArgumentRow);
			var subArgumentRow2 = new List<string>()
			{
				"子関数", "引数",
				"", "SubArgType", "", "SubArgument2", "", ""
			};
			jig.AddRow(subArgumentRow2);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(1, function.SubFunctions.Count());
			Assert.AreEqual("SubFunction", function.SubFunctions.ElementAt(0).Name);
			Assert.AreEqual("SubType", function.SubFunctions.ElementAt(0).DataType);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", function.SubFunctions.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", function.SubFunctions.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual(2, function.SubFunctions.ElementAt(0).Arguments.Count());
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("SubArgType", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType);
			Assert.AreEqual(2, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.Count());
			Assert.AreEqual("*", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("_in_", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.ElementAt(1));
			Assert.AreEqual("SubArgument1", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual(0, function.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Prefix.Count());
			Assert.AreEqual("SubArgType", function.SubFunctions.ElementAt(0).Arguments.ElementAt(1).DataType);
			Assert.AreEqual(0, function.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Postfix.Count());
			Assert.AreEqual("SubArgument2", function.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_014()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var internalVariable = new List<string>()
			{
				"グローバル変数", "内部",
				"", "in_type", "", "internal_variable", "", ""
			};
			jig.AddRow(internalVariable);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(0, function.SubFunctions.Count());
			Assert.AreEqual(1, function.InternalVariables.Count());
			Assert.AreEqual("in_type", function.InternalVariables.ElementAt(0).DataType);
			Assert.AreEqual("internal_variable", function.InternalVariables.ElementAt(0).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_015()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var internalVariable1 = new List<string>()
			{
				"グローバル変数", "内部",
				"", "in_type", "", "internal_variable1", "", ""
			};
			jig.AddRow(internalVariable1);
			var internalVariable2 = new List<string>()
			{
				"グローバル変数", "内部",
				"", "in_type", "", "internal_variable2", "", ""
			};
			jig.AddRow(internalVariable2);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(0, function.SubFunctions.Count());
			Assert.AreEqual(2, function.InternalVariables.Count());
			Assert.AreEqual("in_type", function.InternalVariables.ElementAt(0).DataType);
			Assert.AreEqual("internal_variable1", function.InternalVariables.ElementAt(0).Name);
			Assert.AreEqual("in_type", function.InternalVariables.ElementAt(1).DataType);
			Assert.AreEqual("internal_variable2", function.InternalVariables.ElementAt(1).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_016()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var externalVariable1 = new List<string>()
			{
				"グローバル変数", "外部",
				"", "ex_type", "", "external_variable1", "", ""
			};
			jig.AddRow(externalVariable1);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(0, function.SubFunctions.Count());
			Assert.AreEqual(0, function.InternalVariables.Count());
			Assert.AreEqual(1, function.ExternalVariables.Count());
			Assert.AreEqual("ex_type", function.ExternalVariables.ElementAt(0).DataType);
			Assert.AreEqual("external_variable1", function.ExternalVariables.ElementAt(0).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		public void Convert_utest_017()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var externalVariable1 = new List<string>()
			{
				"グローバル変数", "外部",
				"", "ex_type", "", "external_variable1", "", ""
			};
			jig.AddRow(externalVariable1);
			var externalVariable2 = new List<string>()
			{
				"グローバル変数", "外部",
				"", "ex_type", "", "external_variable2", "", ""
			};
			jig.AddRow(externalVariable2);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.AreEqual("FunctionName", function.Name);
			Assert.AreEqual("DataType", function.DataType);
			Assert.AreEqual(0, function.SubFunctions.Count());
			Assert.AreEqual(0, function.InternalVariables.Count());
			Assert.AreEqual(2, function.ExternalVariables.Count());
			Assert.AreEqual("ex_type", function.ExternalVariables.ElementAt(0).DataType);
			Assert.AreEqual("external_variable1", function.ExternalVariables.ElementAt(0).Name);
			Assert.AreEqual("ex_type", function.ExternalVariables.ElementAt(1).DataType);
			Assert.AreEqual("external_variable2", function.ExternalVariables.ElementAt(1).Name);
		}

		[TestMethod]
		[TestCategory("Convert")]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Convert_utest_018()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.Fail();
		}

		[TestMethod]
		[TestCategory("Convert")]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Convert_utest_019()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var argumentRow = new List<string>()
			{
				"テスト対象関数", "",
				"WinBase", "ArgType", "WINAPI", "FuncArg", "", ""
			};
			jig.AddRow(argumentRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		[TestCategory("Convert")]
		public void Convert_utest_020()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var subFunctionRow = new List<string>()
			{
				"子関数", "",
				"Prefix", "SubType", "Postfix", "SubFunction", "", ""
			};
			jig.AddRow(subFunctionRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		[TestCategory("Convert")]
		public void Convert_utest_021()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var subFunctionRow = new List<string>()
			{
				"子関数", "本体",
				"Prefix", "SubType", "Postfix", "SubFunction", "", ""
			};
			jig.AddRow(subFunctionRow);
			var subArgumentRow = new List<string>()
			{
				"子関数", "",
				"Prefix", "SubArgType", "* _in_", "SubArgument", "", ""
			};
			jig.AddRow(subArgumentRow);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		[TestCategory("Convert")]
		public void Convert_utest_022()
		{
			var jig = new Content_test_jig();
			var functionRow = new List<string>()
			{
				"テスト対象関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			jig.AddRow(functionRow);
			var internalVariable = new List<string>()
			{
				"グローバル変数", "",
				"", "in_type", "", "internal_variable", "", ""
			};
			jig.AddRow(internalVariable);

			var config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var converter = new FunctionConverter(config);
			Function function = (Function)converter.Convert(jig);

			Assert.Fail();
		}
	}
}
