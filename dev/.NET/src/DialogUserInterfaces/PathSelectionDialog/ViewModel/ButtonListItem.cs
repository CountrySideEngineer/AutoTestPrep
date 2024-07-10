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
		/// <summary>
		/// Command to be executed when button in list view clicked.
		/// </summary>
		public IDialogCommand<string>? ItemCommand { get; set; } = null;

		/// <summary>
		/// User input field.
		/// </summary>
		protected string _inputItem = string.Empty;

		/// <summary>
		/// User input item property.
		/// </summary>
		public string InputItem
		{
			get => _inputItem;
			set
			{
				_inputItem = value;
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Delegate command.
		/// </summary>
		protected DelegateCommand? _command = null;

		/// <summary>
		/// Delegate command.
		/// </summary>
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

		/// <summary>
		/// Executed command.
		/// </summary>
		public virtual void ExecuteCommand()
		{
			string? inputItem = ItemCommand?.Execute(InputItem);
			InputItem = inputItem ?? string.Empty;
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ButtonListItem() : base() { }
    }
}
