using CodeGenerator.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Stub.Template
{
	public partial class IncludeHeaderTemplate
	{
		/// <summary>
		/// Configuration about header files to include.
		/// </summary>
		public CodeConfiguration Config { get; set; }

		/// <summary>
		/// Stub header file name.
		/// </summary>
		public string StubHeaderFileName { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected IncludeHeaderTemplate() { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="config">Include configuration information.</param>
		public IncludeHeaderTemplate(CodeConfiguration config)
		{
			Config = config;
		}
	}
}
