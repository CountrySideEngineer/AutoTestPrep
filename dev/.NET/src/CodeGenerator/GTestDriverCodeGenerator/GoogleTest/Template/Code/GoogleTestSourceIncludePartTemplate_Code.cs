using CodeGenerator.SDK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.GoogleTest.Template
{
	public partial class GoogleTestSourceIncludePartTemplate
	{
		/// <summary>
		/// Collection of standard header files the test cod should include.
		/// </summary>
		public IEnumerable<string>? StandardHeaders { get; set; } = new List<string>();

		/// <summary>
		/// Collection of user header files the test cod should include.
		/// </summary>
		public IEnumerable<string>? UserHeaders { get; set; } = new List<string>();

		public string DriverHeaderFileName { get; set; } = string.Empty;

		public string StubHeaderFileName { get; set; } = string.Empty;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestSourceIncludePartTemplate() : base() { }
	}
}
