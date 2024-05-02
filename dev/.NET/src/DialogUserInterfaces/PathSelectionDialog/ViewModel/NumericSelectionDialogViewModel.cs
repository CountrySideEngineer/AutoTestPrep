using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathSelectionDialog.ViewModel
{
	public class NumericSelectionDialogViewModel : ViewModelBase
	{
		protected Int64 _inputValue = 0;
		public Int64 InputValue { 
			get => _inputValue;
			set
			{
				_inputValue = value;
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Default constructor
		/// </summary>
		public NumericSelectionDialogViewModel() : base() { }




	}
}
