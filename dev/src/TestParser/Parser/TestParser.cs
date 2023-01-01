using System;
using System.IO;
using System.Collections.Generic;
using TestParser.Target;
using TestParser.Data;
using System.Linq;
using TestParser.Reader;
using TestParser.Config;
using TestParser.ParserException;
using System.Security;

namespace TestParser.Parser
{
	public class TestParser : AParser
	{
		protected TestParserConfig _testConfig;

		protected string _configFilePath;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestParser()
		{
			_testConfig = null;
			_configFilePath = @".\TestParserConfg.xml";
		}

		/// <summary>
		/// Read test data from <para>stream</para>.
		/// </summary>
		/// <param name="stream">Stream to read data from.</param>
		/// <returns>Test data read from <para>stream</para>.</returns>
		/// <exception cref="NullReferenceException">
		/// Object to parse function list, function, or test case has not been set.
		/// </exception>
		protected override object Read(Stream stream)
		{
			LoadConfig();

			IEnumerable<ParameterInfo> functionList = ReadFunctionList(stream);
			var tests = new List<Test>();
			foreach (var item in functionList)
			{
				Test test = ReadTest(stream, item);
				tests.Add(test);
			}
			return tests;
		}

		/// <summary>
		/// Read target function list datas.
		/// </summary>
		/// <param name="stream">Stream to read data.</param>
		/// <returns>Collection of ParameterInfo object about test target function.</returns>
		protected IEnumerable<ParameterInfo> ReadFunctionList(Stream stream)
		{
			try
			{
				string sheetName = _testConfig.TestFunctionListTable.Section;
				IParser parser = new FunctionListParser(sheetName);
				IEnumerable<ParameterInfo> functionList = ReadTable<IEnumerable<ParameterInfo>>(stream, parser);

				return functionList;
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Read function data.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <param name="paramInfo">Information about to read.</param>
		/// <returns>Function data read from a sheet.</returns>
		protected Function ReadFunction(Stream stream, ParameterInfo paramInfo)
		{
			string sheetName = paramInfo.InfoName;
			IParser parser = new FunctionParser(sheetName);
			Function function = ReadTable<Function>(stream, parser);

			return function;
		}

		/// <summary>
		/// Read test case.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <param name="paramInfo">Informatin about to read.</param>
		/// <returns>Collection of test case data.</returns>
		protected IEnumerable<TestCase> ReadTestCase(Stream stream, ParameterInfo paramInfo)
		{
			string sheetName = paramInfo.InfoName;
			IParser parser = new TestCaseParser(sheetName);
			IEnumerable<TestCase> testCases = ReadTable<IEnumerable<TestCase>>(stream, parser);

			return testCases;
		}

		/// <summary>
		/// Read test case data.
		/// </summary>
		/// <param name="stream">Stream data to read.</param>
		/// <param name="parameterInfo">Parameter information.</param>
		/// <returns>Tes data read from stream.</returns>
		protected Test ReadTest(Stream stream, ParameterInfo parameterInfo)
		{
			Function function = ReadFunction(stream, parameterInfo);
			IEnumerable<TestCase> testCases = ReadTestCase(stream, parameterInfo);

			Test test = new Test()
			{
				Name = parameterInfo.Name,
				Target = function,
				TestCases = testCases,
				TestInformation = parameterInfo.InfoName,
				SourceName = parameterInfo.FileName,
				SourcePath = parameterInfo.FilePath
			};
			return test;
		}

		/// <summary>
		/// Read table from tableStream using parser. 
		/// </summary>
		/// <param name="tableStream">Stream to read table from.</param>
		/// <param name="parser">Parser used to read table.</param>
		/// <returns>Object contains table data.</returns>
		protected T ReadTable<T>(Stream tableStream, IParser parser)
		{
			T content = (T)parser.Parse(tableStream);
			return content;
		}

		/// <summary>
		/// Load configuration file.
		/// </summary>
		protected void LoadConfig()
		{
			try
			{
				_testConfig = TestParserConfig.LoadConfig(_configFilePath);
			}
			catch (System.IO.FileNotFoundException)
			{
				WARN($"The test config file {_configFilePath} has not been found.");
				WARN("Load default config setting.");
				_testConfig = TestParserConfig.LoadDefaultConfig();
			}
			catch (System.Exception)
			{
				WARN("The test config file can not load.");
				WARN("    Use default config setting.");
				_testConfig = TestParserConfig.LoadDefaultConfig();
			}
			finally
			{
				//DEBUG("TestParserConfig");
				//DEBUG($"    Sheet name : {_testConfig.TestList.SheetName}");
				//DEBUG($"    Row offset : {_testConfig.TestList.TableConfig.TableTopRowOffset}");
				//DEBUG($"    Col offset : {_testConfig.TestList.TableConfig.TableTopColOffset}");
			}
		}
	}
}
