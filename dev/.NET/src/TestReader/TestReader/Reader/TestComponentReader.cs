using System.Data;
using TestReader.Model;
using TestReader.Model.Test;
using Logger;
using System.Security.Cryptography.X509Certificates;

namespace TestReader.Reader
{
	public class TestComponentReader : IReader<IEnumerable<TestComponent>>
	{
		protected IReader<IEnumerable<TestTargetInfo>> _functionListReader = new FunctionListReader();
		protected IReader<Function> _functionReader = new FunctionReader(); 
		protected IReader<IEnumerable<TestCase>> _testCaseReader = new TestCaseReader();

		public IEnumerable<TestComponent> Read(Stream stream)
		{
			Log.TRACE();

			throw new NotImplementedException();
		}

		public IEnumerable<TestComponent> Read(string path, string name)
		{
			Log.TRACE();

			throw new NotImplementedException();
		}

		public IEnumerable<TestComponent> Read(Stream stream, string name)
		{
			Log.TRACE();

			throw new NotImplementedException();
		}

		/// <summary>
		/// Read test component from a file.
		/// </summary>
		/// <param name="path">Path to file to read.</param>
		/// <returns>Collection of TestComponent object.</returns>
		public virtual IEnumerable<TestComponent> Read(string path)
		{
			Log.TRACE();

			Log.DEBUG($"{nameof(path),12} = \"{path}\".");

			Log.INFO($"Start reading file \"{path}\".");

			string sheetName = "テスト一覧";
			IEnumerable<TestTargetInfo> targetInfos = _functionListReader.Read(path, sheetName);
			foreach (var targetInfo in targetInfos)
			{
				TestSuite testSuite = ReadTestSuite(path, targetInfo);
				var testCompnent = new TestComponent()
				{
					Name = targetInfo.Name,
					Description = targetInfo.Description,
					SourceName = targetInfo.FileName,
					SourcePath = targetInfo.FilePath,
					TestSuite = testSuite
				};
				yield return testCompnent;
			}
		}

		/// <summary>
		/// Read test suite from a file.
		/// </summary>
		/// <param name="path">Path to file to read.</param>
		/// <param name="targetInfo">Target infromation to read.</param>
		/// <returns>TestSuite object read from the file.</returns>
		protected virtual TestSuite ReadTestSuite(string path, TestTargetInfo targetInfo)
		{
			Log.TRACE();

			Log.DEBUG($"{nameof(path),12} = \"{path}\".");
			Log.DEBUG($"{nameof(targetInfo.Description),12} = {targetInfo.Description}");
			Log.DEBUG($"{nameof(targetInfo.FileName),12} = {targetInfo.FileName}");
			Log.DEBUG($"{nameof(targetInfo.FilePath),12} = {targetInfo.FilePath}");

			Log.INFO($"Start reading function data from \"{targetInfo.Description}\" in \"{path}\".");
			Function function = _functionReader.Read(path, targetInfo.Description);

			Log.INFO($"Start reading test cases from \"{targetInfo.Description}\" in \"{path}\".");
			IEnumerable<TestCase> testCases = _testCaseReader.Read(path, targetInfo.Description);
			TestSuite testSuite = new TestSuite()
			{
				Function = function,
				TestCases = testCases
			};
			return testSuite;
		}
	}
}
