using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Parser
{
	public interface IParser
	{
		/// <summary>
		/// Parse test spec.
		/// </summary>
		/// <param name="path">Path to test spec.</param>
		/// <returns></returns>
		object Parse(string path);
	}
}
