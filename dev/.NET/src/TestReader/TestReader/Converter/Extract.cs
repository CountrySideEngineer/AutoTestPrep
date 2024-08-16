using System.Data;
using System.Data.Common;
using Logger;

namespace TestReader.Converter
{
	public static class Extract
	{
		/// <summary>
		/// Convert the value of the specified column by argument colIndex of a row as string data type.
		/// </summary>
		/// <param name="src">DataRow type value to be converted.</param>
		/// <param name="colIndex">Column index.</param>
		/// <returns>Content in the row at column, colIndex as string data type.</returns>
		/// <exception cref="IndexOutOfRangeException"></exception>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static string AsString(DataRow src, int colIndex)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(colIndex),12} = {colIndex}");

			try
			{
				string content = src[colIndex].ToString() ?? string.Empty;

				Log.DEBUG($"{nameof(content),12} = {content}");

				return content;
			}
			catch (Exception ex)
			when ((ex is IndexOutOfRangeException) ||
				(ex is InvalidCastException))
			{
				Log.FATAL($"The column index {colIndex} is invalid.");

				throw;
			}
			catch (NullReferenceException)
			{
				Log.FATAL("Row data is null.");

				throw new ArgumentNullException();
			}
		}

		/// <summary>
		/// Convert the value of the specified column by argument colIndex of a row as string data type.
		/// </summary>
		/// <param name="src">DataRow type value to be converted.</param>
		/// <param name="colIndex">Column index.</param>
		/// <param name="defaultContent">Default content when the argument colIndex is out of range column.</param>
		/// <returns>Content in the row at column, colIndex as string data type.</returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		public static string AsString(DataRow src, int colIndex, string defaultContent)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(colIndex),16} = {colIndex}");
			Log.DEBUG($"{nameof(defaultContent),16} = {defaultContent}");

			try
			{
				string content = AsString(src, colIndex);
				return content;
			}
			catch (IndexOutOfRangeException)
			{
				Log.WARN($"The index of column, {nameof(colIndex)} = {colIndex}, is invalid. Check the table format.");

				return defaultContent;
			}
		}

		public static string AsString(DataRow src, string colName)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(colName),16}] = {colName}");

			try
			{
				string content = src[colName].ToString();
				return content;
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is InvalidCastException))
			{
				Log.FATAL($"The column named \"{colName}\" is invalid.");

				throw;
			}
			catch (NullReferenceException)
			{
				Log.FATAL("Row data is null.");

				throw new ArgumentNullException();
			}
		}

		public static string AsString(DataRow src, string colName, string defaultContent)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(colName),16} = {colName}");
			Log.DEBUG($"{nameof(defaultContent),16} = {defaultContent}");

			try
			{
				string content = AsString(src, colName);
				return content;
			}
			catch (ArgumentException)
			{
				Log.INFO($"Convert failed and use default content, \"{defaultContent}\".");

				return defaultContent;
			}
		}

		/// <summary>
		/// Convert the value of the specified column by argument colIndex of a row as int, Int32 type.
		/// </summary>
		/// <param name="src">DataRow type value to be converted.</param>
		/// <param name="colIndex">Column index.</param>
		/// <returns>Converted value.</returns>
		/// <exception cref="IndexOutOfRangeException"></exception>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="FormatException"></exception>
		public static int AsInt32(DataRow src, int colIndex)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(colIndex),16} = {colIndex}");

			try
			{
				int content = Convert.ToInt32(src[colIndex].ToString());

				Log.DEBUG($"{nameof(content),16} = {content}");

				return content;
			}
			catch (Exception ex)
			when ((ex is IndexOutOfRangeException) ||
				(ex is OverflowException) ||
				(ex is FormatException))
			{
				throw;
			}
		}

		/// <summary>
		/// Convert the value of the specified column by argument colIndex of a row as int, Int32 type.
		/// </summary>
		/// <param name="src">DataRow type value to be converted.</param>
		/// <param name="colIndex">Column index.</param>
		/// <returns>Converted value.</returns>
		/// <exception cref="OverflowException"></exception>
		/// <exception cref="FormatException"></exception>
		public static int AsInt32(DataRow src, int colIndex, int defaultValue)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(colIndex),16} = {colIndex}");
			Log.DEBUG($"{nameof(defaultValue),16} = {defaultValue}");

			try
			{
				int theValue = AsInt32(src, colIndex);
				return theValue;
			}
			catch (IndexOutOfRangeException)
			{
				return defaultValue;
			}
		}
	}
}
