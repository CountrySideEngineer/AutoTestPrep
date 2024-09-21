using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;
using TestReader.Model.Test;

namespace CodeGenerator.GoogleTest.Template
{
	public partial class GoogleTestSourceTestCasePartTemplate
	{
		/// <summary>
		/// Test target function.
		/// </summary>
		public Function TargetFunction { get; set; } = new Function();

		/// <summary>
		/// Test case number.
		/// </summary>
		public int TestCaseNumber { get; set; } = 0;

		/// <summary>
		/// Test case data.
		/// </summary>
		public TestCase TestCase { get;set; } = new TestCase();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestSourceTestCasePartTemplate() : base() { }

		/// <summary>
		/// Create codes to declare argument variable.
		/// </summary>
		/// <param name="argument">Argument data.</param>
		/// <returns>Codes to declare argument.</returns>
		protected virtual string CreateCodeToDeclareArgumentPart(Parameter argument)
		{
			Log.TRACE();

			string declare = string.Empty;
			if (0 < argument.PointerNum)
			{
				declare = CreateCodeToDeclareArgumentWithPointer(argument);
			}
			declare += $"\t{argument.ActualDataType()} {argument.Name};";
			return declare;
		}

		protected virtual string CreateCodeToDeclareArgumentWithPointer(Parameter argument)
		{
			Log.TRACE();

			string dataType = string.Empty;
			if ("void".Equals(argument.DataType.ToLower()))
			{
				dataType = "int";
			}
			else
			{
				dataType = argument.DataType;
			}

			string declare = string.Empty;
			if (1 == argument.PointerNum)
			{
				declare = $"\t{dataType} _{argument.Name}[100];" + Environment.NewLine;
			}
			else if (2 == argument.PointerNum)
			{
				declare = $"\t{dataType}* _{argument.Name}[100];" + Environment.NewLine;
			}
			else
			{
				throw new ArgumentOutOfRangeException();
			}
			return declare;
		}

		/// <summary>
		/// Create code to set input value into variable.
		/// </summary>
		/// <param name="input">Input information.</param>
		/// <returns>Code to set input value into variable.</returns>
		protected virtual string SetInputValuesPart(TestData input)
		{
			Log.TRACE();

			string code = string.Empty;
			try
			{
				Parameter argument = TargetFunction.Arguments
					.Where(_ => _.Name.Equals(input.Name))
					.First();
				if (("void".Equals(argument.DataType.ToLower())) && (0 < argument.PointerNum))
				{
					code = $"{input.Name} = ({argument.DataType}*){input.Value}";
				}
				else
				{
					code = $"{input.Name} = {input.Value}";
				}
			}
			catch (InvalidOperationException)
			{
				code = $"{input.Name} = {input.Value}";
			}
			return code;
		}
	}
}
