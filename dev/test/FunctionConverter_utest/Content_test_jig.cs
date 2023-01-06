using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;

namespace FunctionConverter_utest
{
	public class Content_test_jig : Content
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public Content_test_jig() : base()
		{
			_tableContent = new List<List<string>>();
		}

		public void AddRow(IEnumerable<string> newRow)
		{
			try
			{
				_tableContent = _tableContent.Append(newRow);
			}
			catch (NullReferenceException)
			{
				_tableContent = new List<List<string>>();
				_tableContent = _tableContent.Append(newRow);
			}

		}
	}
}
