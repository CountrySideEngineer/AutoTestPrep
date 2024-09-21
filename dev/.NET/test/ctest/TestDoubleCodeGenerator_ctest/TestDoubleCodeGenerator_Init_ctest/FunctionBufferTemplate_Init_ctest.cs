using Logger;
using TestDoubleCodeGenerator.TestDouble.Template.Init;
using TestReader.Model;

namespace TestDoubleCodeGenerator_Init_ctest
{
	public class FunctionBufferTemplate_Init_ctest
	{
		[SetUp]
		public void Setup()
		{
			Log.AddLogger(new Logger.Console.DebugLog());
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

			string expect = $"\tSampleFunction_called_count = 0;" + Environment.NewLine;

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
			Log.DEBUG($"{nameof(expect),16}= {Environment.NewLine}{expect}");

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}