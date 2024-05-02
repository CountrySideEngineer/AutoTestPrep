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
		protected Int64 _inputValue = 0;

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


		public Int64 _InputValue
		{
			get => _inputValue;
			set
			{
				_inputValue = value;
				RaisePropertyChange();
			}
		}

		protected DelegateCommand? _upCommand = null;
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

		protected DelegateCommand? _downCommand = null;
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

		public void UpCommandExecute()
		{
			if (_inputValue != Int64.MaxValue)
			{
				_inputValue++;
				RaisePropertyChange(nameof(InputValue));
			}
		}

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
