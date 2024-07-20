using DialogUserInterfaces.Command;
using Logger;

namespace DialogUserInterfaces.ViewModel
{
    internal class ButtonListItem : ViewModelBase
    {
		public delegate string ItemCommandDelegate(string input);

		public ItemCommandDelegate? CommandDelegate { get; set; } = null;

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
			Log.TRACE();

			string? input = CommandDelegate?.Invoke(InputItem);
			InputItem = input ?? string.Empty;
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ButtonListItem() : base() { }
    }
}
