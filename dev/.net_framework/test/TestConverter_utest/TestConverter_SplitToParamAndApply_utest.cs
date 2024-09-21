using FunctionConverter_utest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Config;
using TestParser.Converter.Test;
using TestParser.Data;

namespace TestConverter_utest
{
	public partial class TestConverter_utest
	{
		[TestMethod]
		public void SplitToParamAndApply_test_001()
		{
			var jig = new Content_test_jig();
			var row1 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "0", ""
			};
			jig.AddRow(row1);
			var row2 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "1", "A"
			};
			jig.AddRow(row2);
			var row3 = new List<string>()
			{
				"入力", "引数", "input1", "0～10", "2", ""
			};
			jig.AddRow(row3);
			TestCaseTableConfig config = new TestCaseTableConfig()
			{
				Input = "入力",
				Exepct = "期待値"
			};
			var converter = new TestConverter(config);
			var privateConverter = new PrivateObject(converter);
			(Content param, Content apply) = (ValueTuple<Content, Content>)privateConverter.Invoke("SplitToParamAndApply", jig);

			Assert.AreEqual(3, param.RowCount());
			Assert.AreEqual(5, param.ColCount());
			Assert.AreEqual("入力", param.GetContentsInRow(0).ElementAt(0));
			Assert.AreEqual("引数", param.GetContentsInRow(0).ElementAt(1));
			Assert.AreEqual("input1", param.GetContentsInRow(0).ElementAt(2));
			Assert.AreEqual("0～10", param.GetContentsInRow(0).ElementAt(3));
			Assert.AreEqual("0", param.GetContentsInRow(0).ElementAt(4));
			Assert.AreEqual("入力", param.GetContentsInRow(1).ElementAt(0));
			Assert.AreEqual("引数", param.GetContentsInRow(1).ElementAt(1));
			Assert.AreEqual("input1", param.GetContentsInRow(1).ElementAt(2));
			Assert.AreEqual("0～10", param.GetContentsInRow(1).ElementAt(3));
			Assert.AreEqual("1", param.GetContentsInRow(1).ElementAt(4));
			Assert.AreEqual("入力", param.GetContentsInRow(2).ElementAt(0));
			Assert.AreEqual("引数", param.GetContentsInRow(2).ElementAt(1));
			Assert.AreEqual("input1", param.GetContentsInRow(2).ElementAt(2));
			Assert.AreEqual("0～10", param.GetContentsInRow(2).ElementAt(3));
			Assert.AreEqual("2", param.GetContentsInRow(2).ElementAt(4));
			Assert.AreEqual(3, apply.RowCount());
			Assert.AreEqual(1, apply.ColCount());
			Assert.AreEqual("", apply.GetContentsInRow(0).ElementAt(0));
			Assert.AreEqual("A", apply.GetContentsInRow(1).ElementAt(0));
			Assert.AreEqual("", apply.GetContentsInRow(2).ElementAt(0));

		}
	}
}
