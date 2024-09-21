//using DialogUserInterfaceSamples.Command;
using DialogUserInterfaces;
using DialogUserInterfaces.ViewModel;
using DialogUserInterfaces.Command;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO.Packaging;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using DialogUserInterfaces.View;

namespace DialogUserInterfaceSamples.ViewModel
{
	internal class MainWindowViewModel : ViewModelBase
	{
		protected string _title = "DialogUserInterfaceSamples";
		public string Title
		{
			get => _title;
		}

		protected string _eventTitle = "By event";
		public string EventTitle
		{
			get => _eventTitle;
		}

		protected string _commandTitle = "By command";
		public string CommandTitle
		{
			get => _commandTitle;
		}

		protected string _userInputText = string.Empty;
		public string UserInputText
		{
			get => _userInputText;
			set
			{
				_userInputText = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainWindowViewModel() : base() { }

		protected DelegateCommand? _showDialogCommand = null;
		public DelegateCommand ShowFolderSelectCommand
		{
			get
			{
				if (null == _showDialogCommand)
				{
					_showDialogCommand = new DelegateCommand(ShowFolderSelectCommandExecute);
				}
				return _showDialogCommand;
			}
		}

		protected DelegateCommand? _showFileSelectDialogCommand = null;
		public DelegateCommand ShowFileSelectDialogCommand
		{
			get
			{
				if (null == _showDialogCommand)
				{
					_showDialogCommand = new DelegateCommand(ShowFileSelectCommandExecute);
				}
				return _showDialogCommand;
			}
		}

		public void ShowFolderSelectCommandExecute()
		{
			ShowDialogCommandExecute(DialogUserInterfaces.Mode.DIALOG_FOLDER_SELECT);
		}

		public void ShowFileSelectCommandExecute()
		{
			ShowDialogCommandExecute(DialogUserInterfaces.Mode.DIALOG_FILE_SELECT);
		}

		protected void ShowDialogCommandExecute(int mode)
		{
			var dialog = new DialogUserInterfaces.View.PathSelectionDialog(mode);

			if (true == dialog.ShowDialog())
			{
				UserInputText = dialog.Path;
			}
		}

		protected DelegateCommand? _numericCommand = null;
		public DelegateCommand NumerciCommand
		{
			get
			{
				if (null == _numericCommand)
				{
					_numericCommand = new DelegateCommand(NumericCommandExecute);
				}
				return _numericCommand;
			}
		}

		protected void NumericCommandExecute()
		{
			Int64 initialValue = 0;
			try
			{
				initialValue = Convert.ToInt64(UserInputText);
			}
			catch (Exception ex)
			when ((ex is FormatException) || (ex is FormatException))
			{
				initialValue = 0;
			}

			var dialog = new NumericSelectionDialog(initialValue);
			if (true == dialog.ShowDialog())
			{
				UserInputText = dialog.InputValue.ToString();
			}
		}

		protected DelegateCommand? _buttonListBoxViewCommand = null;
		public DelegateCommand ButtonListBoxViewCommand
		{
			get
			{
				if (null == _buttonListBoxViewCommand)
				{
					_buttonListBoxViewCommand = new DelegateCommand(ButtonListBoxViewCommandExecute);
				}
				return _buttonListBoxViewCommand;
			}
		}

		protected void ButtonListBoxViewCommandExecute()
		{
			var parameters = new List<string>();
			var command = new DialogUserInterfaces.Command.MultiPathSelectionCommand();
			IEnumerable<string> results = command.Execute(parameters);
		}

		protected DelegateCommand? _multiLineInputCommand = null;
		public DelegateCommand MultiLineInputCommand
		{
			get
			{
				if (null == _multiLineInputCommand)
				{
					_multiLineInputCommand = new DelegateCommand(ButtonMultiLineInputCommandExecute);
				}
				return _multiLineInputCommand;
			}
		}

		protected void ButtonMultiLineInputCommandExecute()
		{
			var parameter = UserInputText;
			var command = new DialogUserInterfaces.Command.MultiPathInputCommand();
			string result = command.Execute(parameter);

			UserInputText = result;
		}

	}
}
