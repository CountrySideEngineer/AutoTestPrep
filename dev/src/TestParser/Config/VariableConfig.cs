using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestParser.Config
{
	public class VariableConfig
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public VariableConfig()
		{
			Category = string.Empty;
			External = string.Empty;
			Internal = string.Empty;
		}

		/// <summary>
		/// Category tag content
		/// </summary>
		[XmlElement("Category")]
		public string Category { get; set; }

		/// <summary>
		/// Global variable type, defined out of the file the target function is implemented.
		/// </summary>
		[XmlElement("External")]
		public string External { get; set; }

		/// <summary>
		/// Gloval variable type, define in the file the target function is implemented.
		/// </summary>
		[XmlElement("Internal")]
		public string Internal { get; set; }
	}
}
