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
	internal class BodyTemplate_Body_ctest
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

			var template = new BodyTemplate()
			{
				Target = function
			};
			string code = template.TransformText();

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
		}

		[Test]
		public void Test2()
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
				Postfix = new List<string>() { "*" },
				Mode = Parameter.ACCESS_MODE.IN,
				PointerNum = 1
			};
			function.Arguments = new List<Parameter>() { argument };

			var template = new BodyTemplate()
			{
				Target = function
			};
			string code = template.TransformText();

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
		}

		[Test]
		public void Test3()
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
				Postfix = new List<string>() { "*" },
				Mode = Parameter.ACCESS_MODE.OUT,
				PointerNum = 1
			};
			function.Arguments = new List<Parameter>() { argument };

			var template = new BodyTemplate()
			{
				Target = function
			};
			string code = template.TransformText();

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
		}

		[Test]
		public void Test4()
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
				Postfix = new List<string>() { "*" },
				Mode = Parameter.ACCESS_MODE.BOTH,
				PointerNum = 1
			};
			function.Arguments = new List<Parameter>() { argument };

			var template = new BodyTemplate()
			{
				Target = function
			};
			string code = template.TransformText();

			Log.DEBUG($"{nameof(code),16}= {Environment.NewLine}{code}");
		}
	}
}
