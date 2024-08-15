using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader.Model
{
	public class TestTargetInfo
	{
		/// <summary>
		/// Index of information.
		/// </summary>
		public int Index { get; set; } = 0;

		/// <summary>
		/// Target name.
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Target description.
		/// </summary>
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Target file name.
		/// </summary>
		public string FileName { get; set;} = string.Empty;

		/// <summary>
		/// Target file path.
		/// </summary>
		public string FilePath { get; set; } = string.Empty;
	}
}
