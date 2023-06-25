using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TestParser.Data;
using TestParser.Parser;

namespace TestParser_ctest
{
	[TestClass]
	public class TestCaseParser_ctest
	{
		[TestMethod]
		[TestCategory("TestCaseParser")]
		public void Test_001()
		{
			string filePath = @".\..\..\data\TestCaseParser_TestData_001.xlsx";
			var parser = new TestCaseParser("sample_function_001");
			IEnumerable<TestCase> testCases = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				testCases = (IEnumerable<TestCase>)parsed;
			}

			Assert.AreEqual(3, testCases.Count());
			Assert.AreEqual(2, testCases.ElementAt(0).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(0).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(0).Input.ElementAt(1).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(0).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(0).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(0).Expects.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(1).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(1).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(1).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(1).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(1).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(1).Input.ElementAt(1).Name);
			Assert.AreEqual("1", testCases.ElementAt(1).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(1).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(1).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(1).Expects.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(1).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(2).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(2).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(2).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(2).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(2).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(2).Input.ElementAt(1).Name);
			Assert.AreEqual("2", testCases.ElementAt(2).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(2).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(2).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(2).Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCases.ElementAt(2).Expects.ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestCaseParser")]
		public void Test_002()
		{
			string filePath = @".\..\..\data\TestCaseParser_TestData_001.xlsx";
			var parser = new TestCaseParser("sample_function_002");
			IEnumerable<TestCase> testCases = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				testCases = (IEnumerable<TestCase>)parsed;
			}

			Assert.AreEqual(16, testCases.Count());
			Assert.AreEqual(2, testCases.ElementAt(0).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(0).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(0).Input.ElementAt(1).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(0).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(0).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(0).Expects.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(1).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(1).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(1).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(1).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(1).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(1).Input.ElementAt(1).Name);
			Assert.AreEqual("1", testCases.ElementAt(1).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(1).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(1).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(1).Expects.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(1).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(2).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(2).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(2).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(2).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(2).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(2).Input.ElementAt(1).Name);
			Assert.AreEqual("2", testCases.ElementAt(2).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(2).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(2).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(2).Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCases.ElementAt(2).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(3).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(3).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(3).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(3).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(3).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(3).Input.ElementAt(1).Name);
			Assert.AreEqual("3", testCases.ElementAt(3).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(3).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(3).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(3).Expects.ElementAt(0).Name);
			Assert.AreEqual("3", testCases.ElementAt(3).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(4).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(4).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(4).Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(4).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(4).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(4).Input.ElementAt(1).Name);
			Assert.AreEqual("0", testCases.ElementAt(4).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(4).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(4).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(4).Expects.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(4).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(5).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(5).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(5).Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(5).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(5).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(5).Input.ElementAt(1).Name);
			Assert.AreEqual("1", testCases.ElementAt(5).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(5).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(5).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(5).Expects.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(5).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(6).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(6).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(6).Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(6).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(6).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(6).Input.ElementAt(1).Name);
			Assert.AreEqual("2", testCases.ElementAt(6).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(6).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(6).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(6).Expects.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(6).Expects.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(7).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(7).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(7).Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(7).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(7).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(7).Input.ElementAt(1).Name);
			Assert.AreEqual("3", testCases.ElementAt(7).Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCases.ElementAt(7).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(7).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(7).Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCases.ElementAt(7).Expects.ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestCaseParser")]
		public void Test_003()
		{
			string filePath = @".\..\..\data\TestCaseParser_TestData_001.xlsx";
			var parser = new TestCaseParser("sample_function_003");
			IEnumerable<TestCase> testCases = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				testCases = (IEnumerable<TestCase>)parsed;
			}

			Assert.AreEqual(1, testCases.Count());
			Assert.AreEqual(2, testCases.ElementAt(0).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(0).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(0).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(1).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(0).Input.ElementAt(1).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(1).Value);
			Assert.AreEqual(0, testCases.ElementAt(0).Expects.Count());
		}

		[TestMethod]
		[TestCategory("TestCaseParser")]
		public void Test_004()
		{
			string filePath = @".\..\..\data\TestCaseParser_TestData_001.xlsx";
			var parser = new TestCaseParser("sample_function_004");
			IEnumerable<TestCase> testCases = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				testCases = (IEnumerable<TestCase>)parsed;
			}

			Assert.AreEqual(1, testCases.Count());
			Assert.AreEqual(4, testCases.ElementAt(0).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(0).Condition);
			Assert.AreEqual("_input1[0]", testCases.ElementAt(0).Input.ElementAt(0).Name);
			Assert.AreEqual("0", testCases.ElementAt(0).Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(1).Condition);
			Assert.AreEqual("input1", testCases.ElementAt(0).Input.ElementAt(1).Name);
			Assert.AreEqual("&_input1[0]", testCases.ElementAt(0).Input.ElementAt(1).Value);
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(2).Condition);
			Assert.AreEqual("_input2[0]", testCases.ElementAt(0).Input.ElementAt(2).Name);
			Assert.AreEqual("3", testCases.ElementAt(0).Input.ElementAt(2).Value);
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(3).Condition);
			Assert.AreEqual("input2", testCases.ElementAt(0).Input.ElementAt(3).Name);
			Assert.AreEqual("&_input2[0]", testCases.ElementAt(0).Input.ElementAt(3).Value);
			Assert.AreEqual(2, testCases.ElementAt(0).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(0).Expects.ElementAt(0).Condition);
			Assert.AreEqual("ret_val", testCases.ElementAt(0).Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCases.ElementAt(0).Expects.ElementAt(0).Value);
			Assert.AreEqual("期待値", testCases.ElementAt(0).Expects.ElementAt(1).Condition);
			Assert.AreEqual("_input2[0]", testCases.ElementAt(0).Expects.ElementAt(1).Name);
			Assert.AreEqual("125", testCases.ElementAt(0).Expects.ElementAt(1).Value);
		}
	}
}
