﻿using System.Data;
using Logger;
using TestReader.Config;
using TestReader.Model;

namespace TestReader.Reader
{
	public class FunctionListReader : ATableReader<IEnumerable<TestTargetInfo>>
	{
		protected enum FUNC_LIST_TABLE_COL_INDEX : int
		{
			COL_INDEX_NO,
			COL_INDEX_TEST_NAME,
			COL_INDEX_TEST_SHEET_NAME,
			COL_INDEX_TEST_SRC_FILE_NAME,
		};

		/// <summary>
		/// Convert DataTable object contains function list into TestTargetInfo object.
		/// </summary>
		/// <param name="data">Table data as DataTable object to convert.</param>
		/// <returns>Function list as collection of TestTargetInfo object.</returns>
		public override IEnumerable<TestTargetInfo> Convert(DataTable data)
		{
			Log.TRACE();

			var testInfos = new List<TestTargetInfo>();

			foreach (DataRow row in data.Rows)
			{
				TestTargetInfo testInfo = Convert(row);
				testInfos.Add(testInfo);
			}
			return testInfos;
		}

		/// <summary>
		/// Convert row data as DataRow object into functino information 
		/// </summary>
		/// <param name="row">Row data as DataRow object to be converted.</param>
		/// <returns>Function information.</returns>
		/// <exception cref="InvalidDataException"></exception>
		public virtual TestTargetInfo Convert(DataRow row)
		{
			Log.TRACE();

			try
			{
				int index = (int)row[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_NO];
				string testName = (string)row[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_NAME];
				string sheetName = (string)row[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SHEET_NAME];
				string fileName = (string)row[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_NAME];

				var info = new TestTargetInfo()
				{
					Index = index,
					Description = testName,
					Name = sheetName,
					FileName = fileName
				};
				return info;
			}
			catch (Exception ex)
			when ((ex is IndexOutOfRangeException) || (ex is InvalidCastException))
			{
				Log.WARN("Input data invalid.");

				throw new InvalidDataException();
			}
		}

		public override (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig()
		{
			Log.TRACE();

			TestConfigurationElement? config = TestConfiguration.Get().FunctionList;
            if (null != config)
			{
				return (config.Name,
					config.RowOffset ?? -1, config.ColOffset ?? -1,
					config.RowSize ?? -1, config.ColSize ?? -1);
			}
			else
			{
				Log.WARN("Function list configuration not found.");

				throw new InvalidDataException();
			}
		}
	}
}
