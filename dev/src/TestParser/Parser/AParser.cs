using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using CSEngineer.Logger;
using TableReader.ExcelDataReader;
using TableReader.Interface;
using TestParser.Config;
using TestParser.ParserException;
using TestParser.Reader;

namespace TestParser.Parser
{
	public abstract class AParser : IParser, CSEngineer.Logger.Interface.ILog
	{
		/// <summary>
		/// Delegate to notify progress of parsing test.
		/// </summary>
		/// <param name="stage">Parse stage name.</param>
		/// <param name="messgae">Message</param>
		/// <param name="numerator">Progress numerator</param>
		/// <param name="denominator">Progress denominator</param>
		public delegate void NotifyParseProgress(int numerator, int denominator);
		public NotifyParseProgress NotifyParseProgressDelegate;

		public delegate void NotifyProcessAndProgress(string procName, int numerator, int denominator);
		public NotifyProcessAndProgress NotifyProcessAndProgressDelegate;

		/// <summary>
		/// Target name to parse.
		/// </summary>
		public string Target { get; set; }

		protected TableConfig _tableConfig;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AParser()
		{
			Target = string.Empty;
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="target">Target name to parse.</param>
		public AParser(string target)
		{
			Target = target;
		}

		/// <summary>
		/// Abstract function to read function.
		/// </summary>
		/// <param name="path">Paht to file designing test.</param>
		/// <returns>Object about test.</returns>
		public virtual object Parse(string path)
		{
			TRACE($"{nameof(Parse)} in {nameof(AParser)} called.");

			try
			{
				INFO($"Start parsing file : {path}");
				using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					DEBUG($"{path} opened.");
					DEBUG($"Start reading file : {path}");
					object parsedObj = Parse(stream);

					return parsedObj;
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
				(ex is SecurityException) ||
				(ex is DirectoryNotFoundException) ||
				(ex is PathTooLongException))
			{
				ERROR($"File path {path} is invalid.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
			catch (SecurityException)
			{
				ERROR($"File {path} can not access.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
			catch (System.Exception ex)
			when ((ex is NotSupportedException) || (ex is ArgumentOutOfRangeException))
			{
				ERROR($"File path {path} is not supported.");
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_FILE_CAN_NOT_OPEN);
			}
		}

		/// <summary>
		/// Abstract function to read function.
		/// </summary>
		/// <param name="path">Stream to read from data to parse.</param>
		/// <returns>Object about test.</returns>
		public virtual object Parse(Stream stream)
		{
			TRACE($"{nameof(Parse)} in {nameof(AParser)} called.");

			object readObject = Read(stream);

			return readObject;
		}

		protected abstract object Read(Stream stream);

		public void TRACE(string message)
		{
#if DEBUG
			var logger = Log.GetInstance();
			logger.TRACE(message);
#endif
		}

		public void DEBUG(string message)
		{
#if DEBUG
			var logger = Log.GetInstance();
			logger.DEBUG(message);
#endif
		}

		public void INFO(string message)
		{
			var logger = Log.GetInstance();
			logger.INFO(message);
		}

		public void WARN(string message)
		{
			var logger = Log.GetInstance();
			logger.WARN(message);
		}

		public void ERROR(string message)
		{
			var logger = Log.GetInstance();
			logger.ERROR(message);
		}

		public void FATAL(string message)
		{
			var logger = Log.GetInstance();
			logger.FATAL(message);
		}

		/// <summary>
		/// Returns an object to read table, which implements ITableReader interface.
		/// </summary>
		/// <param name="stream">Stream to file to read table.</param>
		/// <returns>An object to read table.</returns>
		/// <exception cref="InvalidDataException">Sheet name to read is null, empty, or all white space.</exception>
		protected virtual ITableReader GetReader(Stream stream)
		{
			TRACE($"{nameof(GetReader)} in {nameof(AParser)} called.");

			if (string.IsNullOrEmpty(Target) || (string.IsNullOrWhiteSpace(Target)))
			{
				throw new InvalidDataException();
			}
			var reader = new ExcelTableReader(stream, Target);
			return reader;
		}

		protected virtual string ItemConverter(IEnumerable<string> src, int index)
		{
			TRACE($"{nameof(ItemConverter)} in {nameof(AParser)} called.");

			try
			{
				string item = src.ElementAt(index);
				if ((string.IsNullOrEmpty(item)) || (string.IsNullOrWhiteSpace(item)))
				{
					throw new ArgumentException();
				}
				return item;
			}
			catch (ArgumentOutOfRangeException)
			{
				throw;
			}
		}
	}
}
