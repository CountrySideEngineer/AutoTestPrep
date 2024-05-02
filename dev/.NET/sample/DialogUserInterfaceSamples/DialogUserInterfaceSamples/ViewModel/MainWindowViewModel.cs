﻿using DialogUserInterfaceSamples.Command;
using PathSelectionDialog;
using PathSelectionDialog.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO.Packaging;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

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
			ShowDialogCommandExecute(PathSelectionDialog.Mode.DIALOG_FOLDER_SELECT);
		}

		public void ShowFileSelectCommandExecute()
		{
			ShowDialogCommandExecute(PathSelectionDialog.Mode.DIALOG_FILE_SELECT);
		}

		protected void ShowDialogCommandExecute(int mode)
		{
			var dialog = new PathSelectionDialog.PathSelectionDialog(mode);

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
			var dialog = new NumericSelectionDialog();
			dialog.ShowDialog();
		}
	}
}
