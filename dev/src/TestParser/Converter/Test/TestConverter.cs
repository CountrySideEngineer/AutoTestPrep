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

		/// <summary>
		/// Set test data as Content object to collection of TestCase object.
		/// </summary>
		/// <param name="src">Test case data as Content object.</param>
		/// <param name="testCases">Reference to collection of TestCase objet to set converted test data.</param>
		protected void SetTo(Content src, ref List<TestCase> testCases)
		{
			(Content param, Content apply) = SplitToParamAndApply(src);
			IEnumerable<IEnumerable<int>> appliedIndexes = GetAppliedIndexes(apply);
			IEnumerable<IEnumerable<TestData>> testDatas = GetTestData(param, appliedIndexes);
			IEnumerable<TestCase> testCase = ConvertToTestCase(testDatas);

			testCase = testCase.ToList();
		}

		/// <summary>
		/// Split test case table content into test parameter and applied datas.
		/// </summary>
		/// <param name="src">Content of test data as Content object.</param>
		/// <returns>Tuple of Content object parameter and applied information.</returns>
		protected (Content, Content) SplitToParamAndApply(Content src)
		{
			Content testParam = src.Take(_paramColCount);
			Content testApply = src.Skip(_paramColCount);

			return (testParam, testApply);
		}

		/// <summary>
		/// Get collection of index of applied test data.
		/// </summary>
		/// <param name="src">Content object of applied test data.</param>
		/// <returns>Collection of index applied test data.</returns>
		protected IEnumerable<IEnumerable<int>> GetAppliedIndexes(Content src)
		{
			var converter = new TestApplyConverter();
			IEnumerable<IEnumerable<int>> appliedIndexs = 
				(IEnumerable<IEnumerable<int>>)Convert(src, converter);
			return appliedIndexs;
		}

		/// <summary>
		/// Get TestData from Content 
		/// </summary>
		/// <param name="src">Test data table content to be converted.</param>
		/// <param name="appliedIndexes">Collection of index to apply as test data.</param>
		/// <returns>Collection of TestData.</returns>
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

		/// <summary>
		/// Convert collection of TestData to collection of TestCase object.
		/// </summary>
		/// <param name="testDatas">Collection of TestData to be converted.</param>
		/// <returns>Collection of TestCase obejcts.</returns>
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

		/// <summary>
		/// Convert collection of TestData to TestCase object.
		/// </summary>
		/// <param name="testData">Collection of TestData object.</param>
		/// <returns>Converted TestCase object.</returns>
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

		/// <summary>
		/// Convert content using conveter specified argument converter.
		/// </summary>
		/// <param name="src">Content to be converted.</param>
		/// <param name="converter">Converter which inherits IContentConverter interface.</param>
		/// <returns>Converted object.</returns>
		protected object Convert(Content src, IContentConverter converter)
		{
			return converter.Convert(src);
		}
	}
}
