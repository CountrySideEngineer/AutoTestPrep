using Logger;
using DialogUserInterfaces.Command;
using System.Diagnostics;
using System.Reflection;

namespace DialogUserInterfaces.ViewModel
{
    internal class ButtonListBoxViewModel : ViewModelBase
    {
		/// <summary>
		/// Field of items to be displayed in list box view.
		/// </summary>
		protected IEnumerable<ButtonListItem> _items = new List<ButtonListItem>();

		/// <summary>
		/// Command to select path.
		/// </summary>
		protected IDialogCommand<string> _itemCommand = new PathSelectionCommand();

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
		/// Field of selected item in Items proeprty.
		/// </summary>
		protected ButtonListItem _selectedItem = new ButtonListItem();

		/// <summary>
		/// Property of selected item in Items property.
		/// </summary>
		public ButtonListItem SelectedItem
		{
			get => _selectedItem;
			set
			{
				// To avoid an exception detection, the old and new values are
				// checked respectively.
				if (null != _selectedItem)
				{
					_selectedItem.IsSelected = false;
				}
				if (null != value)
				{
					_selectedItem = value;
					_selectedItem.IsSelected = true;
				}
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Selected item index field.
		/// </summary>
		protected int _selectedIndex = -1;

		/// <summary>
		/// Selected item index property.
		/// </summary>
		public int SelectedIndex
		{
			get => _selectedIndex;
			set
			{
				Log.TRACE();

				if (value < 0)
				{
					Log.DEBUG($"{nameof(ButtonListBoxViewModel)}::{nameof(SelectedIndex)} is invalid, {value}");
				}
				else
				{
					_selectedIndex = value;
					RaisePropertyChange();
					Log.DEBUG($"{nameof(ButtonListBoxViewModel)}::{nameof(SelectedIndex)} = {SelectedIndex}");
				}
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ButtonListBoxViewModel() : base()
		{
			Log.TRACE();

			_itemCommand = new PathSelectionCommand(Mode.DIALOG_FILE_SELECT);
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="mode"></param>
		public ButtonListBoxViewModel(int mode) : base()
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(mode),12} = {mode}");

			_itemCommand = new PathSelectionCommand(mode);
		}

		/// <summary>
		/// Set conteont.
		/// </summary>
		/// <param name="items">Content to set.</param>
		public virtual void SetContent(IEnumerable<string> items)
		{
			Log.TRACE();
			Log.DEBUG($"items.Count() = {items.Count()}");

			var newItems = new List<ButtonListItem>();
			var notEmptyItems = items
				.Where(_ => ((!string.IsNullOrEmpty(_)) && (!string.IsNullOrWhiteSpace(_))))
				.ToList();
			foreach (var item in notEmptyItems)
			{
				var newItem = new ButtonListItem()
				{
					InputItem = item,
					ItemCommand = _itemCommand
				};
				newItems.Add(newItem);
			}
			var tailItem = new ButtonListItem()
			{
				InputItem = string.Empty,
				ItemCommand = _itemCommand
			};
			newItems.Add(tailItem);

			Items = newItems;
		}

		/// <summary>
		/// Add new item to user user input item.
		/// </summary>
		/// <param name="content">Content to add.</param>
		public virtual void AddNewItem(string content = "")
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(content),16} = {SelectedIndex}");
			Log.DEBUG($"{nameof(SelectedIndex),16} = {SelectedIndex}");

			var newList = new List<ButtonListItem>(Items);
			var newItem = new ButtonListItem()
			{
				InputItem = new string(content),
				ItemCommand = _itemCommand
			};
			try
			{
				newList.Insert((SelectedIndex + 1), newItem);
			}
			catch (ArgumentOutOfRangeException)
			{
				newList.Add(newItem);
			}
			Items = newList;
		}

		/// <summary>
		/// Remove item from user input.
		/// </summary>
		public virtual void DeleteItem()
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(SelectedIndex),16} = {SelectedIndex}");

			try
			{
				var newItems = new List<ButtonListItem>(Items);
				newItems.RemoveAt(SelectedIndex);
				Items = newItems;
				if (0 == Items.Count())
				{
					AddNewItem();
				}

				// After removing selected item in list, the object corresponding to
				// SelectedItem property has been removd at the same time.
				// It seems to be a bug that the no item is selected.
				// To avoid it, update SelectedItem property by setting an item at the SelectedIndex.
				SelectedItem = Items.ElementAt(SelectedIndex);
			}
			catch (ArgumentOutOfRangeException)
			{
				Log.WARN($"Selected item index {SelectedIndex} invalid.");
			}
		}
    }
}
