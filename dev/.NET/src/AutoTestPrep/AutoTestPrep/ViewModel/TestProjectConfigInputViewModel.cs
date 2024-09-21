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
		public TestInformationInputViewModel TestInformation { get; set; }

		public BufferSizeViewModel TestDoubleInformation { get; set; }

		public TestDriverHeaderInformationViewModel HeaderInDriverInformation { get; set; }

		public TestStubHeaderInformationViewModel HeaderInTestDoubleInformation { get; set; }

		public LibraryInformationViewModel LibraryInformation { get; set; }

		public MacroInformationViewModel MacroInformation { get; set; }

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
