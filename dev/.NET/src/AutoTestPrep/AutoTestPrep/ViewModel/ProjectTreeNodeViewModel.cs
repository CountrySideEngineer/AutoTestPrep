using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class ProjectTreeNodeViewModel : TreeNodeBaseViewModel
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProjectTreeNodeViewModel() : base() { }

		/// <summary>
		/// Collection of function tree node item view model.
		/// </summary>
		public IEnumerable<TreeNodeBaseViewModel> FunctionNodes = new List<TreeNodeBaseViewModel>();
	}
}
