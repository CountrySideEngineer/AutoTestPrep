using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSEngineer;
using TestParser.Parser;
using TestParser.Reader;
using TestParser.Data;
using TestParser.Config;
using TestParser.ParserException;
using TableReader.TableData;
using TableReader.Excel;
using TestParser.Converter;

namespace TestParser.Parser
{
	public class TestCaseParser : ATestParser
	{
		public TestCaseTableConfig Config;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestCaseParser() : base()
		{
			Config = null;
		}

		/// <summary>
		/// Constructor with argument about sheet name to parse.
		/// </summary>
		/// <param name="target">Sheet name the test case are defined.</param>
		public TestCaseParser(string target) : base(target) { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="config">Parser configuration.</param>
		public TestCaseParser(TestCaseTableConfig config) : base()
		{
			Config = config;
		}

		/// <summary>
		/// Constructor with arguments.
		/// </summary>
		/// <param name="target">Sheet name the test case are defined.</param>
		/// <param name="config">Parser configuration.</param>
		public TestCaseParser(string target, TestCaseTableConfig config) : base(target)
		{
			Config = config;
		}

		public override IContentConverter GetConverter()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Return test case table name.
		/// </summary>
		/// <returns>Test case table name.</returns>
		protected override string GetTableName()
		{
			TestParserConfig testParserConfig = TestParserConfig.LoadConfig();
			var tableName = testParserConfig.TestCaseTable.Title;

			return tableName;
		}
	}
}
