using Logger;
using System.Diagnostics;
using TestDoubleCodeGenerator.TestDouble.Template.Buffer;
using TestReader.Model;

namespace TestDoubleCodeGenerator_ctest
{
	public class ArgumentBufferTemplate_ctest
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
			var argument = new Parameter()
			{
				Name = "Argument1",
				DataType = "ArgDataType",
				PointerNum = 0
			};

			var template = new ArgumentBufferTemplate()
			{
				Function = function,
				Target = argument
			};
			string code = template.TransformText();

			string expect = $"{"ArgDataType",-16}\tSampleFunction_Argument1[BUFFER_SIZE_1];" + Environment.NewLine;

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}