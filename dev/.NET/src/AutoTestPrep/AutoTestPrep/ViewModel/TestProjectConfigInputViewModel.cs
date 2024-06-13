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

		public CommandGridExpanderViewModel TestDoubleInformation { get; set; }

		public CommandGridExpanderViewModel HeaderinDriverInformation { get; set; }

		public CommandGridExpanderViewModel HeaderInTestDoubleInformation { get; set; }

		public CommandGridExpanderViewModel LibraryInformation { get; set; }

		public CommandGridExpanderViewModel MacroInformation { get; set; }

		public TestProjectConfigInputViewModel()
		{
			TestInformation = new TestInformationInputViewModel();
			TestDoubleInformation = new BufferSizeViewModel();
			HeaderinDriverInformation = new TestDriverHeaderInformationViewModel();
			HeaderInTestDoubleInformation = new TestStubHeaderInformationViewModel();
			LibraryInformation = new LibraryInformationViewModel();
			MacroInformation = new MacroInformationViewModel();
		}
	}
}
