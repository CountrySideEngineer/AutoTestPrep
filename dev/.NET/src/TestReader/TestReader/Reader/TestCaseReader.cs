using System.Data;
using TestReader.Model.Test;
using Logger;
using TestReader.Config;
using TestReader.Converter;

namespace TestReader.Reader
{
	public class TestCaseReader : ATableReader<IEnumerable<TestCase>>
	{
		/// <summary>
		/// Convert DataTable object about test case into collection of TestCase objects.
		/// </summary>
		/// <param name="data">DataTable object to convert.</param>
		/// <returns>Collection ob TestCase objects.</returns>
		public override IEnumerable<TestCase> Convert(DataTable data)
		{
			Log.TRACE();

			IEnumerable<string> testCaseColNames = GetTestCaseColName(data);
			IEnumerable<TestCase> testCases = GetTestCases(data, testCaseColNames);

			return testCases;
		}

		/// <summary>
		/// Get table configuration.
		/// </summary>
		/// <returns>Test case table configuration in tuple data type.</returns>
		/// <exception cref="InvalidDataException">Test case table configuration invalid.</exception>
		public override (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig()
		{
			Log.TRACE();

			TestConfigurationElement? config = TestConfiguration.Get().TestCase;
			if (null != config)
			{
				return (config.Name,
					config.RowOffset ?? -1, config.ColOffset ?? -1,
					config.RowSize ?? -1, config.ColSize ?? -1);
			}
			else
			{
				Log.WARN("Test case table configuration not found.");

				throw new InvalidDataException();
			}
		}

		/// <summary>
		/// Get test case number in column header in the table.
		/// </summary>
		/// <param name="data">Test case table.</param>
		/// <returns>Collection of test case number.</returns>
		protected virtual IEnumerable<string> GetTestCaseColName(DataTable data)
		{
			Log.TRACE();

			List<string> testCaseColNames = new List<string>();
			foreach (DataColumn column in data.Columns)
			{
				int testCaseNum = -1;
				string colName = column.ColumnName;

				Log.DEBUG($"{nameof(colName),12} = {colName}");

				bool canParse = int.TryParse(colName, out testCaseNum);
				if (canParse)
				{
					testCaseColNames.Add(colName);
				}
			}

			return testCaseColNames;
		}

		/// <summary>
		/// Get test case in collection of TestCase objects.
		/// </summary>
		/// <param name="data">Test case table.</param>
		/// <param name="testCaseNames">Collection of test case.</param>
		/// <returns>Collection of TestCase object.</returns>
		protected virtual IEnumerable<TestCase> GetTestCases(DataTable data, IEnumerable<string> testCaseNames)
		{
			Log.TRACE();

			List<TestCase> testCases = new List<TestCase>();
			foreach (string testCaseName in testCaseNames)
			{
				TestCase testCase = GetTestCase(data, testCaseName);
				testCases.Add(testCase);
			}

			return testCases;
		}

		/// <summary>
		/// Get Test case, TestCase object, from DataTable.
		/// </summary>
		/// <param name="data">DataTable to get from.</param>
		/// <param name="testCaseName">Test case name.</param>
		/// <returns>Test case data specified by testCaseName.</returns>
		protected virtual TestCase GetTestCase(DataTable data, string testCaseName)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(testCaseName),12} = {testCaseName}");

			DataTable testCaseTable = data.AsEnumerable()
				.Where(_ => _[testCaseName].ToString() == "A")
				.CopyToDataTable();

			IEnumerable<TestData> inputs = GetTestData(testCaseTable, "入力");
			IEnumerable<TestData> expects = GetTestData(testCaseTable, "期待値");
			var testCase = new TestCase()
			{
				Name = testCaseName,
				Inputs = inputs,
				Expects = expects,
			};
			return testCase;
		}

		/// <summary>
		/// Get test data, input or expects from DataTable.
		/// </summary>
		/// <param name="testCaseTable">Test case </param>
		/// <param name="inOutType"></param>
		/// <returns></returns>
		protected IEnumerable<TestData> GetTestData(DataTable testCaseTable, string inOutType)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(inOutType),12} = {inOutType}");

			List<TestData> testDatas = new List<TestData>();
			IEnumerable<DataRow> testCaseRows = testCaseTable.AsEnumerable().Where(_ => _["入力/期待値"].ToString() == inOutType);
			foreach (DataRow row in testCaseRows)
			{
				TestData testData = Row2TestData(row);
				testDatas.Add(testData);
			}

			return testDatas;
		}

		/// <summary>
		/// Convert DataRow object into TestData object.
		/// </summary>
		/// <param name="row">DataRow object to convert.</param>
		/// <returns>DataRow object.</returns>
		protected virtual TestData Row2TestData(DataRow row)
		{
			Log.TRACE();

			string condition = Extract.AsString(row, "入力/期待値");
			string description = Extract.AsString(row, "条件");
			string varName = Extract.AsString(row, "変数名");
			string varValue = Extract.AsString(row, "代表値");

			var testData = new TestData()
			{
				Condition = condition,
				Description = description,
				Name = varName,
				Value = varValue
			};

			Log.DEBUG($"{"入力/期待値",12} = {condition}, {"変数名",12} = {varName}, {"代表値",12} = {varValue}");

			return testData;
		}
	}
}
