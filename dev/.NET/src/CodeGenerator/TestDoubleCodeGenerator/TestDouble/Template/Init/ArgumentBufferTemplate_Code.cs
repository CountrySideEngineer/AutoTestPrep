using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Init
{
	public partial class ArgumentBufferTemplate
	{
		/// <summary>
		/// The target arument of function.
		/// </summary>
		public Function Function { get; set; } = new Function();

		public ArgumentBufferTemplate() : base()
		{
			Target = new Parameter();
		}
	}
}
