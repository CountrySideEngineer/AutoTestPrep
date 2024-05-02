using PathSelectionDialog.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathSelectionDialog.ViewModel
{
	public class NumericUpDownViewModel : ViewModelBase
	{
		/// <summary>
		/// User input value field.
		/// </summary>
		protected Int64 _inputValue = 0;

		/// <summary>
		/// Inptu value property.
		/// </summary>
		public string InputValue
		{
			get
			{
				try
				{
					return _inputValue.ToString("d");
				}
				catch (FormatException)
				{
					return string.Empty;
				}
			}
			set
			{
				try
				{
					_inputValue = Convert.ToInt64(value);
				}
				catch (Exception ex)
				when ((ex is FormatException) || (ex is OverflowException))
				{
					// When convert input string to int64 data type failed,
					// The change is ignored.
				}
			}
		}

		/// <summary>
		/// Up command field.
		/// </summary>
		protected DelegateCommand? _upCommand = null;

		/// <summary>
		/// Up command property.
		/// </summary>
		public DelegateCommand UpCommand
		{
			get
			{
				if (null == _upCommand)
				{
					_upCommand = new DelegateCommand(UpCommandExecute);
				}
				return _upCommand;
			}
		}

		/// <summary>
		/// Down command field.
		/// </summary>
		protected DelegateCommand? _downCommand = null;

		/// <summary>
		/// Down command property.
		/// </summary>
		public DelegateCommand DownCommand
		{
			get
			{
				if (null == _downCommand)
				{
					_downCommand = new DelegateCommand(DownCommandExecute);
				}
				return _downCommand;
			}
		}

		/// <summary>
		/// Execute command to increment input value.
		/// </summary>
		public void UpCommandExecute()
		{
			if (_inputValue != Int64.MaxValue)
			{
				_inputValue++;
				RaisePropertyChange(nameof(InputValue));
			}
		}

		/// <summary>
		/// Execute command to decrement input value.
		/// </summary>
		public void DownCommandExecute()
		{
			if (_inputValue != Int64.MinValue)
			{
				_inputValue--;
				RaisePropertyChange(nameof(InputValue));
			}
		}

	}
}
