using Logger;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using TestReader.Reader;

namespace TestReader_TestTableReader
{
	public class TestTableReader_test
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
		public void TestTableReader_test_001_001()
		{
			string testFilePath = @".\..\..\..\..\..\..\..\..\..\doc\sample\test_sample_input\google_test_sample_data.xlsx";
			string sheetName = "sample_function_001";

			TestCaseReader reader = new TestCaseReader();
			IEnumerable<TestReader.Model.Test.TestCase> testCases = reader.Read(testFilePath, sheetName);

			Assert.That(testCases.Count(), Is.EqualTo(16));
			Assert.That(testCases.ElementAt(0).Name, Is.EqualTo("1"));
			Assert.That(testCases.ElementAt(0).Inputs.Count(), Is.EqualTo(2));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(0).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(0).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(0).Value, Is.EqualTo("0"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(1).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(1).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(testCases.ElementAt(0).Inputs.ElementAt(1).Value, Is.EqualTo("0"));
			Assert.That(testCases.ElementAt(0).Expects.Count(), Is.EqualTo(1));
			Assert.That(testCases.ElementAt(0).Expects.ElementAt(0).Condition, Is.EqualTo("期待値"));
			Assert.That(testCases.ElementAt(0).Expects.ElementAt(0).Description, Is.EqualTo("戻り値"));
			Assert.That(testCases.ElementAt(0).Expects.ElementAt(0).Name, Is.EqualTo("ret_val"));
			Assert.That(testCases.ElementAt(0).Expects.ElementAt(0).Value, Is.EqualTo("0"));

			Assert.That(testCases.ElementAt(1).Name, Is.EqualTo("2"));
			Assert.That(testCases.ElementAt(1).Inputs.Count(), Is.EqualTo(2));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(0).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(0).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(0).Value, Is.EqualTo("0"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(1).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(1).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(testCases.ElementAt(1).Inputs.ElementAt(1).Value, Is.EqualTo("1"));
			Assert.That(testCases.ElementAt(1).Expects.Count(), Is.EqualTo(1));
			Assert.That(testCases.ElementAt(1).Expects.ElementAt(0).Condition, Is.EqualTo("期待値"));
			Assert.That(testCases.ElementAt(1).Expects.ElementAt(0).Description, Is.EqualTo("戻り値"));
			Assert.That(testCases.ElementAt(1).Expects.ElementAt(0).Name, Is.EqualTo("ret_val"));
			Assert.That(testCases.ElementAt(1).Expects.ElementAt(0).Value, Is.EqualTo("1"));

			Assert.That(testCases.ElementAt(2).Name, Is.EqualTo("3"));
			Assert.That(testCases.ElementAt(2).Inputs.Count(), Is.EqualTo(2));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(0).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(0).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(0).Value, Is.EqualTo("0"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(1).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(1).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(testCases.ElementAt(2).Inputs.ElementAt(1).Value, Is.EqualTo("2"));
			Assert.That(testCases.ElementAt(2).Expects.Count(), Is.EqualTo(1));
			Assert.That(testCases.ElementAt(2).Expects.ElementAt(0).Condition, Is.EqualTo("期待値"));
			Assert.That(testCases.ElementAt(2).Expects.ElementAt(0).Description, Is.EqualTo("戻り値"));
			Assert.That(testCases.ElementAt(2).Expects.ElementAt(0).Name, Is.EqualTo("ret_val"));
			Assert.That(testCases.ElementAt(2).Expects.ElementAt(0).Value, Is.EqualTo("2"));

			Assert.That(testCases.ElementAt(3).Name, Is.EqualTo("4"));
			Assert.That(testCases.ElementAt(3).Inputs.Count(), Is.EqualTo(2));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(0).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(0).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(0).Value, Is.EqualTo("0"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(1).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(1).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(testCases.ElementAt(3).Inputs.ElementAt(1).Value, Is.EqualTo("3"));
			Assert.That(testCases.ElementAt(3).Expects.Count(), Is.EqualTo(1));
			Assert.That(testCases.ElementAt(3).Expects.ElementAt(0).Condition, Is.EqualTo("期待値"));
			Assert.That(testCases.ElementAt(3).Expects.ElementAt(0).Description, Is.EqualTo("戻り値"));
			Assert.That(testCases.ElementAt(3).Expects.ElementAt(0).Name, Is.EqualTo("ret_val"));
			Assert.That(testCases.ElementAt(3).Expects.ElementAt(0).Value, Is.EqualTo("3"));

			Assert.That(testCases.ElementAt(4).Name, Is.EqualTo("5"));
			Assert.That(testCases.ElementAt(4).Inputs.Count(), Is.EqualTo(2));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(0).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(0).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(0).Value, Is.EqualTo("1"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(1).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(1).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(testCases.ElementAt(4).Inputs.ElementAt(1).Value, Is.EqualTo("0"));
			Assert.That(testCases.ElementAt(4).Expects.Count(), Is.EqualTo(1));
			Assert.That(testCases.ElementAt(4).Expects.ElementAt(0).Condition, Is.EqualTo("期待値"));
			Assert.That(testCases.ElementAt(4).Expects.ElementAt(0).Description, Is.EqualTo("戻り値"));
			Assert.That(testCases.ElementAt(4).Expects.ElementAt(0).Name, Is.EqualTo("ret_val"));
			Assert.That(testCases.ElementAt(4).Expects.ElementAt(0).Value, Is.EqualTo("1"));

			Assert.That(testCases.ElementAt(15).Name, Is.EqualTo("16"));
			Assert.That(testCases.ElementAt(15).Inputs.Count(), Is.EqualTo(2));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(0).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(0).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(0).Name, Is.EqualTo("input1"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(0).Value, Is.EqualTo("3"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(1).Condition, Is.EqualTo("入力"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(1).Description, Is.EqualTo("引数"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(1).Name, Is.EqualTo("input2"));
			Assert.That(testCases.ElementAt(15).Inputs.ElementAt(1).Value, Is.EqualTo("3"));
			Assert.That(testCases.ElementAt(15).Expects.Count(), Is.EqualTo(1));
			Assert.That(testCases.ElementAt(15).Expects.ElementAt(0).Condition, Is.EqualTo("期待値"));
			Assert.That(testCases.ElementAt(15).Expects.ElementAt(0).Description, Is.EqualTo("戻り値"));
			Assert.That(testCases.ElementAt(15).Expects.ElementAt(0).Name, Is.EqualTo("ret_val"));
			Assert.That(testCases.ElementAt(15).Expects.ElementAt(0).Value, Is.EqualTo("0"));
		}
	}
}