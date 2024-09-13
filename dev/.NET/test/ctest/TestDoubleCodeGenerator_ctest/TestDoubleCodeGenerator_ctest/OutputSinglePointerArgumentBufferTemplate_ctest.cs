using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.TestDouble.Template.Buffer;
using TestReader.Model;

namespace TestDoubleCodeGenerator_ctest
{
	public class OutputSinglePointerArgumentBufferTemplate_ctest
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
				Mode = Parameter.ACCESS_MODE.OUT,
				PointerNum = 1
			};

			var template = new OutputSinglePointerArgumentBufferTemplate()
			{
				Function = function,
				Target = argument
			};
			string code = template.TransformText();

			string expect = $"{"ArgDataType*",-16}\tSampleFunction_Argument1[BUFFER_SIZE_1];" + Environment.NewLine;
			expect += $"{"ArgDataType",-16}\tSampleFunction_Argument1_value[BUFFER_SIZE_1][BUFFER_SIZE_2];" + Environment.NewLine;
			expect += $"{"long",-16}\tSampleFunction_Argument1_value_size[BUFFER_SIZE_1];" + Environment.NewLine;
			expect += $"{"ArgDataType",-16}\tSampleFunction_Argument1_return_value[BUFFER_SIZE_1][BUFFER_SIZE_2];" + Environment.NewLine;
			expect += $"{"long",-16}\tSampleFunction_Argument1_return_value_size[BUFFER_SIZE_1];" + Environment.NewLine;

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
			Log.DEBUG($"{nameof(expect),16}= {Environment.NewLine}{expect}");

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}
