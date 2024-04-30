using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Parser
{
	interface IParser<T>
	{
		/// <summary>
		/// Interface of test parser.
		/// </summary>
		/// <param name="srcPath">Path to file to parse.</param>
		/// <returns>Result of parse.</returns>
		T Parse(string srcPath);

		/// <summary>
		/// Interface of test parser.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns></returns>
		T Parse(Stream stream);
	}
}
