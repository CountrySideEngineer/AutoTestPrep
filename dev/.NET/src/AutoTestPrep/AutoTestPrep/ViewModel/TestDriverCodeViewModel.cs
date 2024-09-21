using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class TestDriverCodeViewModel : CommandGridExpanderViewModel
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestDriverCodeViewModel() : base() { }

		/// <summary>
		/// Test driver code.
		/// </summary>
		public string TestCode { get; set; } = string.Empty;
	}
}
