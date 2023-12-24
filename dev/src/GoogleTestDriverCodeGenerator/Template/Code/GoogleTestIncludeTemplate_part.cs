using CodeGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.TestDriver.Template
{
    public partial class GoogleTestIncludeTemplate
    {
		/// <summary>
		/// Test configuration.
		/// </summary>
		public CodeConfiguration Config { get; set; }

		/// <summary>
		/// Driver header file name the test driver source code includes.
		/// </summary>
		public string DriverHeaderFileName { get; set; }

		/// <summary>
		/// Stub header file name the test driver source code includes.
		/// </summary>
		public string StubHeaderFileName { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestIncludeTemplate() { }
	}
}
