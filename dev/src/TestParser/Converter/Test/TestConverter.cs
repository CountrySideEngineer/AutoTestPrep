using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Config;
using TestParser.Data;

namespace TestParser.Converter.Test
{
	public class TestConverter : IContentConverter
	{
		protected TestCaseTableConfig _config;

		protected const int _testCaseStartCol = 5;
		protected const int _paramColCount = 5;

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected TestConverter() { }

		/// <summary>
		/// Constructor with argument about converter configuration.
		/// </summary>
		/// <param name="config">Test converter configuration.</param>
		public TestConverter(TestCaseTableConfig config)
		{
			_config = config;
		}

		/// <summary>
		/// Convert test table data to Test object.
		/// </summary>
		/// <param name="src">Content of test table.</param>
		/// <returns>Test object converted from the Content object.</returns>
		public object Convert(Content src)
		{
			var testCases = new List<TestCase>();
			SetTo(src, ref testCases);

			return testCases;
		}

		protected void SetTo(Content src, ref List<TestCase> testCases)
		{
			(Content param, Content apply) = SplitToParamAndApply(src);
			IEnumerable<IEnumerable<int>> appliedIndexes = GetAppliedIndexes(apply);
			IEnumerable<IEnumerable<TestData>> testDatas = GetTestData(param, appliedIndexes);
			IEnumerable<TestCase> testCase = ConvertToTestCase(testDatas);

			testCase = testCase.ToList();
		}

		protected (Content, Content) SplitToParamAndApply(Content src)
		{
			Content testParam = src.Take(_paramColCount);
			Content testApply = src.Skip(_paramColCount);

			return (testParam, testApply);
		}

		protected IEnumerable<IEnumerable<int>> GetAppliedIndexes(Content src)
		{
			var converter = new TestApplyConverter();
			IEnumerable<IEnumerable<int>> appliedIndexs = 
				(IEnumerable<IEnumerable<int>>)Convert(src, converter);
			return appliedIndexs;
		}

		protected IEnumerable<IEnumerable<TestData>> GetTestData(Content src, IEnumerable<IEnumerable<int>> appliedIndexes)
		{
			TestDataConverter converter = new TestDataConverter(
				expectName: _config.Exepct,
				returnName: "戻り値",
				returnVariableName: "_ret_val");
			var testDatas = new List<List<TestData>>();
			foreach (var indexesItem in appliedIndexes)
			{
				converter.Indexes = indexesItem;
				IEnumerable<TestData> testData = (IEnumerable<TestData>)Convert(src, converter);
				testDatas.Add(testData.ToList());
			}
			return testDatas;
		}

		protected IEnumerable<TestCase> ConvertToTestCase(IEnumerable<IEnumerable<TestData>> testDatas)
		{
			var testCases = new List<TestCase>();
			foreach (var testData in testDatas)
			{
				TestCase testCase = ConvertToTestCase(testData);
				testCases.Add(testCase);
			}
			return testCases;
		}

		protected TestCase ConvertToTestCase(IEnumerable<TestData> testData)
		{
			var inputs = testData.Where(_ => _.Condition.Equals(_config.Input));
			var expects = testData.Where(_ => _.Condition.Equals(_config.Exepct));

			var testCase = new TestCase()
			{
				Input = inputs,
				Expects = expects
			};
			return testCase;
		}

		protected object Convert(Content src, IContentConverter converter)
		{
			return converter.Convert(src);
		}
	}
}
