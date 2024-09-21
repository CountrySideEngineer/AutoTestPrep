using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoTestPrep.Command
{
	public class DelegateCommand : ICommand
	{
		protected Action? _execute;
		protected Func<bool> _canExecute;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public void Execute(object? parameter)
		{
			_execute?.Invoke();
		}

		public DelegateCommand(Action? execute)
		{
			_execute = execute;
			_canExecute = () => { return true; };
		}

		public DelegateCommand(Action execute, Func<bool> canExecute)
		{
			_execute = execute;
			_canExecute = canExecute;
		}
	}

	public class DelegateCommand<T> : ICommand
	{
		protected Action<T>? _execute;
		protected Func<bool> _canExecute;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public void Execute(object? parameter)
		{
			_execute?.Invoke((T)parameter);
		}

		public DelegateCommand(Action<T>? execute)
		{
			_execute = execute;
			_canExecute = () => { return true; };
		}

		public DelegateCommand(Action<T> execute, Func<bool> canExecute)
		{
			_execute = execute;
			_canExecute = canExecute;
		}
	}
}
