﻿using Accessibility;
using DialogUserInterfaces.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

		protected int _selectedIndex = 0;

		public int SelectedIndex
		{
			get => _selectedIndex;
			set
			{
				_selectedIndex = value;
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
    }
}
