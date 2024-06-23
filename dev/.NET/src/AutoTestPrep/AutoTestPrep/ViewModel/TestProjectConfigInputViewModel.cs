using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class TestProjectConfigInputViewModel : AutoTestPrepViewModelBase
	{
		public CommandGridExpanderViewModel TestInformation { get; set; }

		public CommandGridExpanderViewModel<long> TestDoubleInformation { get; set; }

		public CommandGridExpanderViewModel HeaderInDriverInformation { get; set; }

		public CommandGridExpanderViewModel HeaderInTestDoubleInformation { get; set; }

		public CommandGridExpanderViewModel LibraryInformation { get; set; }

		public CommandGridExpanderViewModel MacroInformation { get; set; }

		public TestProjectConfigInputViewModel()
		{
			TestInformation = new TestInformationInputViewModel();
			TestDoubleInformation = new BufferSizeViewModel();
			HeaderInDriverInformation = new TestDriverHeaderInformationViewModel();
			HeaderInTestDoubleInformation = new TestStubHeaderInformationViewModel();
			LibraryInformation = new LibraryInformationViewModel();
			MacroInformation = new MacroInformationViewModel();
		}
	}
}
