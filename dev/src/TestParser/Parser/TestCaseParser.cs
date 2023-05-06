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
using TestParser.Converter.Test;

namespace TestParser.Parser
{
	public class TestCaseParser : ATestParser
	{
		/// <summary>
		/// Test case table configuration field.
		/// </summary>
		protected TestCaseTableConfig _config;

		/// <summary>
		/// Test case configuration property.
		/// </summary>
		public TestCaseTableConfig Config
		{
			get
			{
				if (null == _config)
				{
					_config = TestParserConfig.LoadConfig().TestCaseTable;
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
		public TestCaseParser() : base()
		{
			Config = null;
		}

		/// <summary>
		/// Constructor with argument about sheet name to parse.
		/// </summary>
		/// <param name="target">Sheet name the test case are defined.</param>
		public TestCaseParser(string target) : base(target)
		{
			Config = null;
		}

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

		/// <summary>
		/// Returns object IContentConverter interface implements.
		/// </summary>
		/// <returns>Test converter.</returns>
		public override IContentConverter GetConverter()
		{
			var converter = new TestConverter(Config);
			return converter;
		}

		/// <summary>
		/// Return test case table name.
		/// </summary>
		/// <returns>Test case table name.</returns>
		protected override string GetTableName()
		{
			string tableName = Config.Title;
			return tableName;
		}

		/// <summary>
		/// Read test data from table.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <returns>Collection of TestCase object read from table in stream.</returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="System.Exception"></exception>
		protected override object Read(Stream stream)
		{
			INFO($"Start reading table \"{GetTableName()}\" in \"{Target}\".");

			object readItems = base.Read(stream);

			OutputToLog(readItems);

			return readItems;
		}

		/// <summary>
		/// Output item datas read from stream into log.
		/// </summary>
		/// <param name="readItems">Items read from stream.</param>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="System.Exception"></exception>
		protected virtual void OutputToLog(object readItems)
		{
			try
			{
				IEnumerable<TestCase> testCases = (IEnumerable<TestCase>)readItems;

				INFO($"Get {testCases.Count()} case from the table.");
			}
			catch (System.Exception ex)
			when ((ex is InvalidCastException) ||
				(ex is NullReferenceException))
			{
				FATAL("Test case table object data type invalid.");
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
