namespace TestParser.Reader
{
	public interface IReader
	{
		/// <summary>
		/// Read object from path.
		/// </summary>
		/// <param name="path">Path to read.</param>
		/// <returns>Read object.</returns>
		object Read(string path);

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
		/// Read object from path.
		/// </summary>
		/// <param name="path">Path to read.</param>
		/// <returns>Read object.</returns>
		T Read(string path);

		/// <summary>
		/// Read object from stream.
		/// </summary>
		/// <param name="stream">Path to stream.</param>
		/// <returns>Read object.</returns>
		T Read(Stream stream);
	}
}
