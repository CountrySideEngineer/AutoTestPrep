using DialogUserInterfaces.View;
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

namespace DialogUserInterfaces
{
	/// <summary>
	/// NumericSelectionDialog.xaml の相互作用ロジック
	/// </summary>
	public partial class NumericSelectionDialog : Window
	{
		public NumericSelectionDialog()
		{
			InitializeComponent();
		}

		public NumericSelectionDialog(Int64 inputValue)
		{
			InitializeComponent();

			((NumericSelectionDialogViewModel)DataContext).InputValue = inputValue;
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

		/// <summary>
		/// User input value.
		/// </summary>
		public Int64 InputValue
		{
			get
			{
				return ((NumericSelectionDialogViewModel)DataContext).InputValue;
			}
		}
	}
}
