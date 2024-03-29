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
using TableReader.TableData;
using TestParser.ParserException;
using System.Security;
using TableReader.Interface;
using TestParser.Converter;
using TestParser.Converter.Function;

namespace TestParser.Parser
{
	/// <summary>
	/// Parse function info in a test design file.
	/// </summary>
	public class FunctionListParser : ATestParser
	{
		/// <summary>
		/// Configuration field of functin list table parser.
		/// </summary>
		protected TableConfig _config;

		/// <summary>
		/// Configuration of function list table parser.
		/// </summary>
		public TableConfig Config
		{
			get
			{
				if (null == _config)
				{
					_config = TestParserConfig.LoadConfig().TestFunctionListTable;
				}
				return _config;
			}
			set
			{
				_config = value;
			}
		}

		/// <summary>
		/// Default constructor
		/// </summary>
		public FunctionListParser() : base()
		{
			Config = null;
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="target">Function list sheet name in excel.</param>
		public FunctionListParser(string target) : base(target)
		{
			Config = null;
		}

		/// <summary>
		/// Constructor with arguments, parser configuration.
		/// </summary>
		/// <param name="config"></param>
		public FunctionListParser(TableConfig config)  : base()
		{
			Config = config;
		}

		/// <summary>
		/// Returns obejcet IContentConverter interface derived and implemented.
		/// </summary>
		/// <returns>Converter to convert function list table.</returns>
		public override IContentConverter GetConverter()
		{
			TRACE($"{nameof(GetConverter)} in {nameof(FunctionListParser)} called.");

			var converter = new FunctionListConverter();
			return converter;
		}

		/// <summary>
		/// Returns function list table name.
		/// </summary>
		/// <returns>Function list table name.</returns>
		protected override string GetTableName()
		{
			TRACE($"{nameof(GetTableName)} in {nameof(FunctionListParser)} called.");

			string tableName = Config.Title;
			return tableName;
		}

		/// <summary>
		/// Read function list table.
		/// </summary>
		/// <param name="stream">Stream to read</param>
		/// <returns>Collection of ParameterInfo object.</returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="System.Exception"></exception>
		protected override object Read(Stream stream)
		{
			TRACE($"{nameof(Read)} in {nameof(FunctionListParser)} called.");

			INFO($"Start reading table \"{GetTableName()}\" in \"{Target}\" sheet.");

			object readItems = base.Read(stream);

			INFO($"Stop reading table \"{GetTableName()}\" in \"{Target}\" sheet.");

			OutputToLog(readItems);

			return readItems;
		}

		/// <summary>
		/// Output items data read from stream into log.
		/// </summary>
		/// <param name="readItems">Items read from from stream.</param>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="System.Exception"></exception>
		protected virtual void OutputToLog(object readItems)
		{
			TRACE($"{nameof(OutputToLog)} in {nameof(FunctionListParser)} called.");

			try
			{
				var paramInfos = (IEnumerable<ParameterInfo>)readItems;

				INFO($"\tGet {paramInfos.Count()} function information(s) in the table.");
#if DEBUG
				int itemIndex = 1;
				foreach (var item in paramInfos)
				{
					DEBUG($"\t\tFunction info {itemIndex}:");
					DEBUG($"\t\t       Index : {item.Index}");
					DEBUG($"\t\t        Name : {item.Name}");
					DEBUG($"\t\t    InfoName : {item.InfoName}");
					DEBUG($"\t\t    FileName : {item.FileName}");

					itemIndex++;
				}
#endif
			}
			catch (System.Exception ex)
			when ((ex is InvalidCastException) ||
				(ex is NullReferenceException))
			{
				FATAL("FunctionList object data type invalid.");
				throw;
			}
			catch (System.Exception ex)
			{
				FATAL($"Unknown exception has been raised while reading function list.");
				FATAL($"The exceptino is {ex.GetType()}");

				throw;
			}
		}
	}
}
