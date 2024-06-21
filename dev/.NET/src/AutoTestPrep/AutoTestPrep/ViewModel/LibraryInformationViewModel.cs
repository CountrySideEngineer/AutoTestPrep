using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class LibraryInformationViewModel : AutoTestPrepViewModelBase
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		public LibraryInformationViewModel() : base()
		{
			CategoryName = Properties.Resources.IDS_LIBRARY_INFORMATION;

			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_LIBRARY_FILES
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_LIBRARY_DIRS
				},
			};
		}

		public string LibraryFile
		{
			get
			{
				return ExtractItem(0);
			}
		}

		public string LibraryDirectory
		{
			get
			{
				return ExtractItem(1);
			}
		}
    }
}
