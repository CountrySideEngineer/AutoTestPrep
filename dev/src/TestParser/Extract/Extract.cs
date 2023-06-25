using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser
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
			try
			{
				string content = src[colIndex].ToString();
				return content;
			}
			catch (Exception ex)
			when ((ex is IndexOutOfRangeException) ||
				(ex is InvalidCastException))
			{
				throw;
			}
			catch (NullReferenceException)
			{
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
			try
			{
				string content = AsString(src, colIndex);
				return content;
			}
			catch (IndexOutOfRangeException)
			{
				return defaultContent;
			}
		}

		public static string AsString(DataRow src, string colName)
		{
			try
			{
				string content = src[colName].ToString();
				return content;
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is InvalidCastException))
			{
				throw;
			}
			catch (NullReferenceException)
			{
				throw new ArgumentNullException();
			}
		}

		public static string AsString(DataRow src, string colName, string defaultContent)
		{
			try
			{
				string content = AsString(src, colName);
				return content;
			}
			catch (ArgumentException)
			{
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
			try
			{
				int content = Convert.ToInt32(src[colIndex].ToString());
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
