using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
