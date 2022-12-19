using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;

namespace TestParser.Converter.Test
{
	public class TestConverter : IContentConverter
	{
		/// <summary>
		/// Convert test table data to Test object.
		/// </summary>
		/// <param name="src">Content of test table.</param>
		/// <returns>Test object converted from the Content object.</returns>
		public object Convert(Content src)
		{
			throw new NotImplementedException();
		}
	}
}
