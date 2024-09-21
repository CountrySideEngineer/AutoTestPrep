using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.TestDouble.Template.Body;
using TestReader.Model;

namespace TestDoubleCodeGenerator_Body_ctest
{
	internal class FunctionWithReturnValueBufferTemplate_Body_ctest
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

			var template = new FunctionWithReturnValueBufferTemplate()
			{
				Target = function
			};
			string code = template.TransformText();

			string expect =
				"\tint\t_ret_val = SampleFunction_return_value[SampleFunction_called_count];" + Environment.NewLine +
				Environment.NewLine +
				"\tSampleFunction_called_count++;" + Environment.NewLine +
				Environment.NewLine +
				"\treturn _ret_val;";

			Log.DEBUG($"{nameof(expect),16}= {Environment.NewLine}{expect}");
			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}
