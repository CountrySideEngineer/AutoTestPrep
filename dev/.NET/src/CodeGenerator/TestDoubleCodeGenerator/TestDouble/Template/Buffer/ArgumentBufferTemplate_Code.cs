using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Buffer
{
	public partial class ArgumentBufferTemplate
	{
		/// <summary>
		/// Target function.
		/// </summary>
		public Function Function { get; set; } = new Function();

		/// <summary>
		/// Target argument.
		/// </summary>
		public Parameter Argument { get; set; } = new Parameter();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ArgumentBufferTemplate() : base() { }
	}
}
