using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionConverter_utest;
using TestParser.Converter.Test;
using TestParser.Config;
using TestParser.Data;

namespace TestConverter_utest
{
	public partial class TestConverter_utest
	{
		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetTestData")]
		public void GetTestData_utest_001()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0"
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2"
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig();
			IEnumerable<IEnumerable<int>> indexes = new List<List<int>>()
			{
				new List<int>()
				{
					0,
				},
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<TestData>> testDatas =
				(IEnumerable<IEnumerable<TestData>>)privateConverter.Invoke("GetTestData", jig, indexes);

			Assert.AreEqual(1, testDatas.Count());
			Assert.AreEqual(1, testDatas.ElementAt(0).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetTestData")]
		public void GetTestData_utest_002()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0"
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2"
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig();
			IEnumerable<IEnumerable<int>> indexes = new List<List<int>>()
			{
				new List<int>()
				{
					2,
				},
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<TestData>> testDatas =
				(IEnumerable<IEnumerable<TestData>>)privateConverter.Invoke("GetTestData", jig, indexes);

			Assert.AreEqual(1, testDatas.Count());
			Assert.AreEqual(1, testDatas.ElementAt(0).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(0).Name);
			Assert.AreEqual("2", testDatas.ElementAt(0).ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetTestData")]
		public void GetTestData_utest_003()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0"
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2"
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig();
			IEnumerable<IEnumerable<int>> indexes = new List<List<int>>()
			{
				new List<int>()
				{
					0, 2,
				},
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<TestData>> testDatas =
				(IEnumerable<IEnumerable<TestData>>)privateConverter.Invoke("GetTestData", jig, indexes);

			Assert.AreEqual(1, testDatas.Count());
			Assert.AreEqual(2, testDatas.ElementAt(0).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).ElementAt(0).Value);
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(1).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(1).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(1).Name);
			Assert.AreEqual("2", testDatas.ElementAt(0).ElementAt(1).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetTestData")]
		public void GetTestData_utest_004()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0"
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2"
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig();
			IEnumerable<IEnumerable<int>> indexes = new List<List<int>>()
			{
				new List<int>()
				{
					0,
				},
				new List<int>()
				{
					2,
				},
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<TestData>> testDatas =
				(IEnumerable<IEnumerable<TestData>>)privateConverter.Invoke("GetTestData", jig, indexes);

			Assert.AreEqual(2, testDatas.Count());
			Assert.AreEqual(1, testDatas.ElementAt(0).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).ElementAt(0).Value);
			Assert.AreEqual(1, testDatas.ElementAt(1).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(1).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(1).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(1).ElementAt(0).Name);
			Assert.AreEqual("2", testDatas.ElementAt(1).ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetTestData")]
		public void GetTestData_utest_005()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0"
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2"
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig();
			IEnumerable<IEnumerable<int>> indexes = new List<List<int>>()
			{
				new List<int>()
				{
					0,
				},
				new List<int>()
				{
					1, 2
				},
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<TestData>> testDatas =
				(IEnumerable<IEnumerable<TestData>>)privateConverter.Invoke("GetTestData", jig, indexes);

			Assert.AreEqual(2, testDatas.Count());
			Assert.AreEqual(1, testDatas.ElementAt(0).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).ElementAt(0).Value);
			Assert.AreEqual(2, testDatas.ElementAt(1).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(1).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(1).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(1).ElementAt(0).Name);
			Assert.AreEqual("1", testDatas.ElementAt(1).ElementAt(0).Value);
			Assert.AreEqual("入力", testDatas.ElementAt(1).ElementAt(1).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(1).ElementAt(1).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(1).ElementAt(1).Name);
			Assert.AreEqual("2", testDatas.ElementAt(1).ElementAt(1).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetTestData")]
		public void GetTestData_utest_006()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0"
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2"
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig();
			IEnumerable<IEnumerable<int>> indexes = new List<List<int>>()
			{
				new List<int>()
				{
					0,
				},
				new List<int>()
				{
					0, 1, 2
				},
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<TestData>> testDatas =
				(IEnumerable<IEnumerable<TestData>>)privateConverter.Invoke("GetTestData", jig, indexes);

			Assert.AreEqual(2, testDatas.Count());
			Assert.AreEqual(1, testDatas.ElementAt(0).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).ElementAt(0).Value);
			Assert.AreEqual(3, testDatas.ElementAt(1).Count());
			Assert.AreEqual("入力", testDatas.ElementAt(1).ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(1).ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(1).ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(1).ElementAt(0).Value);
			Assert.AreEqual("入力", testDatas.ElementAt(1).ElementAt(1).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(1).ElementAt(1).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(1).ElementAt(1).Name);
			Assert.AreEqual("1", testDatas.ElementAt(1).ElementAt(1).Value);
			Assert.AreEqual("入力", testDatas.ElementAt(1).ElementAt(2).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(1).ElementAt(2).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(1).ElementAt(2).Name);
			Assert.AreEqual("2", testDatas.ElementAt(1).ElementAt(2).Value);
		}
	}
}
