using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using TestParser.Target;

namespace TestParser.Converter.Function
{
	public class FunctionListConverter : AContentConverter
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
		public override object Convert(DataTable src)
		{
			TRACE($"{nameof(Convert)} in {nameof(FunctionListConverter)} called.");

			try
			{
				int rowCount = src.Rows.Count;
				var tableContent = new List<ParameterInfo>();

				//Skip 1st row because it will be a header.
				for (int index = 1; index < rowCount; index++)
				{
					try
					{
						DataRow rowData = src.Rows[index];
						ParameterInfo paramInfo = Convert(rowData);

						tableContent.Add(paramInfo);
					}
					catch (FormatException)
					{
						//Skip format exception.
					}
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
		/// <exception cref="FormatException"></exception>
		protected ParameterInfo Convert(DataRow src)
		{
			TRACE($"{nameof(Convert)} in {nameof(FunctionListConverter)} called.");

			try
			{
				string indexValue = src[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_NO].ToString();
				int index = System.Convert.ToInt32(indexValue);
				string name = src[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_NAME].ToString();
				string sheetName = src[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SHEET_NAME].ToString();
				string fileName = src[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_NAME].ToString();
				string filePath = string.Empty;
				try
				{
					filePath = src[(int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_PATH].ToString();
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
