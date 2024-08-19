using Logger;
using TableReader.ClosedXML;
using TableReader.Interface;
using TableRange = TableReader.TableData.Range;
using TestReader.Reader;
using TestReader.Config;
using System.Data;
using TestReader.Converter;

namespace TestReader.Reader
{
	public abstract class ATableReader<T> : IReader<T>, IConfiguration, ITableConverter<T>
	{
		public abstract T Convert(DataTable data);

		public abstract (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig();

		/// <summary>
		/// Read table.
		/// </summary>
		/// <param name="name">Table name to read.</param>
		/// <returns>Read data.</returns>
		/// <exception cref="NotSupportedException"></exception>
		public virtual T Read(string name)
		{
			Log.TRACE();

			Log.FATAL($"{nameof(Read)} is not supported.");

			throw new NotSupportedException();
		}

		/// <summary>
		/// Read table.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <returns>Read data.</returns>
		/// <exception cref="NotSupportedException"></exception>
		public virtual T Read(Stream stream)
		{
			Log.TRACE();

			Log.FATAL($"{nameof(Read)} is not supported.");

			throw new NotSupportedException();
		}

		/// <summary>
		/// Read table.
		/// </summary>
		/// <param name="path">Path to file to read from.</param>
		/// <param name="sheetName">Sheet name to read.</param>
		/// <returns>Read data.</returns>
		public virtual T Read(string path, string sheetName)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(path),12} = {path}");
			Log.DEBUG($"{nameof(sheetName),12} = {sheetName}");

			using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

			T tableData = Read(stream, sheetName);

			return tableData;
		}

		/// <summary>
		/// Read table.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <param name="sheetName">Sheet name to read.</param>
		/// <returns>Read data.</returns>
		public virtual T Read(Stream stream, string sheetName)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(sheetName),12} = {sheetName}");

			ITableReader tableReader = GetReader(stream, sheetName);
			(string tableName, TableRange range) = GetTableRange();

			Log.DEBUG($"{nameof(tableName),12} = {tableName}");
			Log.DEBUG($"{nameof(range.StartRow),12} = {range.StartRow}");
			Log.DEBUG($"{nameof(range.StartColumn),12} = {range.StartColumn}");
			Log.DEBUG($"{nameof(range.RowCount),12} = {range.RowCount}");
			Log.DEBUG($"{nameof(range.ColumnCount),12} = {range.ColumnCount}");

			DataTable dataInTable = tableReader.Read(tableName, range);
			T data = Convert(dataInTable);

			return data;
		}

		/// <summary>
		/// Get table name and its size to read.
		/// </summary>
		/// <returns>Table name and table size as tuple.</returns>
		protected virtual (string name, TableRange range) GetTableRange()
		{
			Log.TRACE();

			(string tableName, int rowOffset, int colOffset, int rowSize, int colSize) = GetConfig();

			Log.DEBUG($"{nameof(tableName),12} = {tableName}");
			Log.DEBUG($"{nameof(rowOffset),12} = {rowOffset}");
			Log.DEBUG($"{nameof(colOffset),12} = {colOffset}");
			Log.DEBUG($"{nameof(rowSize),12} = {rowSize}");
			Log.DEBUG($"{nameof(colSize),12} = {colSize}");

			TableRange range = new TableRange()
			{
				StartRow = -1,
				StartColumn = -1,
				RowCount = rowOffset,
				ColumnCount = colOffset
			};
			return (tableName, range);
		}

		/// <summary>
		/// Get reader to read table.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <returns>ITableReader object.</returns>
		internal ITableReader GetReader(Stream stream, string sheetName)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(sheetName),12} = {sheetName}");

			ITableReader reader = new ExcelTableReader(stream)
			{
				SheetName = sheetName
			};
			return reader;
		}
	}
}
