using Logger;
using System.ComponentModel;
using TestReader.Model;
using TestReader.Reader;

namespace TestReader_TestComponentReader_test
{
	public class TestComponentReader_test
	{
		[SetUp]
		public void Setup()
		{
			Log.AddLogger(new Logger.Console.DebugLog()
			{
				InfoOn = true,
				WarnOn = true,
				ErrorOn = true,
				FatalOn = true,
			});
		}

		[Test]
		public void TestComponentReader_test_001_001()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";

			TestComponentReader reader = new TestComponentReader();
			IEnumerable<TestComponent> components = reader.Read(testFilePath);

			Assert.That(components.Count(), Is.EqualTo(5));
			Assert.That(components.ElementAt(0).Name, Is.EqualTo("sample_function_001"));
			Assert.That(components.ElementAt(0).Description, Is.EqualTo("sample_function_001"));
			Assert.That(components.ElementAt(0).SourceName, Is.EqualTo("sample_src.cpp"));
			Assert.That(components.ElementAt(0).SourcePath, Is.EqualTo(""));
		}
	}
}