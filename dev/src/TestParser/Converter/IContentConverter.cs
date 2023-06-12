using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;

namespace TestParser.Converter
{
	public interface IContentConverter
	{
		object Convert(DataTable src);
	}
}
