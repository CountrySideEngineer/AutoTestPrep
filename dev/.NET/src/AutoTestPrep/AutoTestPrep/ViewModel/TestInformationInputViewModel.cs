using AutoTestPrep.Properties;
using CustomUserControls.ViewModel;
using System.ComponentModel;

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
		public TestInformationInputViewModel() : this(-1) { }

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="index"></param>
		public TestInformationInputViewModel(int index) : base(index)
		{
			_testInOutInfo = new CommandGridExpanderViewModel();



		}

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		public string InputRootDirPath
		{
			get => _testInOutInfo.Items?.ElementAt(0).Item ?? string.Empty;
		}

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		public string OutputDirPath
		{
			get => _testInOutInfo.Items?.ElementAt(1).Item ?? string.Empty;
		}

		/// <summary>
		/// Command expander view model field.
		/// </summary>
		protected CommandGridExpanderViewModel _testInOutInfo;

		/// <summary>
		/// Command expander view model property.
		/// </summary>
		public CommandGridExpanderViewModel TestInOutInformation
		{
			get => _testInOutInfo;
		}
	}
}
