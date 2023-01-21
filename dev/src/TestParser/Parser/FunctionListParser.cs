using System;
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
		/// <param name="target">Function list parser sheet name in excel.</param>
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
			var converter = new FunctionListConverter();
			return converter;
		}

		/// <summary>
		/// Returns function list table name.
		/// </summary>
		/// <returns>Function list table name.</returns>
		protected override string GetTableName()
		{
			string tableName = Config.Title;
			return tableName;
		}

		/// <summary>
		/// Read function list table.
		/// </summary>
		/// <param name="stream">Stream to read</param>
		/// <returns>Collection of ParameterInfo object.</returns>
		protected override object Read(Stream stream)
		{
			INFO($"Start reading table \"{GetTableName()}\" in {Target}.");

			object readItems = base.Read(stream);

			try
			{
				var paramInfos = (IEnumerable<ParameterInfo>)readItems;

				INFO($"Get {paramInfos.Count()} function information in the table.");

				int itemIndex = 1;
				foreach (var item in paramInfos)
				{
					INFO($"Function info {itemIndex}:");
					INFO($"    Index    = {item.Index}");
					INFO($"    Name     = {item.Name}");
					INFO($"    InfoName = {item.InfoName}");
					INFO($"    FileName = {item.FileName}");
					itemIndex++;
				}
			}
			catch (InvalidCastException)
			{
				DEBUG("FunctionList object data type invalid.");
				DEBUG("Skip data output.");
			}
			return base.Read(stream);
		}
	}
}
