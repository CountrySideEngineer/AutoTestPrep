using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace CodeGenerator.GoogleTest.Template
{
	public partial class GoogleTestHeaderTemplate
	{
		/// <summary>
		/// Test target function.
		/// </summary>
		public Function TargetFunction { get; set; } = new Function();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GoogleTestHeaderTemplate() : base() { }
	}
}
