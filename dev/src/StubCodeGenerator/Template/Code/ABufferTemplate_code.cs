using CodeGenerator.Stub.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template
{
	public partial class ABufferTemplate
	{
		public NameRule Rule { get; set; }
		public Function Target { get; set; }

		public string DataTypeFormat(string dataType)
		{
			string formatted = string.Format("{0, -20}", dataType);

			return formatted;
		}
	}
}
