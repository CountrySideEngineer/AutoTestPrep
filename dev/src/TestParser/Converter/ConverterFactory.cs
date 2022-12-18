using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Config;

namespace TestParser.Converter
{
	public class ConverterFactory
	{
		public virtual AFunctionTableItemConverter Create(IEnumerable<string> items)
		{
			return null;
		}
	}
}
