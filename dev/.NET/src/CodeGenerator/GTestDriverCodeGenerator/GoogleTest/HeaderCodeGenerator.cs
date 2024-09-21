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
	public class HeaderCodeGenerator : ACodeGenerator
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public HeaderCodeGenerator() : base() { }

		/// <summary>
		/// Create test driver header codes.
		/// </summary>
		/// <param name="codeInput">Test code input.</param>
		/// <returns>TEst driver header code template.</returns>
		protected override GoogleTestCodeTemplate GetTemplate(CodeInput codeInput)
		{
			Log.TRACE();

			var template = new GoogleTestHeaderTemplate()
			{
				TargetFunction = codeInput.TestDesignData.Target
			};

			return template;
		}
	}
}
