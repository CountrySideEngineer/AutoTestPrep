using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Body
{
	public partial class ArgumentBufferTemplate
	{
		/// <summary>
		/// The target function of argument.
		/// </summary>
		public Function Function { get; set; } = new Function();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ArgumentBufferTemplate() : base()
		{
			Function = new Function();
		}
	}
}
