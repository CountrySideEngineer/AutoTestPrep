using Logger;
using TestDoubleCodeGenerator.TestDouble.Template.Body;
using TestReader.Model;

namespace TestDoubleCodeGenerator_Body_ctest
{
	public class Tests
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
		public void Test1()
		{
			var function = new Function()
			{
				Name = "SampleFunction",
				DataType = "int",
				PointerNum = 0
			};

			var template = new FunctionBufferTemplate()
			{
				Target = function
			};
			string code = template.TransformText();

			string expect = "\tSampleFunction_called_count++;";

			Log.DEBUG($"{nameof(expect),16}= {Environment.NewLine}{expect}");
			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}