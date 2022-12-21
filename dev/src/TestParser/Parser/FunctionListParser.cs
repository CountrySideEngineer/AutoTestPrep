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
		/// Default constructor
		/// </summary>
		public FunctionListParser() : base() { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="target">Function list parser sheet name in excel.</param>
		public FunctionListParser(string target) : base(target) { }

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
			TestParserConfig testParserConfig = TestParserConfig.LoadConfig();
			var tableName = testParserConfig.TestFunctoinListTable.Title;

			return tableName;
		}
	}
}
