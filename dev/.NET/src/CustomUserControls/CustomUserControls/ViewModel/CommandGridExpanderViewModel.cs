using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CustomUserControls.ViewModel
{
    public class CommandGridExpanderViewModel : ViewModelBase
    {
		/// <summary>
		/// Category name field.
		/// </summary>
		protected string _categoryName = string.Empty;

		/// <summary>
		/// Category name property.
		/// </summary>
		public string CategoryName
		{
			get => _categoryName;
			set
			{
				_categoryName = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// The field of the collection of items to be displayed in each row of the table.
		/// </summary>
		protected IEnumerable<CommandGridExpanderItem> _items = new List<CommandGridExpanderItem>();

		/// <summary>
		/// The property of the collection of items to be displayed in each row of the table.
		/// </summary>
		public IEnumerable<CommandGridExpanderItem> Items
		{
			get => _items;
			set
			{
				_items = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CommandGridExpanderViewModel() : base() { }
    }

	public class CommandGridExpanderViewModel<T> : ViewModelBase where T : new()
	{
		/// <summary>
		/// Category name field.
		/// </summary>
		protected string _categoryName = string.Empty;

		/// <summary>
		/// Category name property.
		/// </summary>
		public string CategoryName
		{
			get => _categoryName;
			set
			{
				_categoryName = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// The field of the collection of items to be displayed in each row of the table.
		/// </summary>
		protected IEnumerable<CommandGridExpanderItem<T>> _items = new List<CommandGridExpanderItem<T>>();

		/// <summary>
		/// The property of the collection of items to be displayed in each row of the table.
		/// </summary>
		public IEnumerable<CommandGridExpanderItem<T>> Items
		{
			get => _items;
			set
			{
				_items = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CommandGridExpanderViewModel() : base() { }
	}
}
