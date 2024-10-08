﻿using CodeGenerator;
using CodeGenerator.Data;
using CodeGenerator.Stub;
using StubDriverPlugin.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Data;
using TestParser.ParserException;

namespace StubDriverPlugin.StubCodePlugin
{
	class StubCodePluginExecute
	{
		public delegate void NotifyParseProgress(string processName, int numerator, int denominator);
		public NotifyParseProgress NotifyParseProgressDelegate;

		public delegate void NotifyPluginFinish();
		public NotifyPluginFinish NotifyPluginFinishDelegate;

		/// <summary>
		/// /Default constructor.
		/// </summary>
		public StubCodePluginExecute() { }

		/// <summary>
		/// Create stub and driver code for test.
		/// </summary>
		/// <param name="data">Plugin input data</param>
		/// <returns>Result of plugin.</returns>
		public virtual PluginOutput Execute(PluginInput data)
		{
			Debug.Assert(null != data, $"{nameof(StubDriverPlugin)}.{nameof(Execute)}, {nameof(data)}");

			string outputAbout = "Stub codes";
			PluginOutput pluginOutput = null;
			try
			{
				IEnumerable<Test> tests = ParseProcess(data);
				CreateCodeProcess(data, tests);

				pluginOutput = new PluginOutput(outputAbout, "スタブコードの生成が完了しました。");
			}
			catch (TestParserException ex)
			{
				string errorMessage =
					$"テストデータの解析中にエラーが発生しました。" +
					Environment.NewLine +
					$"エラーコード：0x{Convert.ToString(ex.ErrorCode, 16)}";
				pluginOutput = new PluginOutput(outputAbout, errorMessage);
			}
			catch (CodeGeneratorException ex)
			{
				string errorMessgae =
					$"コードの作成中にエラーが発生しました。" +
					Environment.NewLine +
					$"エラーコード：0x{Convert.ToString(ex.ErrorCode, 16)}";
				pluginOutput = new PluginOutput(outputAbout, errorMessgae);
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is ArgumentNullException))
			{
				pluginOutput = new PluginOutput(outputAbout, "スタブコードの生成中にエラーが発生しました。");
			}
			catch (Exception ex)
			when (ex is IOException)
			{
				pluginOutput = new PluginOutput(outputAbout, "指定されたファイルを開けませんでした。");
			}
			catch (Exception ex)
			{
				pluginOutput = new PluginOutput(outputAbout, $"プラグイン実行中にエラーが発生しました。\n{ex.Message}");
			}
			finally
			{
				CompleteExecute(data);
			}
			return pluginOutput;
		}

		/// <summary>
		/// Create test stub code.
		/// </summary>
		/// <param name="test">Test input data.</param>
		/// <param name="rootDirInfo">Eoor directory information.</param>
		/// <param name="config">Code configuration.</param>
		protected virtual void CreateStubCode(Test test, DirectoryInfo rootDirInfo, CodeConfiguration config)
		{
			try
			{
				var writeData = new WriteData()
				{
					Test = test,
					CodeConfig = config
				};
				CreateStubCode(rootDirInfo, writeData);
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is ArgumentNullException))
			{
				Debug.WriteLine(ex.StackTrace);

				throw;
			}
		}

		/// <summary>
		/// Create stub code.
		/// </summary>
		/// <param name="outputRootDirInfo">Directory information for output.</param>
		/// <param name="data">Write data.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		protected virtual void CreateStubCode(DirectoryInfo outputRootDirInfo, WriteData data)
		{
			try
			{
				if ((null == data.Test.Target.SubFunctions) || (data.Test.Target.SubFunctions.Count() < 1))
				{
					/*
					 * In a case that a target function has no sub function, stub codes are not needed.
					 * So, prevent the codes from creating, skip operations below.
					 */
					return;
				}
				//Create output directory.
				DirectoryInfo parentDirInfo = CreateOutputDirInfo(outputRootDirInfo, data);
				DirectoryInfo outputDirInfo = new DirectoryInfo($@"{parentDirInfo.FullName}\stub");
				Directory.CreateDirectory(outputDirInfo.FullName);

				//Create stub source file.
				string stubFileName = CreateStubFileName(data);
				string stubSourceFileName = $"{stubFileName}.cpp";
				string stubHeaderFileName = $"{stubFileName}.h";
				string stubSourceFilePath = outputDirInfo.FullName + $@"\{stubSourceFileName}";
				ICodeGenerator codeGenerator = new StubSourceGenerator()
				{
					StubHeaderFileName = stubHeaderFileName,
				};
				FileInfo outputFileInfo = new FileInfo(stubSourceFilePath);
				CreateCode(data, codeGenerator, outputFileInfo);

				//Create stub header file.
				codeGenerator = new StubHeaderGenerator();
				string stubHeaderFilePath = outputDirInfo.FullName + $@"\{stubHeaderFileName}";
				outputFileInfo = new FileInfo(stubHeaderFilePath);
				CreateCode(data, codeGenerator, outputFileInfo);
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is ArgumentNullException))
			{
				throw;
			}
		}

		/// <summary>
		/// Create code
		/// </summary>
		/// <param name="writeData">Write date</param>
		/// <param name="codeGenerator">Object to generate code.</param>
		/// <param name="fileInfo">Output file information.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		protected virtual void CreateCode(WriteData writeData, ICodeGenerator codeGenerator, FileInfo fileInfo)
		{
			string content = string.Empty;
			try
			{
				content = codeGenerator.Generate(writeData);
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is ArgumentNullException))
			{
				Debug.Write(ex.StackTrace);

				throw;
			}
			using (var stream = File.CreateText(fileInfo.FullName))
			{
				stream.Write(content);
			}
		}

		/// <summary>
		/// Parse test data and create test datas.
		/// </summary>
		/// <param name="data">Test data input.</param>
		/// <returns>Test data parsed by a parser </returns>
		protected virtual IEnumerable<Test> ParseProcess(PluginInput data)
		{
			var parser = new TestParser.Parser.TestParser();
			parser.NotifyProcessAndProgressDelegate += ReceiveTestParseProgress;
			IEnumerable<Test> tests = ParseExecute(parser, data);

			return tests;
		}

		/// <summary>
		/// Parse and create test datas.
		/// </summary>
		/// <param name="parser">Parser inherits <para>IParser</para> interface.</param>
		/// <param name="input">Input data for the plugin.</param>
		/// <returns>Collection of <para>Test</para> object.</returns>
		protected virtual IEnumerable<Test> ParseExecute(TestParser.IParser parser, PluginInput input)
		{
			string path = input.InputFilePath;
			IEnumerable<Test> tests = (IEnumerable<Test>)parser.Parse(path);
			return tests;
		}

		/// <summary>
		/// Create stub and test driver code.
		/// </summary>
		/// <param name="data">Plugin input data.</param>
		/// <param name="tests">Test datas.</param>
		protected virtual void CreateCodeProcess(PluginInput data, IEnumerable<Test> tests)
		{
			DirectoryInfo rootDirInfo = new DirectoryInfo(data.OutputDirPath);

			NotifyParseProgressDelegate?.Invoke(string.Empty, 0, 1);

			CreateStubCodeExeucte(data, tests, rootDirInfo);

			NotifyPluginFinishDelegate?.Invoke();
		}

		/// <summary>
		/// Create stub codes.
		/// </summary>
		/// <param name="data">Plugin input data.</param>
		/// <param name="tests">Test datas.</param>
		/// <param name="rootDirInfo">Code output root directory information.</param>
		protected virtual void CreateStubCodeExeucte(PluginInput data, IEnumerable<Test> tests, DirectoryInfo rootDirInfo)
		{
			CodeConfiguration codeConfig = Input2CodeConfigForStub(data);

			int testIndex = 0;
			string processName = "スタブコード生成：";
			NotifyParseProgressDelegate?.Invoke(processName, testIndex, tests.Count());
			foreach (var testItem in tests)
			{
				string progName = $"{processName} : {testItem.Name}";
				NotifyParseProgressDelegate?.Invoke(progName, testIndex, tests.Count());

				CreateStubCode(testItem, rootDirInfo, codeConfig);

				testIndex++;
				NotifyParseProgressDelegate?.Invoke(progName, testIndex, tests.Count());
			}
		}

		/// <summary>
		/// Convert plugin input data for stub code into <para>CodeConfiguration</para> object to set CodeGenerator interface.
		/// </summary>
		/// <param name="input">Plugin input </param>
		/// <returns>WriteData object for stub.</returns>
		protected virtual CodeConfiguration Input2CodeConfigForStub(PluginInput input)
		{
			var config = new CodeConfiguration()
			{
				BufferSize1 = Convert.ToInt32(input.StubBufferSize1),
				BufferSize2 = Convert.ToInt32(input.StubBufferSize2),
				StandardHeaderFiles = new List<string>(input.StubIncludeStandardHeaderFiles),
				UserHeaderFiles = new List<string>(input.StubIncludeUserHeaderFiles)
			};
			return config;
		}

		/// <summary>
		/// Create information about directory to output data.
		/// </summary>
		/// <param name="rootDir">Root directory information of output root.</param>
		/// <param name="data">Write data</param>
		/// <returns><para>DirectoryInfo</para> object about output.</returns>
		protected virtual DirectoryInfo CreateOutputDirInfo(DirectoryInfo rootDir, WriteData data)
		{
			string outputDirPath = $@"{rootDir.FullName}\{data.Test.Target.Name}_test";
			var outputDirInfo = new DirectoryInfo(outputDirPath);
			return outputDirInfo;
		}

		/// <summary>
		/// Delegate to receive parser progress.
		/// </summary>
		/// <param name="numerator">Numerator of progress.</param>
		/// <param name="denominator">Denominator of progress.</param>
		protected void ReceiveTestParseProgress(string name, int numerator, int denominator)
		{
			NotifyParseProgressDelegate?.Invoke(name, numerator, denominator);
		}

		/// <summary>
		/// Notify that execution is complete.
		/// </summary>
		/// <param name="data"></param>
		protected virtual void CompleteExecute(PluginInput data)
		{
			NotifyPluginFinishDelegate?.Invoke();
		}

		/// <summary>
		/// Create stub file name.
		/// </summary>
		/// <param name="writeData">Write data.</param>
		/// <returns>Stub file name without extention.</returns>
		protected string CreateStubFileName(WriteData writeData)
		{
			string fileName = $"{writeData.Test.Target.Name}_stub";
			return fileName;
		}
	}
}
