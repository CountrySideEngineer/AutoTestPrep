using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class MacroInformationViewModel : AutoTestPrepViewModelBase
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MacroInformationViewModel() : base()
		{
			CategoryName = Properties.Resources.IDS_MACRO;

			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_MACRO
				}
			};
		}
	}
}
