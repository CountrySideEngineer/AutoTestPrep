using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
    internal class TestStubHeaderInformationViewModel : AutoTestPrepViewModelBase
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestStubHeaderInformationViewModel() : base()
		{
			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_HEADER_INFORMATION_STANDARD_HEADERS_OF_STUB
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_HEADER_INFORMATION_USER_HEADERS_OF_STUB
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_HEADER_INFORMATION_HEADER_INCLUDE_DIRS_OF_STUB
				}
			};
		}
	}
}
