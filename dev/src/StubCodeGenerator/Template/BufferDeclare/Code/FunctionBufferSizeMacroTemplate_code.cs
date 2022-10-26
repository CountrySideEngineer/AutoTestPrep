using CodeGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Stub.Template.BufferDeclare
{
	public partial class FunctionBufferSizeMacroTemplate
	{
		/// <summary>
		/// Configuration about buffer size.
		/// </summary>
		public CodeConfiguration Config { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected FunctionBufferSizeMacroTemplate() { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="config">Configuration information.</param>
		public FunctionBufferSizeMacroTemplate(CodeConfiguration config)
		{
			Config = config;
		}
	}
}
