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

namespace TestParser.Parser
{
	public class FunctionParser : ATestParser
	{
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
		public FunctionParser() : base() { }

		/// <summary>
		/// Constructor with argument, target sheet name.
		/// </summary>
		/// <param name="targe">Target sheet name.</param>
		public FunctionParser(string targe) : base(targe) { }

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
	}
}
