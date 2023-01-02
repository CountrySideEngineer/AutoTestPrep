using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Target
{
	public class ParameterInfo
	{
		/// <summary>
		/// Index of parameter in list.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Name of parameter.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Information about parameter.
		/// (A "function" case, this means name of sheet the datas are defined.)
		/// </summary>
		public string InfoName { get; set; }

		/// <summary>
		/// Name of file.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Path of file.
		/// </summary>
		public string FilePath { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ParameterInfo()
		{
			Index = 0;
			Name = string.Empty;
			InfoName = string.Empty;
			FileName = string.Empty;
			FilePath = string.Empty;
		}
	}
}
