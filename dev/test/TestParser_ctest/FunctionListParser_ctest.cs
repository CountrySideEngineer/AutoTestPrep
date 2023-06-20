using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TestParser.Parser;
using TestParser.Target;
using ParameterInfo = TestParser.Target.ParameterInfo;

namespace TestParser_ctest
{
	[TestClass]
	public class FunctionListParser_ctest
	{
		[TestMethod]
		public void TEST_001()
		{
			string filePath = @".\..\..\data\FunctionListParser_TestData_001.xlsx";
			var parser = new FunctionListParser("テスト一覧_001");
			IEnumerable<TestParser.Target.ParameterInfo> functionList = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				functionList = (IEnumerable<TestParser.Target.ParameterInfo>)parsed;
			}

			Assert.AreEqual(1, functionList.Count());
			ParameterInfo paramInfo = functionList.ElementAt(0);

			Assert.AreEqual(1, paramInfo.Index);
			Assert.AreEqual("SampleTestData_1", paramInfo.Name);
			Assert.AreEqual("test_data_001", paramInfo.InfoName);
			Assert.AreEqual("test_data_001.cpp", paramInfo.FileName);
			Assert.AreEqual(string.Empty, paramInfo.FilePath);
		}

		[TestMethod]
		public void TEST_002()
		{
			string filePath = @".\..\..\data\FunctionListParser_TestData_001.xlsx";
			var parser = new FunctionListParser("テスト一覧_002");
			IEnumerable<TestParser.Target.ParameterInfo> functionList = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				functionList = (IEnumerable<TestParser.Target.ParameterInfo>)parsed;
			}

			Assert.AreEqual(2, functionList.Count());

			ParameterInfo paramInfo = functionList.ElementAt(0);
			Assert.AreEqual(1, paramInfo.Index);
			Assert.AreEqual("SampleTestData_1", paramInfo.Name);
			Assert.AreEqual("test_data_001", paramInfo.InfoName);
			Assert.AreEqual("test_data_001.cpp", paramInfo.FileName);
			Assert.AreEqual(string.Empty, paramInfo.FilePath);

			paramInfo = functionList.ElementAt(1);
			Assert.AreEqual(2, paramInfo.Index);
			Assert.AreEqual("SampleTestData_2", paramInfo.Name);
			Assert.AreEqual("test_data_002", paramInfo.InfoName);
			Assert.AreEqual("test_data_002.cpp", paramInfo.FileName);
			Assert.AreEqual(string.Empty, paramInfo.FilePath);
		}

		[TestMethod]
		public void TEST_000()
		{
			string filePath = @".\..\..\data\FunctionListParser_TestData_001.xlsx";
			var parser = new FunctionListParser("テスト一覧_000");
			IEnumerable<TestParser.Target.ParameterInfo> functionList = null;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				object parsed = parser.Parse(file);
				functionList = (IEnumerable<TestParser.Target.ParameterInfo>)parsed;
			}

			Assert.AreEqual(0, functionList.Count());
		}
	}
}
