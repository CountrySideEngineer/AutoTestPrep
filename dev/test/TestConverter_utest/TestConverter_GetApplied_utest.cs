using FunctionConverter_utest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Converter.Test;

namespace TestConverter_utest
{
	public partial class TestConverter_utest
	{
		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetApplied")]
		public void GetApplied_test_001()
		{
			var content = new Content_test_jig();
			var rowItem1 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem1);
			var rowItem2 = new List<string>()
			{
				"", "A"
			};
			content.AddRow(rowItem2);
			var rowItem3 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem3);

			var converter = new TestConverter(null);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes = (IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetAppliedIndexes", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(2, indexes.ElementAt(0).Count());
			Assert.AreEqual(0, indexes.ElementAt(0).ElementAt(0));
			Assert.AreEqual(2, indexes.ElementAt(0).ElementAt(1));
			Assert.AreEqual(1, indexes.ElementAt(1).Count());
			Assert.AreEqual(1, indexes.ElementAt(1).ElementAt(0));
		}

		[TestMethod]
		[TestCategory("TestConverter")]
		[TestCategory("GetApplied")]
		public void GetApplied_test_002()
		{
			var content = new Content_test_jig();
			var rowItem1 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem1);
			var rowItem2 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem2);
			var rowItem3 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem3);

			var converter = new TestConverter(null);
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes = (IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetAppliedIndexes", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(3, indexes.ElementAt(0).Count());
			Assert.AreEqual(0, indexes.ElementAt(0).ElementAt(0));
			Assert.AreEqual(1, indexes.ElementAt(0).ElementAt(1));
			Assert.AreEqual(2, indexes.ElementAt(0).ElementAt(2));
			Assert.AreEqual(0, indexes.ElementAt(1).Count());
		}
	}
}
