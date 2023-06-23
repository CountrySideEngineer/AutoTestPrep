using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Data;

namespace TestParser.Converter.Test
{
	class TestDataConverter : AContentConverter
	{
		string _inputExpectColName = string.Empty;
		string _conditionColName = string.Empty;
		string _variableColName = string.Empty;
		string _valueColName = string.Empty;

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected TestDataConverter() { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		public TestDataConverter(
			string inputExpectColName,
			string conditionColName,
			string variableColName,
			string valueColName)
		{
			_inputExpectColName = inputExpectColName;
			_conditionColName = conditionColName;
			_variableColName = variableColName;
			_valueColName = valueColName;
		}

		public override object Convert(DataTable src)
		{
			var testDatas = new List<TestData>();
			for (int index = 0; index < src.Rows.Count; index++)
			{
				DataRow row = src.Rows[index];
				TestData testData = Convert(row);
				testDatas.Add(testData);
			}
			return testDatas;

		}

		protected virtual TestData Convert(DataRow src)
		{
			TRACE($"{nameof(Convert)} in {nameof(TestDataConverter)} called.");

			string condition = Extract.AsString(src, _inputExpectColName);
			string description = Extract.AsString(src, _conditionColName, string.Empty);
			string name = Extract.AsString(src, _variableColName);
			string testValue = Extract.AsString(src, _valueColName);

			var testData = new TestData()
			{
				Condition = condition,
				Descriotion = description,
				Name = name,
				Value = testValue
			};
			return testData;
		}
	}
}
