using AutoTestPrep.Command;
using AutoTestPrep.Properties;
using CustomUserControls.ViewModel;
using System.ComponentModel;
using System.Windows.Controls.Primitives;

namespace AutoTestPrep.ViewModel
{
	/// <summary>
	/// View model about test information input view.
	/// </summary>
	internal class TestInformationInputViewModel : AutoTestPrepViewModelBase
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TestInformationInputViewModel() : base()
		{
			CategoryName = Properties.Resources.IDS_TEST_INFO_CATEGORY_NAME;

			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_TEST_SPEC_FILE_PATH,
					Item = string.Empty,
					CustomCommand = new PathSelectionCommand()
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_TEST_INFO_OUTPUT_DIR_PATH,
					Item = string.Empty,
					CustomCommand = new PathSelectionCommand()
				}
			};
		}

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		public string TestSpecFilePath
		{
			get
			{
				if (null == Items)
				{
					return string.Empty;
				}
				else
				{
					return Items.ElementAt(0).Item.ToString();
				}
			}
		}

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		public string OutputDirPath
		{
			get
			{
				if (null == Items)
				{
					return string.Empty;
				}
				else
				{
					return Items.ElementAt(1).Item.ToString();
				}
			}
		}
	}
}
