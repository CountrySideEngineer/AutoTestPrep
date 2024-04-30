using DialogUserInterfaceSamples.Command;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO.Packaging;
using System.Linq;
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

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainWindowViewModel() : base() { }

		protected DelegateCommand? _showDialogCommand = null;
		public DelegateCommand ShowDialogCommand
		{
			get
			{
				if (null == _showDialogCommand)
				{
					_showDialogCommand = new DelegateCommand(ShowDialogCommandExecute);
				}
				return _showDialogCommand;
			}
		}

		public void ShowDialogCommandExecute()
		{
			var dialog = new PathSelectionDialog.PathSelectionDialog();
			dialog.Show();
		}
	}
}
