namespace TestParser.Parser
{
	public abstract class AParser : IParser
	{
		/// <summary>
		/// Parse 
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public object Parse(string path)
		{
			using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			var parsedItem = Parse(stream);

			return parsedItem;
		}

		public abstract object Parse(Stream stream);
	}

	public abstract class AParser<T> : IParser<T>
	{
		public T Parse(string path)
		{
			using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			T parsedItem = Parse(stream);

			return parsedItem;
		}

		public abstract T Parse(Stream stream);
	}
}
