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
    /// ButtonListBoxControl.xaml の相互作用ロジック
    /// </summary>
    public partial class ButtonListBoxControl : UserControl
    {
        public ButtonListBoxControl()
        {
            InitializeComponent();
        }

		private void TextBox_GotFocus(object sender, RoutedEventArgs e)
		{
			var parent = (Grid)(((TextBox)e.Source).Parent);
			var item = (ButtonListItem)parent.DataContext;
			item.ButtonVisibility = Visibility.Visible;
        }

		private void TextBox_LostFocus(object sender, RoutedEventArgs e)
		{
			try
			{
				var parent = (Grid)(((TextBox)e.Source).Parent);
				var item = (ButtonListItem)parent.DataContext;
				item.ButtonVisibility = Visibility.Hidden;
			}
			catch (Exception)
			{

			}
		}
	}
}
