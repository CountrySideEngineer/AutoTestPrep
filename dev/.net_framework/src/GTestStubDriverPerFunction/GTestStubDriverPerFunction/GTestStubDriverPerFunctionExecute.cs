using CodeGenerator;
using CodeGenerator.Data;
using CodeGenerator.TestDriver.GoogleTest;
using CodeGenerator.TestDriver.GoogleTest.CodeGenerator;
using CodeGenerator.TestDriver.Template;
using StubDriverPlugin.GTestStubDriver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Data;

namespace GTestStubDriverPerFunction.GTestStubDriverPerFunction
{
    public class GTestStubDriverPerFunctionExecute : GTestStubDriverPluginExecute
    {
		/// <summary>
		/// Create test driver code and files.
		/// </summary>
		/// <param name="outputRootDirInfo">Output root directory information.</param>
		/// <param name="data">Output test data information.</param>
        protected override void CreateDriverCode(DirectoryInfo outputRootDirInfo, WriteData data)
        {
			CreateDriverSetUp(outputRootDirInfo, data);

			foreach (var item in data.Test.TestCases)
			{
				WriteData cloneData = data.DeepCopy();
				cloneData.Test.TestCases = new List<TestCase> { item };
				CreateDriverCodeEachTestCase(outputRootDirInfo, cloneData);
            }
        }

		/// <summary>
		/// Create test driver source code and file.
		/// </summary>
		/// <param name="outputRootDirInfo">Output root direcotry information.</param>
		/// <param name="data">Output test data information.</param>
		protected virtual void CreateDriverCodeEachTestCase(DirectoryInfo outputRootDirInfo, WriteData data)
        {
			try
			{
				DirectoryInfo parentDirInfo = this.CreateOutputDirInfo(outputRootDirInfo, data);
				DirectoryInfo outputDirInfo = new DirectoryInfo($@"{parentDirInfo.FullName}\driver");
				Directory.CreateDirectory(outputDirInfo.FullName);

				string stubHeaderFileName = CreateStubHeaderFileName(data);
				(string driverSourceFileName, string driverHeaderFileName) =
					CreateTestDriverFileNameTuple(data);

				if ((null == data.Test.Target.SubFunctions) || (data.Test.Target.SubFunctions.Count() < 1))
				{
					stubHeaderFileName = string.Empty;
				}

				//Create test driver source file.
				ICodeGenerator codeGenerator = new GoogleTestSourcePerFunctionCodeGenerator()
				{
					TestHeaderFileName = driverHeaderFileName,
					StubHeaderFileName = stubHeaderFileName,
				};
				string outputFilePath = outputDirInfo.FullName + $@"\{driverSourceFileName}";
				FileInfo sourceFileInfo = new FileInfo(outputFilePath);
				this.CreateCode(data, codeGenerator, sourceFileInfo);
			}
			catch (Exception ex)
			when ((ex is ArgumentException) || (ex is ArgumentNullException))
			{
				throw;
			}
		}

		protected virtual void CreateDriverSetUp(DirectoryInfo outputRootDirInfo, WriteData data)
		{
            DirectoryInfo parentDirInfo = this.CreateOutputDirInfo(outputRootDirInfo, data);
            DirectoryInfo outputDirInfo = new DirectoryInfo($@"{parentDirInfo.FullName}\driver");
            Directory.CreateDirectory(outputDirInfo.FullName);

			(string sourceFileName, string headerFileName) = CreateSetupFileName(data);
			string stubHeaderFileName = CreateStubHeaderFileName(data);
			if ((null == data.Test.Target.SubFunctions) || (data.Test.Target.SubFunctions.Count() < 1))
			{
				stubHeaderFileName = string.Empty;
			}

			//Create test setup source file.
			ICodeGenerator codeGenerator = new GoogleTestSetUpSourcePerFunctionCodeGenerator()
			{
				TestHeaderFileName = headerFileName,
				StubHeaderFileName = stubHeaderFileName
			};
			string sourceFilePath = outputDirInfo.FullName + $@"\{sourceFileName}";
			FileInfo sourceFileInfo = new FileInfo(sourceFilePath);
			CreateCode(data, codeGenerator, sourceFileInfo);

			//Create test setup header file.
			codeGenerator = new GoogleTestHeaderCodeGenerator();
			string headerFilePath = outputDirInfo + $@"\{headerFileName}";
			FileInfo headerFileInfo = new FileInfo(headerFilePath);
			CreateCode(data, codeGenerator, headerFileInfo);
		}

        /// <summary>
        /// Create test driver source file name and header file name.
        /// </summary>
        /// <param name="data">Write data.</param>
        /// <returns>Test driver source and header file in tuple.</returns>
        protected override (string, string) CreateTestDriverFileNameTuple(WriteData data)
        {
            string driverFileName = CreateTestDriverFileName(data);
			string testId = data.Test.TestCases.ElementAt(0).Id;
			string fileNameBase = string.Empty;

            try
			{
                int testIdInNumber = Convert.ToInt32(testId);
                fileNameBase = $"{driverFileName}_{testIdInNumber:D3}";
            }
            catch (FormatException)
			{
                fileNameBase = $"{driverFileName}_{testId}";
            }
			catch (Exception)
			{
				throw;
            }
	        string driverSourceFileName = $"{fileNameBase}.cpp";
            string driverHeaderFileName = $"{fileNameBase}.h";

            return (driverSourceFileName, driverHeaderFileName);
        }

		protected virtual (string, string) CreateSetupFileName(WriteData data)
		{
			string fileNameBase = CreateTestDriverFileName(data);
			string setupSourceFileName = $"{fileNameBase}.cpp";
			string setupHeaderFileName = $"{fileNameBase}.h";

			return (setupSourceFileName, setupHeaderFileName);
		}
    }
}
