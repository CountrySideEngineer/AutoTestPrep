namespace TestParser.Reader
{
	public interface IReader
	{
		/// <summary>
		/// Read object specified by name.
		/// </summary>
		/// <param name="name">Name to read.</param>
		/// <returns>Read object.</returns>
		object Read(string name);

		/// <summary>
		/// Read object from stream.
		/// </summary>
		/// <param name="stream">Path to stream.</param>
		/// <returns>Read object.</returns>
		object Read(Stream stream);
	}

	public interface IReader<T>
	{
		/// <summary>
		/// Read object specified by name.
		/// </summary>
		/// <param name="name">Name to read.</param>
		/// <returns>Read object.</returns>
		T Read(string name);

		/// <summary>
		/// Read object from stream.
		/// </summary>
		/// <param name="stream">Path to stream.</param>
		/// <returns>Read object.</returns>
		T Read(Stream stream);
	}
}
