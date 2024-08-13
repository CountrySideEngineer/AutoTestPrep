using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Parser
{
	internal interface IParser
	{
		/// <summary>
		/// Parse file specified by argument path.
		/// </summary>
		/// <param name="path">Path to file to parse.</param>
		/// <returns>Parsed object.</returns>
		object Parse(string path);

		/// <summary>
		/// Parse file.
		/// </summary>
		/// <param name="stream">Stream to parse.</param>
		/// <returns>Parsed object.</returns>
		object Parse(Stream stream);
	}

	internal interface IParser<T>
	{
		/// <summary>
		/// Parse file specified by argument path.
		/// </summary>
		/// <param name="path">Path to file to parse.</param>
		/// <returns>Parsed object.</returns>
		T Parse(string path);

		/// <summary>
		/// Parse file.
		/// </summary>
		/// <param name="stream">Stream to parse.</param>
		/// <returns>Parsed object.</returns>
		T Parse(Stream stream);
	}
}
