using Logger;
using System.Diagnostics;
using TestDoubleCodeGenerator.TestDouble.Template.Buffer;
using TestReader.Model;

namespace TestDoubleCodeGenerator_ctest
{
	public class PointerArgumentBufferTemplate_ctest
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
				PointerNum = 1,
				Mode = Parameter.ACCESS_MODE.IN
			};

			var template = new PointerArgumentBufferTemplate()
			{
				Target = function,
				Argument = argument
			};
			string code = template.TransformText();

			string expect = $"{"ArgDataType*",-16}\tSampleFunction_Argument1[BUFFER_SIZE_1];" + Environment.NewLine;
			expect += $"{"ArgDataType",-16}\tSampleFunction_Argument1_value[BUFFER_SIZE_1][BUFFER_SIZE_2];" + Environment.NewLine;
			expect += $"{"long",-16}\tSampleFunction_Argument1_value_size[BUFFER_SIZE_1];" + Environment.NewLine;

			Log.DEBUG($"{nameof(code),16} = {Environment.NewLine}{code}");
			Log.DEBUG($"{nameof(expect),16} = {Environment.NewLine}{expect}");
			Assert.That(code, Is.EqualTo(expect));
		}
	}
}