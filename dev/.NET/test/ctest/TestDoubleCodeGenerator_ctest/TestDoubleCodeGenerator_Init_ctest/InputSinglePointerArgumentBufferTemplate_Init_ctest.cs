using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;
using TestDoubleCodeGenerator.TestDouble.Template.Init;

namespace TestDoubleCodeGenerator_Init_ctest
{
	internal class InputSinglePointerArgumentBufferTemplate_Init_ctest
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

			var template = new InputSinglePointerArgumentBufferTemplate()
			{
				Function = function,
				Target = argument
			};
			string code = template.TransformText();

			string expect = 
				$"\tfor (int index1 = 0; index1 < BUFFER_SIZE_1; index1++) {{" + Environment.NewLine +
				$"\t\tSampleFunction_Argument1[index1] = 0;" + Environment.NewLine +
				$"\t\tfor (int index2 = 0; index2 < BUFFER_SIZE_2; index2++) {{" + Environment.NewLine +
				$"\t\t\tSampleFunction_Argument1_value[index1][index2] = 0;" + Environment.NewLine +
				$"\t\t}}" + Environment.NewLine +
				$"\t\tSampleFunction_Argument1_value_size[index1] = 0;" + Environment.NewLine +
				$"\t}}" + Environment.NewLine;


			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
			Log.DEBUG($"{nameof(expect),16}= {Environment.NewLine}{expect}");

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}
