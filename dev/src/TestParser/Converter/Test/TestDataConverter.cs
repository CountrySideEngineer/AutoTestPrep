using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Data;

namespace TestParser.Converter.Test
{
	class TestDataConverter : IContentConverter
	{
		enum TEST_DATA_TABLE_INDEX {
			COL_CONDITION = 0,
			COL_DESCRIPTION,
			COL_VARIABLE_NAME,
			COL_RANGE,
			COL_REPRESENTATIVE_VALUE,
			COL_MAX
		};

		public IEnumerable<int> Indexes { get; set; }

		string _expectName = string.Empty;
		string _returnName = string.Empty;
		string _returnVariableName = string.Empty;

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected TestDataConverter()
		{
			Indexes = null;
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="indexes">Index data to convert.</param>
		public TestDataConverter(
			string expectName, 
			string returnName,
			string returnVariableName)
		{
			_expectName = expectName;
			_returnName = returnName;
			_returnVariableName = returnVariableName;

			Indexes = null;
		}

		public object Convert(Content src)
		{
			var testDatas = new List<TestData>();
			foreach (var item in Indexes)
			{
				TestData testData = Convert(src, item);
				testDatas.Add(testData);
			}
			return testDatas;
		}

		protected TestData Convert(Content src, int index)
		{
			IEnumerable<string> content = src.GetContentsInRow(index);
			string condition = content.ElementAt((int)TEST_DATA_TABLE_INDEX.COL_CONDITION);
			string description = content.ElementAt((int)TEST_DATA_TABLE_INDEX.COL_DESCRIPTION);
			string name = string.Empty;
			if ((condition.Equals(_expectName)) && (description.Equals(_returnName)))
			{
				name = _returnVariableName;
			}
			else
			{
				name = content.ElementAt((int)TEST_DATA_TABLE_INDEX.COL_VARIABLE_NAME);
			}
			string theValue = content.ElementAt((int)TEST_DATA_TABLE_INDEX.COL_REPRESENTATIVE_VALUE);

			var testData = new TestData()
			{
				Condition = condition,
				Descriotion = description,
				Name = name,
				Value = theValue
			};
			return testData;
		}
	}
}
