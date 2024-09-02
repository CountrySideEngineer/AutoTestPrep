using CodeGenerator.SDK.Data;
using Logger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;
using static System.Net.Mime.MediaTypeNames;
using TestReader.Model.Test;

namespace CodeGenerator.GoogleTest.Template
{
	public partial class GoogleTestSourceTestDriverTemplate
	{
		/// <summary>
		/// Test target function.
		/// </summary>
		public Function TargetFunction { get; set; } = new Function();

		/// <summary>
		/// Test information.
		/// </summary>
		public TestComponent Test { get; set;} = new TestComponent();

		/// <summary>
		/// The test driver header file name 
		/// </summary>
		public string DriverHeaderFileName { get; set; } = string.Empty;

		/// <summary>
		/// The stub header file name.
		/// </summary>
		public string StubHeaderFileName { get; set; } = string.Empty;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestSourceTestDriverTemplate() : base() { }

		/// <summary>
		/// Code configuration.
		/// </summary>
		public CodeConfiguration Config { get; set; } = new CodeConfiguration();

		/// <summary>
		/// Create code to include header files.
		/// </summary>
		/// <param name="function"></param>
		/// <returns></returns>
		public virtual string CreateIncludeHeaderCode(Function function)
		{
			Log.TRACE();

			var template = new GoogleTestSourceIncludePartTemplate()
			{
				Config = Config,
				DriverHeaderFileName = DriverHeaderFileName,
				StubHeaderFileName = StubHeaderFileName
			};

			string code = template.TransformText();
			return code;
		}

		/// <summary>
		/// Generates codes to declare global variables.
		/// </summary>
		/// <param name="function">Target function data.</param>
		/// <returns>Codes to deaclare global variables.</returns>
		public virtual string CreateDecalreGlobalVariableCode(Function function)
		{
			Log.TRACE();

			string code = string.Empty;
			code += CreateDeclareExternalGlobalVariableCode(function.ExternalVariables);
			code += CreateDeclareInternalGlobalVariableCode(function.InternalVariables);

			if ((string.IsNullOrEmpty(code)) || (string.IsNullOrWhiteSpace(code)))
			{
				code = $"//No global variables are refered by function {function.Name}.";
			}
			return code;
		}

		/// <summary>
		/// Generates codes to declare internal global variables.
		/// </summary>
		/// <param name="variables">Collection of global variable information.</param>
		/// <returns>Codes to declare internal global variables.</returns>
		protected virtual string CreateDeclareInternalGlobalVariableCode(IEnumerable<Parameter> variables)
		{
			Log.TRACE();

			try
			{
				string codes = string.Empty;
				foreach (var variable in variables)
				{
					string code = CreateDeclareInternalGlobalVariableCode(variable);
					if ((!string.IsNullOrEmpty(code)) && (!string.IsNullOrWhiteSpace(code)))
					{
						codes += code;
						codes += Environment.NewLine;
					}
				}
				return codes;
			}
			catch (NullReferenceException)
			{
				string message = "//There is no internal global variable.";
				return message;
			}
		}

		/// <summary>
		/// Generates code to declare internal global variable.
		/// </summary>
		/// <param name="variable">Variable data.</param>
		/// <returns>Code to declare internal global variable.</returns>
		protected virtual string CreateDeclareInternalGlobalVariableCode(Parameter variable)
		{
			Log.TRACE();

			try
			{
				string code = $"extern {variable.ToString()};";
				return code;
			}
			catch (NullReferenceException)
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// Generates code to declare external global variables.
		/// </summary>
		/// <param name="variables">Collection of global variables.</param>
		/// <returns>Codes to declare global variables.</returns>
		protected virtual string CreateDeclareExternalGlobalVariableCode(IEnumerable<Parameter> variables)
		{
			Log.TRACE();

			try
			{
				string codes = string.Empty;
				foreach (var variable in variables)
				{
					string code = CreateDeclareExternalGlobalVariableCode(variable);
					if ((!string.IsNullOrEmpty(code)) && (!string.IsNullOrWhiteSpace(code)))
					{
						codes += code;
						codes += Environment.NewLine;
					}
				}
				return codes;
			}
			catch (NullReferenceException)
			{
				string message = "//The is no external global variable.";
				return message;
			}
		}

		/// <summary>
		/// Generates code to declare external global variable.
		/// </summary>
		/// <param name="variable">Variable data.</param>
		/// <returns>Code to declare external global variable.</returns>
		protected virtual string CreateDeclareExternalGlobalVariableCode(Parameter variable)
		{
			Log.TRACE();

			try
			{
				string code = $"{variable.ToString()};";
				return code;
			}
			catch (NullReferenceException)
			{
				return string.Empty;
			}
		}

		/// <summary>
		/// Create code to initialize stub variables by "SetUp" method.
		/// </summary>
		/// <param name="targetFunction">Test target function data.</param>
		/// <returns>SetUp method code.</returns>
		/// <exception cref="NullReferenceException">Target function or sub functions are NULL.</exception>
		public virtual string CreateSetUpCode(Function targetFunction)
		{
			Log.TRACE();

			try
			{
				var template = new GoogleTestSourceSetUpMethodPartTemplate()
				{
					TargetFunction = targetFunction
				};
				var setupCode = template.TransformText();
				return setupCode;
			}
			catch (NullReferenceException ex)
			{
				Log.ERROR($"Setup method code create failed.");

				throw;
			}
		}

		/// <summary>
		/// Create code for unit tests.
		/// </summary>
		/// <param name="targetFunction">Test target fucntion data.</param>
		/// <param name="test">Test data</param>
		/// <returns>Code for unit tests.</returns>
		/// <exception cref="NullReferenceException"></exception>
		public virtual string CreateTestCaseCode(Function targetFunction, TestComponent test)
		{
			Log.TRACE();

			try
			{
				string testCaseCode = string.Empty;
				foreach (var testCase in test.TestSuite.TestCases)
				{
					testCaseCode += this.CreateTestCaseCode(targetFunction, testCase);
				}
				return testCaseCode;
			}
			catch (NullReferenceException ex)
			{
				Debug.WriteLine(ex.StackTrace);

				throw;
			}
		}

		/// <summary>
		/// Create code for a unit test case
		/// </summary>
		/// <param name="targetFunction">Test target function.</param>
		/// <param name="testCase">Test case data.</param>
		/// <returns>Code for a unit test.</returns>
		/// <exception cref="NullReferenceException">Target function has </exception>
		public virtual string CreateTestCaseCode(Function targetFunction, TestCase testCase)
		{
			Log.TRACE();

			try
			{
				var template = new GoogleTestSourceTestCasePartTemplate()
				{
					TargetFunction = targetFunction,
					TestCase = testCase
				};
				var testCaseCode = template.TransformText();
				return testCaseCode;
			}
			catch (NullReferenceException ex)
			{
				Debug.WriteLine(ex.StackTrace);

				throw;
			}
		}
	}
}
