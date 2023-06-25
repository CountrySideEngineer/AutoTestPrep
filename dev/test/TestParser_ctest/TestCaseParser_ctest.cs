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

		}
	}
}
