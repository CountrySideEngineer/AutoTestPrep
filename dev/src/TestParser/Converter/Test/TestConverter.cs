using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Config;
using TestParser.Data;

namespace TestParser.Converter.Test
{
	class TestConverter : AContentConverter
	{
		protected TestCaseTableConfig _config;

		protected const int _testCaseStartCol = 5;
		protected const int _paramColCount = 5;

		protected static string _applySign = "A";

		protected static string _inputRowName = "入力";
		protected static string _expectRowName = "期待値";
		protected static string _inputExpectColName = "入力/期待値";
		protected static string _category = "条件";
		protected static string _variableName = "変数名";
		protected static string _variableRange = "範囲";
		protected static string _testValue = "代表値";
		protected static IEnumerable<string> _paramColNames =
			new List<string>{ _inputExpectColName, _category, _variableName, _variableRange, _testValue };

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
		public override object Convert(DataTable src)
		{
			TRACE($"{nameof(Convert)} in {nameof(TestConverter)} called.");

			var testCases = new List<TestCase>();
			IEnumerable<string> testIds = GetTestId(src);
			foreach (var testId in testIds)
			{
				try
				{
					DataTable testCaseTable = GetTestCaseTable(src, testId);
					IEnumerable<TestData> testDatas = ConvertToTestData(testCaseTable);
					TestCase testCase = ConvertToTestCase(testDatas);
					testCases.Add(testCase);
				}
				catch (InvalidOperationException)
				{
					WARN($"Test data of test id {testId} failed, skip the test case.");
				}
			}
			return testCases;
		}

		/// <summary>
		/// Returs test case id as coolection of string data type.
		/// </summary>
		/// <param name="src">Test design data as DataTable object.</param>
		/// <returns>Colelction of data table.</returns>
		protected IEnumerable<string> GetTestId(DataTable src)
		{
			TRACE($"{nameof(GetTestId)} in {nameof(TestConverter)} called.");

			DataTable srcCopy = src.Copy();
			foreach (var paramColName in _paramColNames)
			{
				srcCopy.Columns.Remove(paramColName);
			}
			List<string> testIds = new List<string>();
			foreach (DataColumn column in srcCopy.Columns)
			{
				testIds.Add(column.ColumnName);
			}
			return testIds;
		}

		/// <summary>
		/// Returs test case data as DataTable.
		/// </summary>
		/// <param name="src">Test case data table.</param>
		/// <param name="id">Test id to get.</param>
		/// <returns>Applied test case data.</returns>
		protected virtual DataTable GetTestCaseTable(DataTable src, string id)
		{
			TRACE($"{nameof(GetTestCaseTable)} in {nameof(TestConverter)} called.");

			try
			{
				var paramAndId = new List<string>(_paramColNames);
				paramAndId.Add(id);
				DataView srcDataView = new DataView(src);
				DataTable testTable = srcDataView.ToTable(false, paramAndId.ToArray());
				DataTable testCaseTable = testTable.AsEnumerable()
					.Where(_ => _[id].ToString().ToUpper().Equals(_applySign))
					.CopyToDataTable();
				return testCaseTable;
			}
			catch (InvalidOperationException)
			{
				throw;
			}
		}

		/// <summary>
		/// Convert test case data into collection of TestData object.
		/// </summary>
		/// <param name="testDataTable">Test case data.</param>
		/// <returns>Collection of TestData object of applied test data.</returns>
		protected virtual IEnumerable<TestData> ConvertToTestData(DataTable testDataTable)
		{
			TRACE($"{nameof(ConvertToTestData)} in {nameof(TestConverter)} called.");

			IContentConverter converter = new TestDataConverter(
				_inputExpectColName,
				string.Empty,
				_variableName,
				_testValue
				);
			var testDatas = (IEnumerable<TestData>)Convert(testDataTable, converter);
			return testDatas;
		}

		/// <summary>
		/// Convert collection of TestData to TestCase object.
		/// </summary>
		/// <param name="testDatas">Collection of TestData object.</param>
		/// <returns>Converted TestCase object.</returns>
		protected TestCase ConvertToTestCase(IEnumerable<TestData> testDatas)
		{
			TRACE($"{nameof(ConvertToTestCase)} in {nameof(TestConverter)} called.");

			var inputs = testDatas.Where(_ => _.Condition.Equals(_config.Input));
			var expects = testDatas.Where(_ => _.Condition.Equals(_config.Exepct));

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
		protected object Convert(DataTable src, IContentConverter converter)
		{
			TRACE($"{nameof(Convert)} in {nameof(TestConverter)} called.");

			return converter.Convert(src);
		}
	}
}
