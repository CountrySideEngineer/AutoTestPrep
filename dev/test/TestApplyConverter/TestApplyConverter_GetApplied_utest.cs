using FunctionConverter_utest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Converter.Test;

namespace TestApplyConverter_utest
{
	public partial class TestApplyConverter_utest
	{
		[TestMethod]
		public void GetApplied_test_001()
		{
			var rowItem1 = new List<string>()
			{
				"A", ""
			};

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<int> indexes =
				(IEnumerable<int>)privateConverter.Invoke("GetApplied", rowItem1);

			Assert.AreEqual(1, indexes.Count());
			Assert.AreEqual(0, indexes.ElementAt(0));
		}

		[TestMethod]
		public void GetApplied_test_002()
		{
			var rowItem1 = new List<string>()
			{
				"", "A"
			};

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<int> indexes =
				(IEnumerable<int>)privateConverter.Invoke("GetApplied", rowItem1);

			Assert.AreEqual(1, indexes.Count());
			Assert.AreEqual(1, indexes.ElementAt(0));
		}

		[TestMethod]
		public void GetApplied_test_003()
		{
			var rowItem1 = new List<string>()
			{
				"A", "A"
			};

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<int> indexes =
				(IEnumerable<int>)privateConverter.Invoke("GetApplied", rowItem1);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(0, indexes.ElementAt(0));
			Assert.AreEqual(1, indexes.ElementAt(1));
		}

		[TestMethod]
		public void GetApplied_test_004()
		{
			var rowItem1 = new List<string>()
			{
				"", ""
			};

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<int> indexes =
				(IEnumerable<int>)privateConverter.Invoke("GetApplied", rowItem1);

			Assert.AreEqual(0, indexes.Count());
		}

		[TestMethod]
		public void GetApplied_test_005()
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

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes =
				(IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetApplied", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(2, indexes.ElementAt(0).Count());
			Assert.AreEqual(0, indexes.ElementAt(0).ElementAt(0));
			Assert.AreEqual(2, indexes.ElementAt(0).ElementAt(1));
			Assert.AreEqual(1, indexes.ElementAt(1).Count());
			Assert.AreEqual(1, indexes.ElementAt(1).ElementAt(0));
		}

		[TestMethod]
		public void GetApplied_test_006()
		{
			var content = new Content_test_jig();
			var rowItem1 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem1);
			var rowItem2 = new List<string>()
			{
				"A", "A"
			};
			content.AddRow(rowItem2);
			var rowItem3 = new List<string>()
			{
				"A", ""
			};
			content.AddRow(rowItem3);

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes =
				(IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetApplied", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(3, indexes.ElementAt(0).Count());
			Assert.AreEqual(0, indexes.ElementAt(0).ElementAt(0));
			Assert.AreEqual(1, indexes.ElementAt(0).ElementAt(1));
			Assert.AreEqual(2, indexes.ElementAt(0).ElementAt(2));
			Assert.AreEqual(1, indexes.ElementAt(1).Count());
			Assert.AreEqual(1, indexes.ElementAt(1).ElementAt(0));
		}

		[TestMethod]
		public void GetApplied_test_007()
		{
			var content = new Content_test_jig();
			var rowItem1 = new List<string>()
			{
				"A", "A"
			};
			content.AddRow(rowItem1);
			var rowItem2 = new List<string>()
			{
				"", "A"
			};
			content.AddRow(rowItem2);
			var rowItem3 = new List<string>()
			{
				"A", "A"
			};
			content.AddRow(rowItem3);

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes =
				(IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetApplied", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(2, indexes.ElementAt(0).Count());
			Assert.AreEqual(0, indexes.ElementAt(0).ElementAt(0));
			Assert.AreEqual(2, indexes.ElementAt(0).ElementAt(1));
			Assert.AreEqual(3, indexes.ElementAt(1).Count());
			Assert.AreEqual(0, indexes.ElementAt(1).ElementAt(0));
			Assert.AreEqual(1, indexes.ElementAt(1).ElementAt(1));
			Assert.AreEqual(2, indexes.ElementAt(1).ElementAt(2));
		}

		[TestMethod]
		public void GetApplied_test_008()
		{
			var content = new Content_test_jig();
			var rowItem1 = new List<string>()
			{
				"", "A"
			};
			content.AddRow(rowItem1);
			var rowItem2 = new List<string>()
			{
				"", "A"
			};
			content.AddRow(rowItem2);
			var rowItem3 = new List<string>()
			{
				"", "A"
			};
			content.AddRow(rowItem3);

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes =
				(IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetApplied", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(0, indexes.ElementAt(0).Count());
			Assert.AreEqual(3, indexes.ElementAt(1).Count());
			Assert.AreEqual(0, indexes.ElementAt(1).ElementAt(0));
			Assert.AreEqual(1, indexes.ElementAt(1).ElementAt(1));
			Assert.AreEqual(2, indexes.ElementAt(1).ElementAt(2));
		}

		[TestMethod]
		public void GetApplied_test_009()
		{
			var content = new Content_test_jig();
			var rowItem1 = new List<string>()
			{
				"", ""
			};
			content.AddRow(rowItem1);
			var rowItem2 = new List<string>()
			{
				"", ""
			};
			content.AddRow(rowItem2);
			var rowItem3 = new List<string>()
			{
				"", ""
			};
			content.AddRow(rowItem3);

			var converter = new TestApplyConverter();
			var privateConverter = new PrivateObject(converter);
			IEnumerable<IEnumerable<int>> indexes =
				(IEnumerable<IEnumerable<int>>)privateConverter.Invoke("GetApplied", content);

			Assert.AreEqual(2, indexes.Count());
			Assert.AreEqual(0, indexes.ElementAt(0).Count());
			Assert.AreEqual(0, indexes.ElementAt(1).Count());
		}
	}
}
