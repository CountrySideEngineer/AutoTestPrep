using Logger;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;
using TestReader.Model.Test;

namespace CodeGenerator.GoogleTest.Template
{
	public partial class GoogleTestCodeTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestCodeTemplate() : base() { }

		/// <summary>
		/// Create unit test class nmae.
		/// </summary>
		/// <param name="function">Test functoin.</param>
		/// <returns>Unit test class name.</returns>
		/// <exception cref="ArgumentException">Target function data invalid.</exception>
		protected virtual string GetTestClassName(Function function)
		{
			Log.TRACE();

			Log.DEBUG($"{function.Name,32} = {function.Name}");

			try
			{
				if ((string.IsNullOrEmpty(function.Name)) ||
					(string.IsNullOrWhiteSpace(function.Name)))
				{
					Log.WARN("Test functin name should not empty or white space.");

					throw new ArgumentException("Function name invalid.");
				}

				string testClassName = $"{function.Name}_utest";

				Log.DEBUG($"{"Test class name",32} = {testClassName}");

				return testClassName;
			}
			catch (NullReferenceException)
			{
				Log.FATAL("Target object is null.");

				throw;
			}
		}

		/// <summary>
		/// Create test function name for unit test.
		/// </summary>
		/// <param name="caseNumber">Test case number.</param>
		/// <param name="function">Target function data.</param>
		/// <returns>Test function name for unit test.</returns>
		protected virtual string GetTestCaseName(int caseNumber, Function function)
		{
			Log.TRACE();

			Log.DEBUG($"{nameof(caseNumber),32} = {caseNumber}");
			Log.DEBUG($"{function.Name,32} = {function.Name}");

			string testCaseName = $"{function.Name}_{caseNumber.ToString("D3")}";

			Log.DEBUG($"{nameof(testCaseName),32} = {testCaseName}");

			return testCaseName;
		}

		/// <summary>
		/// Create test function name for unit test.
		/// </summary>
		/// <param name="function">Target function data</param>
		/// <param name="testCase">Test case data.</param>
		/// <returns>Test function name for unit test.</returns>
		protected virtual string GetTestCaseName(TestCase testCase, Function function)
		{
			Log.TRACE();

			Log.DEBUG($"{testCase.Name,32} = {testCase.Name}");
			Log.DEBUG($"{function.Name,32} = {function.Name}");

			string testCaseName = $"{function.Name}_utest";
			int testCaseId = 0;
			if (int.TryParse(testCase.Name, out testCaseId))
			{
				Log.DEBUG("Test case name can convert numeric data type.");

				testCaseName += $"_{testCaseId.ToString("D3")}";
			}
			else
			{
				Log.DEBUG("Test case name can not convert numeric data type.");

				testCaseName += $"{testCase.Name}";
			}

			Log.DEBUG($"{nameof(testCaseName),32} = {testCaseName}");

			return testCaseName;
		}
	}
}
