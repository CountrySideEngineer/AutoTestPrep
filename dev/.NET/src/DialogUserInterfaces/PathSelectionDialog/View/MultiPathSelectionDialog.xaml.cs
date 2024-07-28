using DialogUserInterfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DialogUserInterfaces.View
{
	/// <summary>
	/// MultiPathDialog.xaml の相互作用ロジック
	/// </summary>
	public partial class MultiPathSelectionDialog : Window
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathSelectionDialog() : base()
		{
			InitializeComponent();

			DataContext = new MultiPathSelectionViewModel();
		}

		/// <summary>
		/// Constructor with mode.
		/// </summary>
		/// <param name="mode">Path selection mode.</param>
		public MultiPathSelectionDialog(int mode) : base()
		{
			InitializeComponent();

			DataContext = new MultiPathSelectionViewModel(mode);
		}

		/// <summary>
		/// OK button click event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event argument.</param>
		private void OKButton_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;

			Close();
        }

		/// <summary>
		/// Cancel button click event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event argument.</param>
		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;

			Close();
		}

		/// <summary>
		/// Content of the dialog.
		/// </summary>
		public IEnumerable<string> InputPath
		{
			get
			{
				IEnumerable<string> content = ((MultiPathSelectionViewModel)DataContext).GetContent();
				return content;
			}
			set
			{
				var viewModel = (MultiPathSelectionViewModel)DataContext;
				viewModel.SetContent(value);
			}
		}
	}
}
