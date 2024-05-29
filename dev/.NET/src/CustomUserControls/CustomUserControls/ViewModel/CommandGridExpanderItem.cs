using System;
using System.Collections.Generic;
using System.Configuration;
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

		long data;

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

	public class CommandGridExpanderItem<T> : ViewModelBase where T : struct
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

		protected T _item;
		public T Item
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
