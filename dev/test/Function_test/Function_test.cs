using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TestParser.Target;

namespace Function_test
{
	[TestClass]
	public class Function_test
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		[TestCategory("OK_Case")]
		[Description("Constructor")]
		public void Functoin_ToString_001()
		{
			var function = new Function
			{
				Name = "FuncName",
				DataType = "int"
			};

			string toString = function.ToString();

			Assert.AreEqual("int FuncName()", toString);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[TestCategory("OK_Case")]
		[Description("Constructor")]
		public void Functoin_ToString_002()
		{
			var arguments = new List<Parameter>
			{
				new Parameter
				{
					Name = "Arg1",
					DataType = "int",
					PointerNum = 0
				},
			};
			var function = new Function
			{
				Name = "FuncName",
				DataType = "int",
				Arguments = arguments
			};

			string toString = function.ToString();

			Assert.AreEqual("int FuncName(int Arg1)", toString);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[TestCategory("OK_Case")]
		[Description("Constructor")]
		public void Functoin_ToString_003()
		{
			var arguments = new List<Parameter>
			{
				new Parameter
				{
					Name = "Arg1",
					DataType = "int",
					PointerNum = 0
				},
				new Parameter
				{
					Name = "Arg2",
					DataType = "int",
					PointerNum = 1
				},
			};
			var function = new Function
			{
				Name = "FuncName",
				DataType = "int",
				Arguments = arguments,
				Prefix = new List<string>
				{
					"WINEXPORTS"
				}
			};
			string toString = function.ToString();

			Assert.AreEqual("WINEXPORTS int FuncName(int Arg1, int* Arg2)", toString);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[TestCategory("OK_Case")]
		[Description("Constructor")]
		public void Functoin_ToString_004()
		{
			var arguments = new List<Parameter>
			{
				new Parameter
				{
					Name = "Arg1",
					DataType = "int",
					PointerNum = 0,
					Prefix = new List<string>
					{
						"_in_"
					}
				},
				new Parameter
				{
					Name = "Arg2",
					DataType = "int",
					PointerNum = 1,
					Prefix = new List<string>
					{
						"_out_"
					}
				},
			};
			var function = new Function
			{
				Name = "FuncName",
				DataType = "int",
				Arguments = arguments,
				Postfix = new List<string>
				{
					"WINAPI"
				}
			};
			string toString = function.ToString();

			Assert.AreEqual("int WINAPI FuncName(_in_ int Arg1, _out_ int* Arg2)", toString);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[TestCategory("OK_Case")]
		[Description("CopyTo")]
		public void Parameter_CopyTo_001()
		{
			var src = new Function()
			{
				DataType = "Base_data_type",
				Name = "Base_name",
				PointerNum = 1,
				Prefix = new List<string>()
				{
					"BasePrefix_001",
					"BasePrefix_002"
				},
				Postfix = new List<string>()
				{
					"BasePostfix_001",
					"BasePostfix_002",
				},
				Mode = Parameter.AccessMode.In,
				Overview = "BaseOverview",
				Description = "BaseDescription"
			};

			var dst = new Function();
			src.CopyTo(ref dst);

			Assert.AreEqual("Base_name", dst.Name);
			Assert.AreEqual("Base_data_type", dst.DataType);
			Assert.AreEqual(1, dst.PointerNum);
			Assert.AreEqual(2, dst.Prefix.Count());
			Assert.AreEqual("BasePrefix_001", dst.Prefix.ElementAt(0));
			Assert.AreEqual("BasePrefix_002", dst.Prefix.ElementAt(1));
			Assert.AreEqual(2, dst.Postfix.Count());
			Assert.AreEqual("BasePostfix_001", dst.Postfix.ElementAt(0));
			Assert.AreEqual("BasePostfix_002", dst.Postfix.ElementAt(1));
			Assert.AreEqual(Parameter.AccessMode.In, dst.Mode);
			Assert.AreEqual("BaseOverview", dst.Overview);
			Assert.AreEqual("BaseDescription", dst.Description);
		}

		[TestMethod]
		[TestCategory("UnitTest")]
		[TestCategory("OK_Case")]
		[Description("CopyTo")]
		public void Parameter_CopyTo_002()
		{
			var src = new Function()
			{
				DataType = "Base_data_type",
				Name = "Base_name",
				PointerNum = 1,
				Prefix = new List<string>()
				{
					"BasePrefix_001",
					"BasePrefix_002"
				},
				Postfix = new List<string>()
				{
					"BasePostfix_001",
					"BasePostfix_002",
				},
				Mode = Parameter.AccessMode.In,
				Overview = "BaseOverview",
				Description = "BaseDescription"
			};

			var dst = new Parameter();
			src.CopyTo(ref dst);

			Assert.AreEqual("Base_name", dst.Name);
			Assert.AreEqual("Base_data_type", dst.DataType);
			Assert.AreEqual(1, dst.PointerNum);
			Assert.AreEqual(2, dst.Prefix.Count());
			Assert.AreEqual("BasePrefix_001", dst.Prefix.ElementAt(0));
			Assert.AreEqual("BasePrefix_002", dst.Prefix.ElementAt(1));
			Assert.AreEqual(2, dst.Postfix.Count());
			Assert.AreEqual("BasePostfix_001", dst.Postfix.ElementAt(0));
			Assert.AreEqual("BasePostfix_002", dst.Postfix.ElementAt(1));
			Assert.AreEqual(Parameter.AccessMode.In, dst.Mode);
			Assert.AreEqual("BaseOverview", dst.Overview);
			Assert.AreEqual("BaseDescription", dst.Description);
		}
	}
}
