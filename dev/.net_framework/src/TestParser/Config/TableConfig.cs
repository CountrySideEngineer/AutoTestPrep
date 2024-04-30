using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestParser.Config
{
	/// <summary>
	/// Configuration of table.
	/// </summary>
	public class TableConfig
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TableConfig()
		{
			Section = string.Empty;
			Title = string.Empty;
			TableTopRowOffset = 0;
			TableTopColOffset = 0;
		}

		/// <summary>
		/// Table section name.
		/// </summary>
		[XmlElement("Section")]
		public string Section { get; set; }

		/// <summary>
		/// Table title, table name.
		/// </summary>
		[XmlElement("Title")]
		public string Title { get; set; }

		/// <summary>
		/// Offset of table top in row from "name" cell.
		/// </summary>
		[XmlElement("TableTopRowOffset")]
		public int TableTopRowOffset { get; set; }

		/// <summary>
		/// Offset of table top in column from "name" cell.
		/// </summary>
		[XmlElement("TableTopColOffset")]
		public int TableTopColOffset { get; set; }
	}
}
