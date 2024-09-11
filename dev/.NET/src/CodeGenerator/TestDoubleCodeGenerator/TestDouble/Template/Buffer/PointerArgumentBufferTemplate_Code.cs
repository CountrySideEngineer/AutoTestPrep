using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDoubleCodeGenerator.Rule;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Buffer
{
	public partial class PointerArgumentBufferTemplate
	{
		/// <summary>
		/// Default template.
		/// </summary>
		public PointerArgumentBufferTemplate() : base()
		{
			Target = new Function();
		}
	}
}
