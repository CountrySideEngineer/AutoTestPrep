using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template
{
	public partial class BufferTemplateCommonBase
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferTemplateCommonBase() : base() { }

		/// <summary>
		/// Target parameter object.
		/// </summary>
		public Parameter Target { get; set; } = new Parameter();
	}
}
