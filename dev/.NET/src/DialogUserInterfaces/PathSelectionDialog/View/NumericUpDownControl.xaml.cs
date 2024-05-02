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

namespace PathSelectionDialog.View
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
