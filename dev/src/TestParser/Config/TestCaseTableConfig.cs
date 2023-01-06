using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestParser.Config
{
	public class TestCaseTableConfig : TableConfig
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestCaseTableConfig()
		{
			Input = string.Empty;
			Exepct = string.Empty;
		}
		/// <summary>
		/// Configuration about Input.
		/// </summary>
		[XmlElement("Input")]
		public string Input { get; set; }

		/// <summary>
		/// Configuration about Expect.
		/// </summary>
		[XmlElement("Expect")]
		public string Exepct { get; set; }
	}
}
