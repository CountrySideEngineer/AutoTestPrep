﻿using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.TestDouble.Template.Init;
using TestReader.Model;

namespace TestDoubleCodeGenerator_Init_ctest
{
	internal class ArgumentBufferTemplate_Init_ctest
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
				PointerNum = 2
			};

			var template = new ArgumentBufferTemplate()
			{
				Function = function,
				Target = argument
			};
			string code = template.TransformText();

			string expect =
				$"\tfor (int index = 0; index < BUFFER_SIZE_1; index++) {{" + Environment.NewLine +
				$"\t\tSampleFunction_Argument1[index] = 0;" + Environment.NewLine +
				$"\t}}" + Environment.NewLine;

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
			Log.DEBUG($"{nameof(expect),16}= {Environment.NewLine}{expect}");

			Assert.That(code, Is.EqualTo(expect));
		}
	}
}
