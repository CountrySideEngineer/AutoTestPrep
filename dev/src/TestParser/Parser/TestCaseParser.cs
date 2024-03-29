﻿using System;
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
			TRACE($"{nameof(GetConverter)} in {nameof(TestCaseParser)} called.");

			var converter = new TestConverter(Config);
			return converter;
		}

		/// <summary>
		/// Return test case table name.
		/// </summary>
		/// <returns>Test case table name.</returns>
		protected override string GetTableName()
		{
			TRACE($"{nameof(GetTableName)} in {nameof(TestCaseParser)} called.");

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
			TRACE($"{nameof(Read)} in {nameof(TestCaseParser)} called.");

			INFO($"Start reading table \"{GetTableName()}\" in \"{Target}\" sheet.");

			object readItems = base.Read(stream);

			INFO($"Stop reading table \"{GetTableName()}\" in \"{Target}\" sheet.");

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
			TRACE($"{nameof(OutputToLog)} in {nameof(TestCaseParser)} called.");

			try
			{
				IEnumerable<TestCase> testCases = (IEnumerable<TestCase>)readItems;

				INFO($"Get {testCases.Count()} test case(s) from \"{GetTableName()}\"");

#if DEBUG
				int itemIndex = 1;
				foreach (var testCase in testCases)
				{
					DEBUG($"\t\tTest case {itemIndex}:");
					DEBUG($"\t\t\tInput(s)  = {testCase.Input.Count()}");
					int inputIndex = 1;
					foreach (var inputItem in testCase.Input)
					{
						DEBUG($"\t\t\tInput {inputIndex} : {inputItem.Name} = {inputItem.Value}:");
						inputIndex++;
					}

					DEBUG($"\t\t\tExpect(s) = {testCase.Expects.Count()}");
					int expectIndex = 1;
					foreach (var expectItem in testCase.Expects)
					{
						DEBUG($"\t\t\tExepct {expectIndex} : {expectItem.Name} = {expectItem.Value}:");
						expectIndex++;
					}
					itemIndex++;
				}
#endif
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
