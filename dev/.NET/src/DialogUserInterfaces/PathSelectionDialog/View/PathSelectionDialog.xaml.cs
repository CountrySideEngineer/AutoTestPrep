using DialogUserInterfaces.ViewModel;
using Logger;
using System.Diagnostics;
using System.Windows;

namespace DialogUserInterfaces.View
{
	/// <summary>
	/// PathSelectionDialog.xaml の相互作用ロジック
	/// </summary>
	public partial class PathSelectionDialog : Window
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionDialog()
		{
			Log.TRACE();

			InitializeComponent();

			DataContext = new FolderSelectionDialogViewModel();
		}

		/// <summary>
		/// Constructor with mode.
		/// </summary>
		/// <param name="mode">Mode of path selection dialog.</param>
		/// <exception cref="ArgumentException">Mode is invalid.</exception>
		public PathSelectionDialog(int mode)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(mode),16} = {mode}");

			InitializeComponent();

			switch (mode)
			{
				case Mode.DIALOG_FOLDER_SELECT:
					DataContext = new FolderSelectionDialogViewModel();
					break;

				case Mode.DIALOG_FILE_SELECT:
					DataContext = new FileSelectDialogViewModel();
					break;

				default:
					throw new ArgumentException();
			}
		}

		/// <summary>
		/// Destructor
		/// </summary>
		~PathSelectionDialog() { }

		/// <summary>
		/// User selected path.
		/// </summary>
		public string Path
		{
			get
			{
				try
				{
					return ((PathSelectionDialogViewModel)DataContext).InputPath;
				}
				catch (Exception)
				{
					return string.Empty;
				}
			}
			set
			{
				PathSelectionDialogViewModel viewModel = (PathSelectionDialogViewModel)DataContext;
				viewModel.InputPath = value;
			}
		}

		/// <summary>
		/// OK button click event handler.
		/// </summary>
		/// <param name="sender">Not in use.</param>
		/// <param name="e">Not in user.</param>
		private void OKButton_Click(object sender, RoutedEventArgs e)
		{
			Log.TRACE();

			DialogResult = true;

			Close();
		}

		/// <summary>
		/// Cancel button click event handler.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			Log.TRACE();

			DialogResult = false;

			Close();
		}
	}
}
