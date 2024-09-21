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
using System.Windows.Shapes;

namespace DialogUserInterfaces.View
{
    /// <summary>
    /// MultiPathInputDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class MultiPathInputDialog : Window
    {
        public MultiPathInputDialog()
        {
            InitializeComponent();
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
		public string Path
		{
			get
			{
				if (null != DialogResult)
				{
					if (DialogResult == true)
					{
						string path = ((MultiPathInputViewModel)DataContext).GetContent();
						return path;
					}
					else
					{
						return string.Empty;
					}
				}
				else
				{
					return string.Empty;
				}
			}
			set
			{
				var viewModel = (MultiPathInputViewModel)DataContext;
				viewModel.SetContent(value);
			}
		}
    }
}
