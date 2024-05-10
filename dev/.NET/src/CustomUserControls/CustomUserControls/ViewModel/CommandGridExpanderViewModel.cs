using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		/// Default constructor.
		/// </summary>
		public CommandGridExpanderViewModel() : base() { }
    }
}
