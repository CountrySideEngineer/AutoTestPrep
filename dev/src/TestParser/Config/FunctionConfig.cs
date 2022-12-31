using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestParser.Config
{
	/// <summary>
	/// Function configuration.
	/// </summary>
	public class FunctionConfig
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public FunctionConfig()
		{
			Category = string.Empty;
			Function = string.Empty;
			Argument = string.Empty;
		}

		/// <summary>
		/// Category tag content.
		/// </summary>
		[XmlElement("Category")]
		public string Category { get; set; }

		/// <summary>
		/// Function tag content.
		/// </summary>
		[XmlElement("Function")]
		public string Function { get; set; }

		/// <summary>
		/// Argument tag argument.
		/// </summary>
		[XmlElement("Argument")]
		public string Argument { get; set; }
	}
}
