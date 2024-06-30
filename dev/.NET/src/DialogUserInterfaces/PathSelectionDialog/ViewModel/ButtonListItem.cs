using DialogUserInterfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogUserInterfaces.ViewModel
{
    internal class ButtonListItem : ViewModelBase
    {
		protected string _inputItem = string.Empty;

		public string InputItem
		{
			get => _inputItem;
			set
			{
				_inputItem = value;
				RaisePropertyChange();
			}
		}

		protected DelegateCommand? _command = null;
		public DelegateCommand Command
		{
			get
			{
				if (null == _command)
				{
					_command = new DelegateCommand(ExecuteCommand);
				}
				return _command;
			}
		}

		public virtual void ExecuteCommand()
		{

		}
    }
}
