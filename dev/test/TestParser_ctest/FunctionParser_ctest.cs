using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestParser.Parser;
using TestParser.Target;
using ParameterInfo = TestParser.Target.ParameterInfo;

namespace TestParser_ctest
{
	/// <summary>
	/// FunctionParser_ctest の概要の説明
	/// </summary>
	[TestClass]
	public class FunctionParser_ctest
	{
		[TestMethod]
		public void TEST_001()
		{
			string filePath = @".\..\..\data\FunctionParser_TestData_001.xlsx";
			var parser = new FunctionParser("sample_function_001");
			Function function = (Function)parser.Parse(filePath);

			Assert.AreEqual("sample_function_001", function.Name);
			Assert.AreEqual("int", function.DataType);
			Assert.AreEqual(0, function.PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Mode);
			Assert.AreEqual(string.Empty, function.Description);
		}

		[TestMethod]
		public void TEST_002()
		{
			string filePath = @".\..\..\data\FunctionParser_TestData_001.xlsx";
			var parser = new FunctionParser("sample_function_002");
			Function function = (Function)parser.Parse(filePath);

			Assert.AreEqual("sample_function_002", function.Name);
			Assert.AreEqual("int", function.DataType);
			Assert.AreEqual(0, function.PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Mode);
			Assert.AreEqual("子関数：なし/引数：非ポインタ", function.Description);
			Assert.AreEqual(1, function.Arguments.Count());
			Assert.AreEqual("input1", function.Arguments.ElementAt(0).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(0, function.Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(0).Mode);
		}

		[TestMethod]
		public void TEST_003()
		{
			string filePath = @".\..\..\data\FunctionParser_TestData_001.xlsx";
			var parser = new FunctionParser("sample_function_003");
			Function function = (Function)parser.Parse(filePath);

			Assert.AreEqual("sample_function_003", function.Name);
			Assert.AreEqual("int", function.DataType);
			Assert.AreEqual(0, function.PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Mode);
			Assert.AreEqual("子関数：なし/引数：非ポインタ", function.Description);
			Assert.AreEqual(2, function.Arguments.Count());
			Assert.AreEqual("input1", function.Arguments.ElementAt(0).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(0, function.Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(0).Mode);
			Assert.AreEqual("input2", function.Arguments.ElementAt(1).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(1).DataType);
			Assert.AreEqual(0, function.Arguments.ElementAt(1).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(1).Mode);
		}

		[TestMethod]
		public void TEST_004()
		{
			string filePath = @".\..\..\data\FunctionParser_TestData_001.xlsx";
			var parser = new FunctionParser("sample_function_004");
			Function function = (Function)parser.Parse(filePath);

			Assert.AreEqual("sample_function_004", function.Name);
			Assert.AreEqual("int", function.DataType);
			Assert.AreEqual(0, function.PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Mode);
			Assert.AreEqual("テスト対象関数その2", function.Description);
			Assert.AreEqual(2, function.Arguments.Count());
			Assert.AreEqual("input1", function.Arguments.ElementAt(0).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(1, function.Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(0).Mode);
			Assert.AreEqual("input2", function.Arguments.ElementAt(1).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(1).DataType);
			Assert.AreEqual(1, function.Arguments.ElementAt(1).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(1).Mode);
		}

		[TestMethod]
		public void TEST_005()
		{
			string filePath = @".\..\..\data\FunctionParser_TestData_001.xlsx";
			var parser = new FunctionParser("sample_function_005");
			Function function = (Function)parser.Parse(filePath);

			Assert.AreEqual("sample_function_005", function.Name);
			Assert.AreEqual("int", function.DataType);
			Assert.AreEqual(0, function.PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Mode);
			Assert.AreEqual("子関数：なし/引数：非ポインタ", function.Description);
			Assert.AreEqual(1, function.Arguments.Count());
			Assert.AreEqual("input1", function.Arguments.ElementAt(0).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(0, function.Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(0).Mode);
			Assert.AreEqual(1, function.SubFunctions.Count());
			Assert.AreEqual("subfunction_001", function.SubFunctions.ElementAt(0).Name);
			Assert.AreEqual("int", function.SubFunctions.ElementAt(0).DataType);
			Assert.AreEqual(Parameter.AccessMode.In, function.SubFunctions.ElementAt(0).Mode);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.Count());
			Assert.AreEqual("long", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).DataType);
			Assert.AreEqual(1, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual("subArg1", function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Name);
			Assert.AreEqual(Parameter.AccessMode.In, function.SubFunctions.ElementAt(0).Arguments.ElementAt(0).Mode);
		}

		[TestMethod]
		public void TEST_006()
		{
			string filePath = @".\..\..\data\FunctionParser_TestData_001.xlsx";
			var parser = new FunctionParser("sample_function_006");
			Function function = (Function)parser.Parse(filePath);

			Assert.AreEqual("sample_function_006", function.Name);
			Assert.AreEqual("void", function.DataType);
			Assert.AreEqual(0, function.PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Mode);
			Assert.AreEqual(string.Empty, function.Description);
			Assert.AreEqual(1, function.Arguments.Count());
			Assert.AreEqual("input1", function.Arguments.ElementAt(0).Name);
			Assert.AreEqual("int", function.Arguments.ElementAt(0).DataType);
			Assert.AreEqual(0, function.Arguments.ElementAt(0).PointerNum);
			Assert.AreEqual(Parameter.AccessMode.In, function.Arguments.ElementAt(0).Mode);
			Assert.AreEqual(0, function.SubFunctions.Count());

			Assert.AreEqual(1, function.InternalVariables.Count());
			Assert.AreEqual("int", function.InternalVariables.ElementAt(0).DataType);
			Assert.AreEqual(0, function.InternalVariables.ElementAt(0).PointerNum);
			Assert.AreEqual("global_variable_001", function.InternalVariables.ElementAt(0).Name);
			Assert.AreEqual(0, function.ExternalVariables.Count());
		}
	}
}
