using Accessibility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogUserInterfaces.ViewModel
{
    internal class ButtonListBoxViewModel : ViewModelBase
    {
		/// <summary>
		/// Field of items to be displayed in list box view.
		/// </summary>
		protected IEnumerable<ButtonListItem> _items = new List<ButtonListItem>()
		{
			new ButtonListItem()
			{
				InputItem = "sample input text box."
			},
			new ButtonListItem()
			{
				InputItem = "sample input text box 002."
			},
		};

		/// <summary>
		/// Items to be displayed in list box view.
		/// </summary>
		public IEnumerable<ButtonListItem> Items
		{
			get => _items;
			set
			{
				_items = value;
				RaisePropertyChange();
			}
		}

		protected string? _selectedItem;

		public string? SelectedItem
		{
			get => _selectedItem;
			set
			{
				_selectedItem = value;
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ButtonListBoxViewModel() : base() { }
    }
}
