﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSEngineer;
using TestParser.Reader;
using TestParser.Target;
using TestParser.Config;
using TableReader.Excel;
using TableReader.TableData;
using TestParser.ParserException;
using System.Security;
using TableReader.Interface;

namespace TestParser.Parser
{
	/// <summary>
	/// Parse function info in a test design file.
	/// </summary>
	public class FunctionListParser : AParser
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
		/// Configuration for test list reading.
		/// </summary>
		public TestListConfig Config { get; set; }

		/// <summary>
		/// Default constructor
		/// </summary>
		public FunctionListParser() : base() { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="target">Function list parser sheet name in excel.</param>
		public FunctionListParser(string target) : base(target) { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="config"></param>
		public FunctionListParser(TestListConfig config) : base()
		{
			Config = config;
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="target">Sheet name to parser.</param>
		/// <param name="config">Parser configuration.</param>
		public FunctionListParser(string target, TestListConfig config) : base(target)
		{
			Config = config;
		}

		/// <summary>
		/// Parse function information in file <para>srcPath</para>.
		/// </summary>
		/// <param name="srcPath">Path to input file.</param>
		/// <returns>Collection of functin information to parse.</returns>
		/// <exception cref="TestParserException"></exception>
		public override object Parse(string srcPath)
		{
			try
			{
				using (var stream = new FileStream(srcPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					try
					{
						object funcInfoList = Parse(stream);
						return funcInfoList;
					}
					catch (TestParserException)
					{
						throw;
					}
				}
			}
			catch (System.Exception ex)
			when (ex is ArgumentNullException)
			{
				ERROR("No test file path has been set.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
			catch (System.Exception ex)
			when ((ex is ArgumentException) ||
				(ex is FileNotFoundException) ||
				(ex is DirectoryNotFoundException) ||
				(ex is PathTooLongException))
			{
				ERROR($"File path {srcPath} is invalid.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
			catch (SecurityException)
			{
				ERROR($"File {srcPath} can not access.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
			catch (System.Exception ex)
			when ((ex is NotSupportedException) || (ex is ArgumentOutOfRangeException))
			{
				ERROR($"File path {srcPath} is not supported.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
		}

		/// <summary>
		/// Parse function information from stream <para>stream</para>.
		/// </summary>
		/// <param name="stream">FileStream of function information.</param>
		/// <returns>Function information list.</returns>
		/// <exception cref="ParseDataNotFoundException"></exception>
		public override object Parse(Stream stream)
		{
			try
			{
				ITableReader reader = GetTableReader(stream);
				IEnumerable<ParameterInfo> funcInfoList = ReadFunctionInfo(reader);
				return funcInfoList;
			}
			catch (InvalidDataException)
			{
				FATAL("The name of sheet with the list of target functions is not specified.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_TEST_FUNCTION_LIST_SHEET_NOT_FOUND);
			}
			catch (TestParserException)
			{
				throw;
			}
		}

		/// <summary>
		/// Read function informations from 
		/// </summary>
		/// <param name="reader">Object to read test data information from excel file.</param>
		/// <returns>List of function information.</returns>
		/// <exception cref="TestParserException"></exception>
		protected IEnumerable<ParameterInfo> ReadFunctionInfo(ITableReader reader)
		{
			INFO($"Start getting target function list from \"{Target}\" sheet.");

			Range tableItemRange = GetRangeToRead(reader);

			DEBUG($"Range to read;");
			DEBUG($"    Start row    = {tableItemRange.StartRow}");
			DEBUG($"    Start column = {tableItemRange.StartColumn}");
			DEBUG($"    Row count    = {tableItemRange.RowCount}");
			DEBUG($"    Column count = {tableItemRange.ColumnCount}");

			var infoList = ReadFunctionInfo(reader, tableItemRange);
			return infoList;
		}

		/// <summary>
		/// Read function information to read.
		/// </summary>
		/// <param name="reader">ExcelTableReader object.</param>
		/// <param name="range">Range to read.</param>
		/// <returns>Read function informations.</returns>
		/// <exception cref="TestParserException"></exception>
		public IEnumerable<ParameterInfo> ReadFunctionInfo(ITableReader reader, Range range)
		{
			var rangeToRead = new Range(range);
			var parameterInfoList = new List<ParameterInfo>();
			for (int index = 0; index < rangeToRead.RowCount; index++)
			{
				try
				{
					ParameterInfo parameterInfo = ReadFunctionInfoItem(reader, rangeToRead);

					DEBUG($"Function list item({index, 3}):");
					DEBUG($"              No = {parameterInfo.Index}");
					DEBUG($"            Name = {parameterInfo.Name}");
					DEBUG($"      Sheet name = {parameterInfo.InfoName}");
					DEBUG($"     Source name = {parameterInfo.FileName}");
					DEBUG($"     Source path = {parameterInfo.FilePath}");

					parameterInfoList.Add(parameterInfo);
				}
				catch (TestParserException ex)
				{
					if (ex.ErrorCode.Equals(TestParserException.Code.PARSER_ERROR_UNEXPECTED_ERROR_DETECTED_IN_FUNCTION_TABLE))
					{
						throw ex;
					}
					WARN($"Skip reading row {rangeToRead.StartRow} because an invalid data has been set.");
				}
				rangeToRead.StartRow++;
			}

			return parameterInfoList;
		}

		/// <summary>
		/// Get range t to read.
		/// </summary>
		/// <param name="reader">ExcelTableReader object</param>
		/// <returns>Range to read to get function information.</returns>
		protected Range GetRangeToRead(ITableReader reader)
		{
			try
			{
				Range tableNameRange = reader.FindFirstItem(Config.TableConfig.Name);

				INFO($"    Find \"{Config.TableConfig.Name}\" in \"{Target}\" sheet at ({tableNameRange.StartRow}, {tableNameRange.StartColumn}).");

				Range tableEndRange = new Range();
				reader.GetRowRange(ref tableEndRange);
				reader.GetColumnRange(ref tableEndRange);

				int startRow = tableNameRange.StartRow + Config.TableConfig.TableTopRowOffset + Config.TableConfig.RowDataOffset;
				int startColumn = tableNameRange.StartColumn + Config.TableConfig.TableTopColOffset + Config.TableConfig.ColDataOffset;
				int lastRow = tableEndRange.StartRow + tableEndRange.RowCount - 1;
				int lastColumn = tableEndRange.StartColumn + tableEndRange.ColumnCount - 1;
				int rowCount = lastRow - (startRow - 1);
				int columnCount = lastColumn - (startColumn - 1);

				if ((startRow < 1) ||
					(startColumn < 1) ||
					(lastRow < 1) || (lastRow < startRow) ||
					(lastColumn < 1) || (lastColumn < startColumn) ||
					(rowCount < 1) ||
					(columnCount < 1))
				{
					ERROR("Function list sheet or table format invalid.");
					throw new TestParserException(TestParserException.Code.PARSER_ERROR_INVALID_DATA_INPUT_IN_TEST_FUNCTION_TABLE);
				}

				Range rangeToRead = new Range()
				{
					StartRow = startRow,
					StartColumn = startColumn,
					RowCount = rowCount,
					ColumnCount = columnCount,
				};
				return rangeToRead;
			}
			catch (ArgumentException)
			{
				ERROR($"The table can not found in {Target}.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_TEST_FUNCTION_TABLE_NOT_FOUND);
			}
			catch (InvalidDataException)
			{
				FATAL("No object has no been set.");

				throw new TestParserException(TestParserException.Code.PARSER_ERROR_UNEXPECTED_ERROR_DETECTED_IN_FUNCTION_TABLE);
			}
		}

		/// <summary>
		/// Read function information 
		/// </summary>
		/// <param name="reader">Object to read test data information from excel file.</param>
		/// <param name="range">Range to read.</param>
		/// <returns><para>ParameterInfo</para> object read from excel.</returns>
		/// <exception cref="TestParserException"></exception>
		protected ParameterInfo ReadFunctionInfoItem(ITableReader reader, Range range)
		{
			try
			{
				IEnumerable<string> rowItem = reader.ReadRow(range);
				if (0 == rowItem.Count())
				{
					WARN($"No item found in row ({range.StartRow}).");
					throw new TestParserException(
						TestParserException.Code.PARSER_ERROR_INVALID_DATA_INPUT_IN_TEST_FUNCTION_TABLE);
				}
				ParameterInfo paramInfo = Item2Info(rowItem, ItemConverter);
				return paramInfo;
			}
			catch (ArgumentException)
			{
				WARN("Invalid data found in function list.");
				throw new TestParserException(
					TestParserException.Code.PARSER_ERROR_INVALID_DATA_INPUT_IN_TEST_FUNCTION_TABLE);
			}
			catch (Exception ex)
			when (
				(ex is FormatException) ||
				(ex is ArgumentOutOfRangeException))
			{
				ERROR("Invalid data found in function table.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_INVALID_DATA_INPUT_IN_TEST_FUNCTION_TABLE);
			}
		}

		/// <summary>
		/// Convert function list informatin into a ParmaeterInfo object using the specified function for conversion.
		/// </summary>
		/// <param name="src">Collection of function informatino read from the table.</param>
		/// <param name="converter">Function to convert the items.</param>
		/// <returns>Converted ParameterInfo object.</returns>
		/// <exception cref="FormatException">Input item format invalid.</exception>
		protected ParameterInfo Item2Info(IEnumerable<string> src, Func<IEnumerable<string>, int, string> converter)
		{
			try {
				string indexString = converter(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_NO);
				int index = Convert.ToInt32(indexString);
				string name = converter(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_NAME);
				string sheetName = converter(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SHEET_NAME);
				string fileName = converter(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_NAME);
				string filePath = string.Empty;
				try
				{
					filePath = converter(src, (int)FUNC_LIST_TABLE_COL_INDEX.COL_INDEX_TEST_SRC_FILE_PATH);
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
			catch (FormatException)
			{
				throw;
			}
		}
	}
}
