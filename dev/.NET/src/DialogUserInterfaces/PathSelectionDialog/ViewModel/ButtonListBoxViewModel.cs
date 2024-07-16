using Accessibility;
using CSEngineer.Logger;
using DialogUserInterfaces.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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

		public ButtonListItem _selectedItem = new ButtonListItem();

		public ButtonListItem SelectedItem
		{
			get => _selectedItem;
			set
			{
				_selectedItem = value;
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
				Log.DEBUG($"{nameof(ButtonListBoxViewModel)}::{nameof(SelectedIndex)} Start!");

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
			var notEmptyItems = items
				.Where(_ => ((!string.IsNullOrEmpty(_)) && (!string.IsNullOrWhiteSpace(_))))
				.ToList();
			foreach (var item in notEmptyItems)
			{
				var newItem = new ButtonListItem()
				{
					InputItem = item,
					ItemCommand = _itemCommand,
					CommandDelegate = DelegateCommandHandler
				};
				newItems.Add(newItem);
			}
			var tailItem = new ButtonListItem()
			{
				InputItem = string.Empty,
				ItemCommand = new PathSelectionCommand(),
				CommandDelegate = DelegateCommandHandler
			};
			newItems.Add(tailItem);

			Items = newItems;
		}

		public virtual string DelegateCommandHandler(string input)
		{
			var command = new PathSelectionCommand();
			string userInput = command.Execute(input);
			string inputData = userInput ?? input;

			return inputData;
		}

		/// <summary>
		/// Add new item to user user input item.
		/// </summary>
		/// <param name="content">Content to add.</param>
		public virtual void AddNewItem(string content = "")
		{
			Log.TRACE("START!!");
			Log.DEBUG($"{"SelectedIndex", 32} = {SelectedIndex}");

			var newList = new List<ButtonListItem>(Items);
			var newItem = new ButtonListItem()
			{
				InputItem = new string(content),
				ItemCommand = _itemCommand,
				CommandDelegate = DelegateCommandHandler
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
			Log.TRACE("Start!");
			Log.DEBUG($"{"SelectedItemIndex", 32} = {SelectedIndex}");

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
