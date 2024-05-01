using PathSelectionDialog.ViewModel;
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

namespace PathSelectionDialog
{
	/// <summary>
	/// PathSelectionDialog.xaml の相互作用ロジック
	/// </summary>
	public partial class PathSelectionDialog : Window
	{
		public PathSelectionDialog()
		{
			InitializeComponent();
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
		/// Whether user selected path or not.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				try
				{
					return ((PathSelectionDialogViewModel)DataContext).IsSelected;
				}
				catch (Exception)
				{
					return false;
				}
			}
		}
	}
}
