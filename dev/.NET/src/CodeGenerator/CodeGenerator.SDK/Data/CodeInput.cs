using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace CodeGenerator.SDK.Data
{
	public class CodeInput
	{
		/// <summary>
		/// Code configuration.
		/// </summary>
		public CodeConfiguration Configuration { get; set; } = new CodeConfiguration();

		/// <summary>
		/// Test design data.
		/// </summary>
		public TestComponent? TestDesignData { get; set; } = null;

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <remarks>
		/// Prevent user from instansing the object without parameter.
		/// </remarks>
		protected CodeInput() { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="testDesign">Test design data.</param>
		public CodeInput(TestComponent testDesign)
		{
			Configuration = new CodeConfiguration();
			TestDesignData = testDesign;
		}
	}
}
