using DialogUserInterfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
			InitializeComponent();

			DataContext = new FolderSelectionDialogViewModel();
		}

		public PathSelectionDialog(int mode)
		{
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
		}

		/// <summary>
		/// OK button click event handler.
		/// </summary>
		/// <param name="sender">Not in use.</param>
		/// <param name="e">Not in user.</param>
		private void OKButton_Click(object sender, RoutedEventArgs e)
		{
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
			DialogResult = false;

			Close();
		}
	}
}
