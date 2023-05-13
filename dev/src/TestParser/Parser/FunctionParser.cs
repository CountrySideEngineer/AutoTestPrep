using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSEngineer;
using CSEngineer.TestSupport.Utility;
using TestParser.Reader;
using TestParser;
using TestParser.Target;
using TestParser.ParserException;
using TestParser.Config;
using TestParser.Converter;
using TableReader.Excel;
using TableReader.TableData;
using System.Security;
using TableReader.Interface;

namespace TestParser.Parser
{
	public class FunctionParser : ATestParser
	{
		/// <summary>
		/// Configuration field of functin table parser.
		/// </summary>
		protected FunctionTableConfig _config;

		/// <summary>
		/// Configuration of target function table parser.
		/// </summary>
		public FunctionTableConfig Config
		{
			get
			{
				if (null == _config)
				{
					_config = TestParserConfig.LoadConfig().FunctionTable;
				}
				return _config;
			}
			set
			{
				_config = value;
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FunctionParser() : base()
		{
			Config = null;
		}

		/// <summary>
		/// Constructor with argument, target sheet name.
		/// </summary>
		/// <param name="targe">Target sheet name.</param>
		public FunctionParser(string targe) : base(targe)
		{
			Config = null;
		}

		/// <summary>
		/// Constructor with arguments, parsing configuration.
		/// </summary>
		/// <param name="config"></param>
		public FunctionParser(FunctionTableConfig config) : base()
		{
			Config = config;
		}

		/// <summary>
		/// Returns object IContentConverter interface derived and implemented.
		/// </summary>
		/// <returns>Converter to convert function data read from function table.</returns>
		public override IContentConverter GetConverter()
		{
			var converter = new Converter.Function.FunctionConverter(Config);
			return converter;
		}

		/// <summary>
		/// Returns table name.
		/// </summary>
		/// <returns>Function table name.</returns>
		protected override string GetTableName()
		{
			string tableName = Config.Title;
			return tableName;
		}

		/// <summary>
		/// Read function data from table.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <returns>Function object read from table in stream.</returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="System.Exception"></exception>
		protected override object Read(Stream stream)
		{
			try
			{
				INFO($"Start reading table \"{GetTableName()}\" in \"{Target}\".");

				var readItem = base.Read(stream);

				OutputToLog(readItem);

				return readItem;
			}
			catch (InvalidCastException)
			{
				FATAL("Function talbe object data type invalid.");

				throw;
			}
		}

		/// <summary>
		/// Output function data read from stream into log.
		/// </summary>
		/// <param name="readItem">Item read from stream.</param>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="System.Exception"></exception>
		protected virtual void OutputToLog(object readItem)
		{
			try
			{
				Function function = (Function)readItem;

				INFO("Get the function below in the table:");
				INFO($"\t{function.ToString()}");
			}
			catch (Exception ex)
			when ((ex is InvalidCastException) ||
				(ex is NullReferenceException))
			{
				FATAL("Function talbe object data type invalid.");

				throw;
			}
			catch (System.Exception ex)
			{
				FATAL($"Unknown exception has been raised while reading function list.");
				FATAL($"The exceptino is {ex.GetType()}");
			}
		}

	}
}
