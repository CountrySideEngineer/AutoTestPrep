using CustomUserControls.ViewModel;
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

		public CommandGridExpanderViewModel? TestInformation { get; set; } = null;
	}
}
