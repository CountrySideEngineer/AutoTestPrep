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
		/// Target argument.
		/// </summary>
		public Parameter Argument { get; set; } = new Parameter();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ArgumentBufferTemplate() : base()
		{
			Target = new Function();
		}
	}
}
