using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
	/// NumericUpDownControl.xaml の相互作用ロジック
	/// </summary>
	public partial class NumericUpDownControl : UserControl
	{
		public NumericUpDownControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Validate input value before set it into text box.
		/// </summary>
		/// <param name="sender">Not in use.</param>
		/// <param name="e">Argument which hold input value.</param>
		private void NumericValue_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			var reg = new Regex("[0-9]");
			if (!reg.IsMatch(e.Text))
			{
				e.Handled = true;
			}
        }
    }
}
