using AutoTestPrep.Properties;
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
		public TestInformationInputViewModel(int index) : base(index) { }

		/// <summary>
		/// Path to directory which contains source code files to analysis.
		/// </summary>
		protected string _inputRootDirPath = string.Empty;

		/// <summary>
		/// Path to directory which contains source code files to analysis.
		/// </summary>
		public string InputRootDirPath
		{
			get => _inputRootDirPath;
			set
			{
				_inputRootDirPath = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		protected string _outputDirPath = string.Empty;

		/// <summary>
		/// Path to directory to output test codes.
		/// </summary>
		public string OutputDirPath
		{
			get => _outputDirPath;
			set
			{
				_outputDirPath = value;
				RaisePropertyChanged();
			}
		}
	}
}
