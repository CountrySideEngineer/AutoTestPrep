using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Config;
using TestParser.Converter.Function;
using TestParser.Target;

namespace FunctionConverter_utest
{
	public partial class FunctionConverter_utest
	{
		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_001()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"テスト対象関数", "本体", 
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function();
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.Prefix.Count());
			Assert.AreEqual("Prefix", dst.Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.DataType);
			Assert.AreEqual(1, dst.Postfix.Count());
			Assert.AreEqual("Postfix", dst.Postfix.ElementAt(0));
			Assert.AreEqual("FunctionName", dst.Name);
			Assert.AreEqual(Parameter.AccessMode.In, dst.Mode);
			Assert.IsTrue(string.IsNullOrEmpty(dst.Description));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_002()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"テスト対象関数", "引数",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function();
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.Arguments.Count());
			Assert.AreEqual(1, dst.Arguments.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", dst.Arguments.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(1, dst.Arguments.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", dst.Arguments.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("FunctionName", dst.Arguments.ElementAt(0).Name);
			Assert.AreEqual(Parameter.AccessMode.In, dst.Arguments.ElementAt(0).Mode);
			Assert.IsTrue(string.IsNullOrEmpty(dst.Arguments.ElementAt(0).Description));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_003()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"テスト対象関数", "引数",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
				Arguments = new List<Parameter>()
				{
					new Parameter()
					{
						Name = "Arg1",
						DataType = "DataType1"
					}
				}
			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual("Function", dst.Name);
			Assert.AreEqual("DataType1", dst.Arguments.ElementAt(0).DataType);
			Assert.AreEqual("Arg1", dst.Arguments.ElementAt(0).Name);
			Assert.AreEqual(2, dst.Arguments.Count());
			Assert.AreEqual(1, dst.Arguments.ElementAt(1).Prefix.Count());
			Assert.AreEqual("Prefix", dst.Arguments.ElementAt(1).Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.Arguments.ElementAt(1).DataType);
			Assert.AreEqual(1, dst.Arguments.ElementAt(1).Postfix.Count());
			Assert.AreEqual("Postfix", dst.Arguments.ElementAt(1).Postfix.ElementAt(0));
			Assert.AreEqual("FunctionName", dst.Arguments.ElementAt(1).Name);
			Assert.AreEqual(Parameter.AccessMode.In, dst.Arguments.ElementAt(1).Mode);
			Assert.IsTrue(string.IsNullOrEmpty(dst.Arguments.ElementAt(1).Description));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_004()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"子関数", "本体",
				"Prefix", "DataType", "Postfix", "FunctionName", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function();
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.SubFunctions.Count());
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", dst.SubFunctions.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.SubFunctions.ElementAt(0).DataType);
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", dst.SubFunctions.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("FunctionName", dst.SubFunctions.ElementAt(0).Name);
			Assert.AreEqual(Parameter.AccessMode.In, dst.SubFunctions.ElementAt(0).Mode);
			Assert.IsTrue(string.IsNullOrEmpty(dst.SubFunctions.ElementAt(0).Description));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_005()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"子関数", "引数",
				"Prefix", "Arg2", "Postfix", "ArgumentName", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
				Arguments = new List<Parameter>()
				{
					new Parameter()
					{
						Name = "Arg1",
						DataType = "DataType1"
					}
				},
				SubFunctions = new List<Function>()
				{
					new Function()
					{
						Name = "SubFunction1",
						DataType = "SubType",
					},
				},

			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.SubFunctions.Count());
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Arguments.Count());
			Assert.AreEqual("ArgumentName", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name);
			Assert.AreEqual("Arg2", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType);
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Postfix.ElementAt(0));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_006()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"子関数", "引数",
				"Prefix", "Arg2", "Postfix", "ArgumentName", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
				SubFunctions = new List<Function>()
				{
					new Function()
					{
						Name = "SubFunction1",
						DataType = "SubType",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								Name = "Argument1",
								DataType = "Arg1",
							}
						}
					},
				},

			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.SubFunctions.Count());
			Assert.AreEqual(2, dst.SubFunctions.ElementAt(0).Arguments.Count());
			Assert.AreEqual("Argument1", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name);
			Assert.AreEqual("Arg1", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType);
			Assert.AreEqual("ArgumentName", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Name);
			Assert.AreEqual("Arg2", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(1).DataType);
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Prefix.Count());
			Assert.AreEqual("Prefix", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Prefix.ElementAt(0));
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Postfix.Count());
			Assert.AreEqual("Postfix", dst.SubFunctions.ElementAt(0).Arguments.ElementAt(1).Postfix.ElementAt(0));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_007()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"子関数", "引数",
				"Prefix", "Arg3", "Postfix", "Argument3", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
				SubFunctions = new List<Function>()
				{
					new Function()
					{
						Name = "SubFunction1",
						DataType = "SubType",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								Name = "Argument1",
								DataType = "Arg1",
							}
						}
					},
					new Function()
					{
						Name = "SubFunction2",
						DataType = "SubType",
						Arguments = new List<Parameter>()
						{
							new Parameter()
							{
								Name = "Argument2",
								DataType = "Arg2",
							}
						}
					},
				},

			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(2, dst.SubFunctions.Count());
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(0).Arguments.Count());
			Assert.AreEqual(2, dst.SubFunctions.ElementAt(1).Arguments.Count());
			Assert.AreEqual("Argument2", dst.SubFunctions.ElementAt(1).Arguments.ElementAt(0).Name);
			Assert.AreEqual("Arg2", dst.SubFunctions.ElementAt(1).Arguments.ElementAt(0).DataType);
			Assert.AreEqual("Argument3", dst.SubFunctions.ElementAt(1).Arguments.ElementAt(1).Name);
			Assert.AreEqual("Arg3", dst.SubFunctions.ElementAt(1).Arguments.ElementAt(1).DataType);
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(1).Arguments.ElementAt(1).Prefix.Count());
			Assert.AreEqual("Prefix", dst.SubFunctions.ElementAt(1).Arguments.ElementAt(1).Prefix.ElementAt(0));
			Assert.AreEqual(1, dst.SubFunctions.ElementAt(1).Arguments.ElementAt(1).Postfix.Count());
			Assert.AreEqual("Postfix", dst.SubFunctions.ElementAt(1).Arguments.ElementAt(1).Postfix.ElementAt(0));
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_008()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"グローバル変数", "外部",
				"Prefix", "DataType", "Postfix", "ExternalVariable", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.ExternalVariables.Count());
			Assert.AreEqual(1, dst.ExternalVariables.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", dst.ExternalVariables.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.ExternalVariables.ElementAt(0).DataType);
			Assert.AreEqual(1, dst.ExternalVariables.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", dst.ExternalVariables.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("ExternalVariable", dst.ExternalVariables.ElementAt(0).Name);
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_009()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"グローバル変数", "外部",
				"Prefix", "DataType", "Postfix", "ExternalVariable", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
				ExternalVariables = new List<Parameter>()
				{
					new Parameter()
					{
						Name = "Variable",
						DataType = "Type"
					}
				}
			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(2, dst.ExternalVariables.Count());
			Assert.AreEqual(0, dst.ExternalVariables.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Type", dst.ExternalVariables.ElementAt(0).DataType);
			Assert.AreEqual(0, dst.ExternalVariables.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Variable", dst.ExternalVariables.ElementAt(0).Name);
			Assert.AreEqual(1, dst.ExternalVariables.ElementAt(1).Prefix.Count());
			Assert.AreEqual("Prefix", dst.ExternalVariables.ElementAt(1).Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.ExternalVariables.ElementAt(1).DataType);
			Assert.AreEqual(1, dst.ExternalVariables.ElementAt(1).Postfix.Count());
			Assert.AreEqual("Postfix", dst.ExternalVariables.ElementAt(1).Postfix.ElementAt(0));
			Assert.AreEqual("ExternalVariable", dst.ExternalVariables.ElementAt(1).Name);
		}

		[TestMethod]
		[TestCategory("SetTo")]
		public void SetTo_utest_010()
		{
			FunctionTableConfig config = new FunctionTableConfig()
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
			var src = new List<string>()
			{
				"グローバル変数", "内部",
				"Prefix", "DataType", "Postfix", "InternalVariable", "", ""
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			var dst = new Function()
			{
				Name = "Function",
			};
			converterPrivate.Invoke("SetTo", src, dst);

			Assert.AreEqual(1, dst.InternalVariables.Count());
			Assert.AreEqual(1, dst.InternalVariables.ElementAt(0).Prefix.Count());
			Assert.AreEqual("Prefix", dst.InternalVariables.ElementAt(0).Prefix.ElementAt(0));
			Assert.AreEqual("DataType", dst.InternalVariables.ElementAt(0).DataType);
			Assert.AreEqual(1, dst.InternalVariables.ElementAt(0).Postfix.Count());
			Assert.AreEqual("Postfix", dst.InternalVariables.ElementAt(0).Postfix.ElementAt(0));
			Assert.AreEqual("InternalVariable", dst.InternalVariables.ElementAt(0).Name);
		}
	}
}
