using CustomUserControls.Command;
using Logger;
using System.Diagnostics;
using System.Windows;

namespace CustomUserControls.ViewModel
{
    public class CommandGridExpanderItem : ViewModelBase
    {
		public CommandGridExpanderItem() : base() { }

		public ICustomUserCommand<string>? CustomCommand { get; set; }

		protected string _title = string.Empty;
		public string Title
		{
			get => _title;
			set
			{
				_title = value;
				RaisePropertyChanged();
			}
		}

		protected string _item = string.Empty;
		public string Item
		{
			get => _item;
			set
			{
				_item = value;
				RaisePropertyChanged();
			}
		}

		protected DelegateCommand? _command;
		public DelegateCommand Command
		{
			get
			{
				if (null == _command)
				{
					_command = new DelegateCommand(CommandExecute);
				}
				return _command;
			}
		}

		public virtual void CommandExecute()
		{
			Log.TRACE();
			Log.DEBUG($"{Title} command executed.");

			string itemBak = Item;
			Item = CustomCommand?.Execute(itemBak) ?? itemBak;
		}
	}

	public class CommandGridExpanderItem<T> : ViewModelBase where T : new()
	{
		public ICustomUserCommand<T>? CustomCommand { get; set; }

		protected string _title = string.Empty;
		public string Title
		{
			get => _title;
			set
			{
				_title = value;
				RaisePropertyChanged();
			}
		}

		protected T _item = new();
		public T Item
		{
			get => _item;
			set
			{
				_item = value;
				RaisePropertyChanged();
			}
		}

		protected DelegateCommand? _command;
		public DelegateCommand Command
		{
			get
			{
				if (null == _command)
				{
					_command = new DelegateCommand(CommandExecute);
				}
				return _command;
			}
		}

		public virtual void CommandExecute()
		{
			Log.TRACE();
			Log.DEBUG($"{Title} command executed.");

			if (null != CustomCommand)
			{
				T itemBak = Item;
				Item = CustomCommand.Execute(itemBak);
			}
		}
	}
}
