using CodeGenerator.GoogleTest.Template;
using CodeGenerator.SDK.Data;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.GoogleTest
{
	public class SourceCodeGenerator : ACodeGenerator
	{
		public string TestHeaderFileName { get; set; } = string.Empty;

		public string StubHeaderFileName { get; set; } = string.Empty;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SourceCodeGenerator() : base() { }

		/// <summary>
		/// Create test driver code template.
		/// </summary>
		/// <param name="codeInput">Test code input.</param>
		/// <returns>Test driver code template.</returns>
		protected override GoogleTestCodeTemplate GetTemplate(CodeInput codeInput)
		{
			Log.TRACE();

			var template = new GoogleTestSourceTestDriverTemplate()
			{
				TargetFunction = codeInput.TestDesignData.Target,
				Test = codeInput.TestDesignData,
				Config = codeInput.Configuration,
				DriverHeaderFileName = TestHeaderFileName,
				StubHeaderFileName = StubHeaderFileName
			};
			return template;
		}
	}
}
