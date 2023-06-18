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
				var tableContent = new List<ParameterInfo>();
				for (int index = 0; index < src.Rows.Count; index++)
				{
					try
					{
						DataRow rowData = src.Rows[index];
						ParameterInfo paramInfo = Convert(rowData);

						tableContent.Add(paramInfo);
					}
					catch (FormatException)
					{
						ERROR($"Input data can not convert, skip row {index}");
					}
				}
				return tableContent;
			}
			catch (OverflowException)
			{
				ERROR("Input data is too large to convert.");
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
				int index = Extract.AsInt32(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_NO);
				string name = Extract.AsString(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_NAME);
				string sheetName = Extract.AsString(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SHEET_NAME);
				string fileName = Extract.AsString(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_NAME, string.Empty);
				string filePath = Extract.AsString(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_PATH, string.Empty);

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
			catch (Exception ex)
			when ((ex is ArgumentNullException) ||
				(ex is FormatException) ||
				(ex is OverflowException))
			{
				throw;
			}
		}
	}
}
