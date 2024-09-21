using System.Security.Cryptography.X509Certificates;
using TestReader.Reader;
using Logger;
using TestReader.Model;

namespace TestReader_FunctionListReader_ctest
{
	public class FunctionListReader_test
	{
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			Log.AddLogger(new Logger.Console.DebugLog());
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void FunctionList_Read_001()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "テスト一覧";

			var reader = new FunctionListReader();
			IEnumerable<TestTargetInfo> datas = reader.Read(path: testFilePath, sheetName: sheetName);

			Assert.That(datas.Count(), Is.EqualTo(5));
			Assert.That(datas.ElementAt(0).Description, Is.EqualTo("sample_function_001"));
			Assert.That(datas.ElementAt(0).Name, Is.EqualTo("sample_function_001"));
			Assert.That(datas.ElementAt(0).FileName, Is.EqualTo("sample_src.cpp"));
			Assert.That(datas.ElementAt(0).FilePath, Is.EqualTo(string.Empty));
			Assert.That(datas.ElementAt(1).Description, Is.EqualTo("sample_function_002"));
			Assert.That(datas.ElementAt(1).Name, Is.EqualTo("sample_function_002"));
			Assert.That(datas.ElementAt(1).FileName, Is.EqualTo("sample_src.cpp"));
			Assert.That(datas.ElementAt(1).FilePath, Is.EqualTo(string.Empty));
			Assert.That(datas.ElementAt(2).Description, Is.EqualTo("sample_function_003"));
			Assert.That(datas.ElementAt(2).Name, Is.EqualTo("sample_function_003"));
			Assert.That(datas.ElementAt(2).FileName, Is.EqualTo("sample_src.cpp"));
			Assert.That(datas.ElementAt(2).FilePath, Is.EqualTo(string.Empty));
			Assert.That(datas.ElementAt(3).Description, Is.EqualTo("sample_function_004"));
			Assert.That(datas.ElementAt(3).Name, Is.EqualTo("sample_function_004"));
			Assert.That(datas.ElementAt(3).FileName, Is.EqualTo("sample_src.cpp"));
			Assert.That(datas.ElementAt(3).FilePath, Is.EqualTo(string.Empty));
			Assert.That(datas.ElementAt(4).Description, Is.EqualTo("sample_function_005"));
			Assert.That(datas.ElementAt(4).Name, Is.EqualTo("sample_function_005"));
			Assert.That(datas.ElementAt(4).FileName, Is.EqualTo("sample_src.cpp"));
			Assert.That(datas.ElementAt(4).FilePath, Is.EqualTo(string.Empty));
		}

		[Test]
		public void FunctionList_Read_002()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data_002.xlsx";
			string sheetName = "テスト一覧";

			var reader = new FunctionListReader();
			IEnumerable<TestTargetInfo> datas = reader.Read(path: testFilePath, sheetName: sheetName);

			Assert.That(datas.Count(), Is.EqualTo(6));
			Assert.That(datas.ElementAt(0).Description, Is.EqualTo("sample_function_002_001"));
			Assert.That(datas.ElementAt(0).Name, Is.EqualTo("sample_function_002_001"));
			Assert.That(datas.ElementAt(0).FileName, Is.EqualTo("sample_src_002.cpp"));
			Assert.That(datas.ElementAt(0).FilePath, Is.EqualTo(@"E:\development\AutoTestPrep\doc\sample\test_sample_input\sample_src_001.cpp"));
			Assert.That(datas.ElementAt(1).Description, Is.EqualTo("sample_function_002_002"));
			Assert.That(datas.ElementAt(1).Name, Is.EqualTo("sample_function_002_002"));
			Assert.That(datas.ElementAt(1).FileName, Is.EqualTo("sample_src_002.cpp"));
			Assert.That(datas.ElementAt(1).FilePath, Is.EqualTo(@"E:\development\AutoTestPrep\doc\sample\test_sample_input\sample_src_002.cpp"));
			Assert.That(datas.ElementAt(2).Description, Is.EqualTo("sample_function_002_003"));
			Assert.That(datas.ElementAt(2).Name, Is.EqualTo("sample_function_002_003"));
			Assert.That(datas.ElementAt(2).FileName, Is.EqualTo("sample_src_002.cpp"));
			Assert.That(datas.ElementAt(2).FilePath, Is.EqualTo(@"E:\development\AutoTestPrep\doc\sample\test_sample_input\sample_src_003.cpp"));
			Assert.That(datas.ElementAt(3).Description, Is.EqualTo("sample_function_002_004"));
			Assert.That(datas.ElementAt(3).Name, Is.EqualTo("sample_function_002_004"));
			Assert.That(datas.ElementAt(3).FileName, Is.EqualTo("sample_src_002.cpp"));
			Assert.That(datas.ElementAt(3).FilePath, Is.EqualTo(@"E:\development\AutoTestPrep\doc\sample\test_sample_input\sample_src_004.cpp"));
			Assert.That(datas.ElementAt(4).Description, Is.EqualTo("sample_function_002_005"));
			Assert.That(datas.ElementAt(4).Name, Is.EqualTo("sample_function_002_005"));
			Assert.That(datas.ElementAt(4).FileName, Is.EqualTo("sample_src_002.cpp"));
			Assert.That(datas.ElementAt(4).FilePath, Is.EqualTo(@"E:\development\AutoTestPrep\doc\sample\test_sample_input\sample_src_005.cpp"));
			Assert.That(datas.ElementAt(5).Description, Is.EqualTo("sample_function_002_006"));
			Assert.That(datas.ElementAt(5).Name, Is.EqualTo("sample_function_002_006"));
			Assert.That(datas.ElementAt(5).FileName, Is.EqualTo("sample_src_002.cpp"));
			Assert.That(datas.ElementAt(5).FilePath, Is.EqualTo(@"E:\development\AutoTestPrep\doc\sample\test_sample_input\sample_src_006.cpp"));
		}
	}
}