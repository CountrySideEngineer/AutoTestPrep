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
		protected const int _tabCount = 3;
		protected const int _tabSpace = 4;
		public NameRule Rule { get; set; }
		public Function Target { get; set; }

		public string DataTypeFormat(string dataType)
		{
			string tabFormat = GetTabFormat(dataType);
			string formatted = string.Format("{0}{1}", dataType, tabFormat);

			return formatted;
		}

		protected string GetTabFormat(string input)
		{
			int len = input.Length;
			int tabCount = 0;
			if (len < (_tabCount * _tabSpace))
			{
				int spaceLen = (_tabCount * _tabSpace) - len;
				tabCount = spaceLen / _tabSpace;
				int leftSpaceLen = spaceLen % _tabSpace;
				if (0 != leftSpaceLen)
				{
					tabCount++;
				}
			}
			else
			{
				tabCount = 1;
			}
			string format = string.Empty;
			for (int index = 0; index < tabCount; index++)
			{
				format += "\t";
			}
			return format;
		}
	}
}
