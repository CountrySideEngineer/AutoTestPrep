using FunctionConverter_utest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Converter.Test;
using TestParser.Data;

namespace TestDataConverter_utest
{
	public partial class TestDataConverter_utest
	{
		[TestMethod]
		public void Convert_utest_001()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);

			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			var privateConverter = new PrivateObject(converter);
			TestData output = (TestData)privateConverter.Invoke("Convert", jig, 0);

			Assert.AreEqual("入力", output.Condition);
			Assert.AreEqual("引数", output.Descriotion);
			Assert.AreEqual("input1", output.Name);
			Assert.AreEqual("0", output.Value);
		}

		[TestMethod]
		public void Convert_utest_002()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);

			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			var privateConverter = new PrivateObject(converter);
			TestData output = (TestData)privateConverter.Invoke("Convert", jig, 1);

			Assert.AreEqual("期待値", output.Condition);
			Assert.AreEqual("戻り値", output.Descriotion);
			Assert.AreEqual("_ret_val", output.Name);
			Assert.AreEqual("1", output.Value);
		}

		[TestMethod]
		public void Convert_utest_003()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", "", "2"
			};
			jig.AddRow(expect2);

			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			var privateConverter = new PrivateObject(converter);
			TestData output = (TestData)privateConverter.Invoke("Convert", jig, 2);

			Assert.AreEqual("期待値", output.Condition);
			Assert.AreEqual("呼び出し回数", output.Descriotion);
			Assert.AreEqual("subFunc_called_count", output.Name);
			Assert.AreEqual("2", output.Value);
		}

		[TestMethod]
		public void Convert_utest_004()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", "", "2"
			};
			jig.AddRow(expect2);

			List<int> indexes = new List<int>()
			{
				0, 1, 2
			};
			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			converter.Indexes = indexes;
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestData> testDatas = (IEnumerable<TestData>)privateConverter.Invoke("Convert", jig);

			Assert.AreEqual(3, testDatas.Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).Value);

			Assert.AreEqual("期待値", testDatas.ElementAt(1).Condition);
			Assert.AreEqual("戻り値", testDatas.ElementAt(1).Descriotion);
			Assert.AreEqual("_ret_val", testDatas.ElementAt(1).Name);
			Assert.AreEqual("1", testDatas.ElementAt(1).Value);

			Assert.AreEqual("期待値", testDatas.ElementAt(2).Condition);
			Assert.AreEqual("呼び出し回数", testDatas.ElementAt(2).Descriotion);
			Assert.AreEqual("subFunc_called_count", testDatas.ElementAt(2).Name);
			Assert.AreEqual("2", testDatas.ElementAt(2).Value);
		}

		[TestMethod]
		public void Convert_utest_005()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", "", "2"
			};
			jig.AddRow(expect2);

			List<int> indexes = new List<int>()
			{
				0
			};
			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			converter.Indexes = indexes;
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestData> testDatas = (IEnumerable<TestData>)privateConverter.Invoke("Convert", jig);

			Assert.AreEqual(1, testDatas.Count());
			Assert.AreEqual("入力", testDatas.ElementAt(0).Condition);
			Assert.AreEqual("引数", testDatas.ElementAt(0).Descriotion);
			Assert.AreEqual("input1", testDatas.ElementAt(0).Name);
			Assert.AreEqual("0", testDatas.ElementAt(0).Value);
		}

		[TestMethod]
		public void Convert_utest_006()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", "", "2"
			};
			jig.AddRow(expect2);

			List<int> indexes = new List<int>()
			{
				2
			};
			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			converter.Indexes = indexes;
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestData> testDatas = (IEnumerable<TestData>)privateConverter.Invoke("Convert", jig);

			Assert.AreEqual(1, testDatas.Count());
			Assert.AreEqual("期待値", testDatas.ElementAt(0).Condition);
			Assert.AreEqual("呼び出し回数", testDatas.ElementAt(0).Descriotion);
			Assert.AreEqual("subFunc_called_count", testDatas.ElementAt(0).Name);
			Assert.AreEqual("2", testDatas.ElementAt(0).Value);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Convert_utest_007()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", "", "2"
			};
			jig.AddRow(expect2);

			List<int> indexes = new List<int>()
			{
				2
			};
			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestData> testDatas = (IEnumerable<TestData>)privateConverter.Invoke("Convert", jig);

			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Convert_utest_008()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", "", "2"
			};
			jig.AddRow(expect2);

			List<int> indexes = new List<int>()
			{
				2
			};
			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			converter.Indexes = indexes;
			var privateConverter = new PrivateObject(converter);
			jig = null;
			IEnumerable<TestData> testDatas = (IEnumerable<TestData>)privateConverter.Invoke("Convert", jig);

			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void Convert_utest_009()
		{
			Content_test_jig jig = new Content_test_jig();
			IEnumerable<string> input1 = new List<string>()
			{
				"入力", "引数",  "input1", "0～10", "0"
			};
			jig.AddRow(input1);
			IEnumerable<string> expect1 = new List<string>()
			{
				"期待値", "戻り値",  "ret_val", "", "1"
			};
			jig.AddRow(expect1);
			IEnumerable<string> expect2 = new List<string>()
			{
				"期待値", "呼び出し回数",  "subFunc_called_count", ""
			};
			jig.AddRow(expect2);

			List<int> indexes = new List<int>()
			{
				2
			};
			var converter = new TestDataConverter("期待値", "戻り値", "_ret_val");
			converter.Indexes = indexes;
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestData> testDatas = (IEnumerable<TestData>)privateConverter.Invoke("Convert", jig);

			Assert.Fail();
		}
	}
}
