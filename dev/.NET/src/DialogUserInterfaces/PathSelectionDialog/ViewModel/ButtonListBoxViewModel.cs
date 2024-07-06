using Accessibility;
using DialogUserInterfaces.Command;
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
			// Set sample content.
			SetContent(new List<string>()
			{
				"Sample input text box item 001",
				"Sample input text box item 002"
			});
		}

		/// <summary>
		/// Set conteont.
		/// </summary>
		/// <param name="items">Content to set.</param>
		public virtual void SetContent(IEnumerable<string> items)
		{
			var newItems = new List<ButtonListItem>();
			foreach (var item in items)
			{
				var newItem = new ButtonListItem()
				{
					InputItem = item,
					ItemCommand = new PathSelectionCommand()
				};
				newItems.Add(newItem);
			}
			Items = newItems;
		}
    }
}
