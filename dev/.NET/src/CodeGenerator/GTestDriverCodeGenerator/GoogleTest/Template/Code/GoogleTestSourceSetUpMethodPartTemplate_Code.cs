using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;
using Logger;

namespace CodeGenerator.GoogleTest.Template
{
	public partial class GoogleTestSourceSetUpMethodPartTemplate
	{
		/// <summary>
		/// Test target function.
		/// </summary>
		public Function TargetFunction { get; set; } = new Function();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestSourceSetUpMethodPartTemplate() : base() { }

		/// <summary>
		/// Create initialize test double method name.
		/// </summary>
		/// <param name="testDouble">Test double function data.</param>
		/// <returns>Test double initialize method name.</returns>
		public virtual string CreateTestDoubleInitializeMethodName(Function testDouble)
		{
			Log.TRACE();

			Log.DEBUG($"{"sub functoin name",32} = {testDouble.Name}");

			string initializeMethodName = $"{testDouble}_initialize()";
			return initializeMethodName;
		}
	}
}
