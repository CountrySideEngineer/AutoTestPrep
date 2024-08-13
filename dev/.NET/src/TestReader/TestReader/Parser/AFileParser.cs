using Logger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Parser
{
	public abstract class AFileParser : IParser
	{
		public virtual object Parse(string path)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(path),12} = {path}");

			using var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			var parsedObejct = Parse(file);

			return parsedObejct;
		}

		public abstract object Parse(Stream stream);
	}

	public abstract class AFileParser<T> : IParser<T>
	{
		public virtual T Parse(string path)
		{
			Log.TRACE();
			Log.DEBUG($"{typeof(T)}");
			Log.DEBUG($"{nameof(path),12} = {path}");

			using var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			var parsedObejct = Parse(file);

			return parsedObejct;
		}

		public abstract T Parse(Stream stream);
	}
}
