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

		public TestProjectConfigInputViewModel? TestProjectConfig { get; set; } = null;
	}
}
