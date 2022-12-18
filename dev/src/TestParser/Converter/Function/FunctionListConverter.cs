using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Target;

namespace TestParser.Converter.Function
{
	public class FunctionListConverter : IContentConverter
	{
		protected enum FUNC_LIST_TABLE_COL_INDEX : int
		{
			COL_INDEX_NO,
			COL_INDEX_TEST_NAME,
			COL_INDEX_TEST_SHEET_NAME,
			COL_INDEX_TEST_SRC_FILE_NAME,
			COL_INDEX_TEST_SRC_FILE_PATH,
		};

		/// <summary>
		/// Convert function list table content to collection of ParameterInfo object.
		/// </summary>
		/// <param name="src">Function list table content.</param>
		/// <returns>Collection of Parameter info object parsed from table content.</returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object Convert(Content src)
		{
			try
			{
				int rowCount = src.GetContentsInCol(0).Count();
				var tableContent = new List<ParameterInfo>();
				for (int index = 0; index < rowCount; index++)
				{
					IEnumerable<string> rowData = src.GetContentsInRow(index);
					ParameterInfo paramInfo = Convert(rowData);

					tableContent.Add(paramInfo);
				}

				return tableContent;
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Convert a row data in function list table to ParameterInfo object.
		/// </summary>
		/// <param name="src">A row data in function list table.</param>
		/// <returns>ParameterInfo object a row data converted.</returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		protected ParameterInfo Convert(IEnumerable<string> src)
		{
			try
			{
				string indexValue = src.ElementAt((int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_NO);
				int index = System.Convert.ToInt32(indexValue);

				string name = src.ElementAt((int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_NAME);

				string sheetName = src.ElementAt((int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SHEET_NAME);

				string fileName = src.ElementAt((int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_NAME);

				string filePath = string.Empty;
				try
				{
					filePath = src.ElementAt((int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_PATH);
				}
				catch (Exception ex)
				when ((ex is ArgumentException) || (ex is ArgumentOutOfRangeException))
				{
					filePath = string.Empty;
				}

				var paramInfo = new ParameterInfo()
				{
					Index = index,
					Name = name,
					InfoName = sheetName,
					FileName = fileName,
					FilePath = filePath,
				};
				return paramInfo;
			}
			catch (NullReferenceException)
			{
				throw;
			}
			catch (ArgumentOutOfRangeException)
			{
				throw;
			}
		}
	}
}
