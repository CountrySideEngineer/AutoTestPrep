using CustomUserControls;
using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReader.Model;

namespace AutoTestPrep.ViewModel
{
	internal sealed class FunctionTreeNodeViewModel : TreeNodeBaseViewModel
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public FunctionTreeNodeViewModel() : base() { }

		public CommandGridExpanderViewModel? FunctionInformation { get; set; } = null;
	}
}
