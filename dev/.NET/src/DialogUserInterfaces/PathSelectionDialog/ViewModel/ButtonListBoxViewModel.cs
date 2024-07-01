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
		protected IEnumerable<ButtonListItem> _items = new List<ButtonListItem>();

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

		/// <summary>
		/// Selected item field.
		/// </summary>
		protected string? _selectedItem;

		/// <summary>
		/// Selected item property.
		/// </summary>
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
		public ButtonListBoxViewModel() : base()
		{
			Items = new List<ButtonListItem>()
			{
				new ButtonListItem()
				{
					InputItem = "Sample input text box item 001"
				},
				new ButtonListItem()
				{
					InputItem = "Sample input text box item 002"
				}
			};
		}
    }
}
