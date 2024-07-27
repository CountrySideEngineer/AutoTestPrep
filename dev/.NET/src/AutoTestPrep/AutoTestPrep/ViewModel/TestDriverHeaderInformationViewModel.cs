using AutoTestPrep.Command;
using CustomUserControls.ViewModel;

namespace AutoTestPrep.ViewModel
{
    internal class TestDriverHeaderInformationViewModel : HeaderInformationViewModel
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestDriverHeaderInformationViewModel() : base()
		{
			CategoryName = Properties.Resources.IDS_HEADER_INFORMATION_OF_DRIVER;

			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_HEADER_INFORMATION_STANDARD_HEADERS_OF_DRIVER,
					Item = string.Empty,
					CustomCommand = new FileInputCommand()
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_HEADER_INFORMATION_USER_HEADERS_OF_DRIVER,
					Item = string.Empty,
					CustomCommand = new FileInputCommand()
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_HEADER_INFORMATION_HEADER_INCLUDE_DIRS_OF_DRIVER,
					Item = string.Empty
				}
			};
		}
    }
}
