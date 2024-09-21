using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Config;
using TestParser.Converter.Test;
using TestParser.Data;

namespace TestConverter_utest
{
	public partial class TestConverter_utest
	{
		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("ConvertToTestCase")]
		public void ConvertToTestCase_utest_001()
		{
			var testDatas = new List<TestData>()
			{
				new TestData()
				{
					Condition = "入力",
					Descriotion = "引数",
					Name = "Input1",
					Value = "1"
				},
				new TestData()
				{
					Condition = "期待値",
					Descriotion = "戻り値",
					Name = "_ret_val",
					Value = "2"
				},
			};
			TestCaseTableConfig config = new TestCaseTableConfig()
			{
				Input = "入力",
				Exepct = "期待値"
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			TestCase testCase = (TestCase)privateConverter.Invoke("ConvertToTestCase", testDatas);

			Assert.AreEqual(1, testCase.Input.Count());
			Assert.AreEqual("入力", testCase.Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCase.Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCase.Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCase.Input.ElementAt(0).Value);
			Assert.AreEqual(1, testCase.Expects.Count());
			Assert.AreEqual("期待値", testCase.Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCase.Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCase.Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCase.Expects.ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("ConvertToTestCase")]
		public void ConvertToTestCase_utest_002()
		{
			var testDatas = new List<TestData>()
			{
				new TestData()
				{
					Condition = "入力",
					Descriotion = "引数",
					Name = "Input1",
					Value = "1"
				},
				new TestData()
				{
					Condition = "入力",
					Descriotion = "引数",
					Name = "Input2",
					Value = "3"
				},
				new TestData()
				{
					Condition = "期待値",
					Descriotion = "戻り値",
					Name = "_ret_val",
					Value = "2"
				},
			};
			TestCaseTableConfig config = new TestCaseTableConfig()
			{
				Input = "入力",
				Exepct = "期待値"
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			TestCase testCase = (TestCase)privateConverter.Invoke("ConvertToTestCase", testDatas);

			Assert.AreEqual(2, testCase.Input.Count());
			Assert.AreEqual("入力", testCase.Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCase.Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCase.Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCase.Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCase.Input.ElementAt(1).Condition);
			Assert.AreEqual("引数", testCase.Input.ElementAt(1).Descriotion);
			Assert.AreEqual("Input2", testCase.Input.ElementAt(1).Name);
			Assert.AreEqual("3", testCase.Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCase.Expects.Count());
			Assert.AreEqual("期待値", testCase.Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCase.Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCase.Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCase.Expects.ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("ConvertToTestCase")]
		public void ConvertToTestCase_utest_003()
		{
			var testDatas = new List<TestData>()
			{
				new TestData()
				{
					Condition = "入力",
					Descriotion = "引数",
					Name = "Input1",
					Value = "1"
				},
				new TestData()
				{
					Condition = "入力",
					Descriotion = "引数",
					Name = "Input2",
					Value = "3"
				},
				new TestData()
				{
					Condition = "",
					Descriotion = "引数",
					Name = "Input2",
					Value = "3"
				},
				new TestData()
				{
					Condition = "期待値",
					Descriotion = "戻り値",
					Name = "_ret_val",
					Value = "2"
				},
			};
			TestCaseTableConfig config = new TestCaseTableConfig()
			{
				Input = "入力",
				Exepct = "期待値"
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			TestCase testCase = (TestCase)privateConverter.Invoke("ConvertToTestCase", testDatas);

			Assert.AreEqual(2, testCase.Input.Count());
			Assert.AreEqual("入力", testCase.Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCase.Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCase.Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCase.Input.ElementAt(0).Value);
			Assert.AreEqual("入力", testCase.Input.ElementAt(1).Condition);
			Assert.AreEqual("引数", testCase.Input.ElementAt(1).Descriotion);
			Assert.AreEqual("Input2", testCase.Input.ElementAt(1).Name);
			Assert.AreEqual("3", testCase.Input.ElementAt(1).Value);
			Assert.AreEqual(1, testCase.Expects.Count());
			Assert.AreEqual("期待値", testCase.Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCase.Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCase.Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCase.Expects.ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("ConvertToTestCase")]
		public void ConvertToTestCase_utest_004()
		{
			var testDatas = new List<List<TestData>>()
			{
				new List<TestData>()
				{
					new TestData()
					{
						Condition = "入力",
						Descriotion = "引数",
						Name = "Input1",
						Value = "1"
					},
					new TestData()
					{
						Condition = "期待値",
						Descriotion = "戻り値",
						Name = "_ret_val",
						Value = "2"
					},
				},
				new List<TestData>()
				{
					new TestData()
					{
						Condition = "入力",
						Descriotion = "引数",
						Name = "Input1",
						Value = "3"
					},
					new TestData()
					{
						Condition = "期待値",
						Descriotion = "戻り値",
						Name = "_ret_val",
						Value = "4"
					},
				}
			};
			TestCaseTableConfig config = new TestCaseTableConfig()
			{
				Input = "入力",
				Exepct = "期待値"
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestCase> testCases =
				(IEnumerable<TestCase>)privateConverter.Invoke("ConvertToTestCase", testDatas);

			Assert.AreEqual(2, testCases.Count());
			Assert.AreEqual(1, testCases.ElementAt(0).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCases.ElementAt(0).Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCases.ElementAt(0).Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(0).Input.ElementAt(0).Value);
			Assert.AreEqual(1, testCases.ElementAt(0).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(0).Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCases.ElementAt(0).Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCases.ElementAt(0).Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCases.ElementAt(0).Expects.ElementAt(0).Value);
			Assert.AreEqual(1, testCases.ElementAt(1).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(1).Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCases.ElementAt(1).Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCases.ElementAt(1).Input.ElementAt(0).Name);
			Assert.AreEqual("3", testCases.ElementAt(1).Input.ElementAt(0).Value);
			Assert.AreEqual(1, testCases.ElementAt(1).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(1).Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCases.ElementAt(1).Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCases.ElementAt(1).Expects.ElementAt(0).Name);
			Assert.AreEqual("4", testCases.ElementAt(1).Expects.ElementAt(0).Value);
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("ConvertToTestCase")]
		public void ConvertToTestCase_utest_005()
		{
			var testDatas = new List<List<TestData>>()
			{
				new List<TestData>()
				{
					new TestData()
					{
						Condition = "入力",
						Descriotion = "引数",
						Name = "Input1",
						Value = "1"
					},
					new TestData()
					{
						Condition = "期待値",
						Descriotion = "戻り値",
						Name = "_ret_val",
						Value = "2"
					},
				},
				new List<TestData>()
				{
					new TestData()
					{
						Condition = "入力",
						Descriotion = "引数",
						Name = "Input1",
						Value = "3"
					},
					new TestData()
					{
						Condition = "期待値",
						Descriotion = "戻り値",
						Name = "_ret_val",
						Value = "4"
					},
					new TestData()
					{
						Condition = "期待値",
						Descriotion = "回関数呼び出し回数",
						Name = "subFunc_called_count",
						Value = "1"
					},
				}
			};
			TestCaseTableConfig config = new TestCaseTableConfig()
			{
				Input = "入力",
				Exepct = "期待値"
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<TestCase> testCases =
				(IEnumerable<TestCase>)privateConverter.Invoke("ConvertToTestCase", testDatas);

			Assert.AreEqual(2, testCases.Count());
			Assert.AreEqual(1, testCases.ElementAt(0).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(0).Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCases.ElementAt(0).Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCases.ElementAt(0).Input.ElementAt(0).Name);
			Assert.AreEqual("1", testCases.ElementAt(0).Input.ElementAt(0).Value);
			Assert.AreEqual(1, testCases.ElementAt(0).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(0).Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCases.ElementAt(0).Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCases.ElementAt(0).Expects.ElementAt(0).Name);
			Assert.AreEqual("2", testCases.ElementAt(0).Expects.ElementAt(0).Value);
			Assert.AreEqual(1, testCases.ElementAt(1).Input.Count());
			Assert.AreEqual("入力", testCases.ElementAt(1).Input.ElementAt(0).Condition);
			Assert.AreEqual("引数", testCases.ElementAt(1).Input.ElementAt(0).Descriotion);
			Assert.AreEqual("Input1", testCases.ElementAt(1).Input.ElementAt(0).Name);
			Assert.AreEqual("3", testCases.ElementAt(1).Input.ElementAt(0).Value);
			Assert.AreEqual(2, testCases.ElementAt(1).Expects.Count());
			Assert.AreEqual("期待値", testCases.ElementAt(1).Expects.ElementAt(0).Condition);
			Assert.AreEqual("戻り値", testCases.ElementAt(1).Expects.ElementAt(0).Descriotion);
			Assert.AreEqual("_ret_val", testCases.ElementAt(1).Expects.ElementAt(0).Name);
			Assert.AreEqual("4", testCases.ElementAt(1).Expects.ElementAt(0).Value);
			Assert.AreEqual("期待値", testCases.ElementAt(1).Expects.ElementAt(1).Condition);
			Assert.AreEqual("回関数呼び出し回数", testCases.ElementAt(1).Expects.ElementAt(1).Descriotion);
			Assert.AreEqual("subFunc_called_count", testCases.ElementAt(1).Expects.ElementAt(1).Name);
			Assert.AreEqual("1", testCases.ElementAt(1).Expects.ElementAt(1).Value);
		}
	}
}
