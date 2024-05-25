using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CustomUserControls.ViewModel
{
    public class CommandGridExpanderItem : ViewModelBase
    {
		protected string _title = string.Empty;
		public string Title
		{
			get => _title;
			set
			{
				_title = value;
				RaisePropertyChanged();
			}
		}

		protected string _item = string.Empty;
		public string Item
		{
			get => _item;
			set
			{
				_item = value;
				RaisePropertyChanged();
			}
		}
    }
}
