using System.Data;

namespace TestReader.Converter
{
	internal interface ITableConverter
	{
		/// <summary>
		/// Convert data in DataTable object into other object.
		/// </summary>
		/// <param name="data">Data to convert.</param>
		/// <returns>Converted object.</returns>
		object Convert(DataTable data);
	}

	internal interface ITableConverter<T>
	{
		/// <summary>
		/// Convert data in DataTable object into ohter object T.
		/// </summary>
		/// <param name="data">Data to covnert.</param>
		/// <returns>Converted object in type T.</returns>
		T Convert(DataTable data);
	}
}
