namespace TestReader.Reader
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

		/// <summary>
		/// Read object from path and specified by name.
		/// </summary>
		/// <param name="path">Path to file to read.</param>
		/// <param name="name">Name to read.</param>
		/// <returns>Read object.</returns>
		object Read(string path, string name);

		/// <summary>
		/// Read object from stream and specified by name.
		/// </summary>
		/// <param name="stream">Stream to read from.</param>
		/// <param name="name">Name to read.</param>
		/// <returns>Read object.</returns>
		object Read(Stream stream, string name);
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

		/// <summary>
		/// Read object from file specified by paht and name.
		/// </summary>
		/// <param name="path">Path to read.</param>
		/// <param name="name">Name to read.</param>
		/// <returns>Read object.</returns>
		T Read(string path, string name);

		/// <summary>
		/// Read object from stream and specified by name..
		/// </summary>
		/// <param name="stream">Path to stream.</param>
		/// <param name="name">Name to read.</param>
		/// <returns>Read object.</returns>
		T Read(Stream stream, string name);
	}
}
