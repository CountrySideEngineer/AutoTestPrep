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
			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_TEST_INFO_INPUT_ROOT_DIR_PATH
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_TEST_INFO_OUTPUT_DIR_PATH
				}
			};
		}

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		public string InputRootDirPath
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
