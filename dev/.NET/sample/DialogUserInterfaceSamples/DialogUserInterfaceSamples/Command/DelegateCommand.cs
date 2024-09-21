using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DialogUserInterfaceSamples.Command
{
	internal class DelegateCommand : ICommand
	{
		protected Action _execute;

		protected Func<bool> _canExecute;

		public DelegateCommand(Action execute) : this(execute, () => true) { }

		public DelegateCommand(Action execute, Func<bool> canExecute)
		{
			_execute = execute;
			_canExecute = canExecute;
		}

		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute(object? parameter)
		{
			return _canExecute();
		}

		public void Execute(object? parameter)
		{
			_execute();
		}
	}
}
