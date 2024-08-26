using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class TreeNodeBaseViewModel : ViewModelBase
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TreeNodeBaseViewModel() : base() { }

		/// <summary>
		/// Title of tree node.
		/// </summary>
		public string Title { get; set; } = string.Empty;
	}
}
