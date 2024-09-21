using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestParser.Config
{
	public class FunctionTableConfig : TableConfig
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public FunctionTableConfig() : base()
		{
			TargetFunction = new FunctionConfig();
			SubFunction = new FunctionConfig();
			Variable = new VariableConfig();
		}

		/// <summary>
		/// Target function configuration.
		/// </summary>
		[XmlElement("TargetFunction")]
		public FunctionConfig TargetFunction { get; set; }

		/// <summary>
		/// Sub function configuration.
		/// </summary>
		[XmlElement("SubFunction")]
		public FunctionConfig SubFunction { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("Variable")]
		public VariableConfig Variable { get; set; }
	}
}
