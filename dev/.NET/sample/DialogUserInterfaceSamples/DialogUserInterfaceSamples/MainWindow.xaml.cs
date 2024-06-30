using DialogUserInterfaces.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DialogUserInterfaceSamples
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void FolderSelectButton_Click(object sender, RoutedEventArgs e)
		{
			ShowDialog(DialogUserInterfaces.Mode.DIALOG_FOLDER_SELECT);
		}

		private void FileSelectButton_Click(object sender, RoutedEventArgs e)
		{
			ShowDialog(DialogUserInterfaces.Mode.DIALOG_FILE_SELECT);
		}

		private void ShowDialog(int mode)
		{
			var dialog = new DialogUserInterfaces.View.PathSelectionDialog(mode);
			if (true == dialog.ShowDialog())
			{
				UserInputText.Text = dialog.Path;
			}
		}
	}
}