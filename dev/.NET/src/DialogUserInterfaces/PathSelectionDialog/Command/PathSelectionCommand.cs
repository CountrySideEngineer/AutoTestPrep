using DialogUserInterfaces.View;
using DialogUserInterfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
    public class PathSelectionCommand : DialogCommand<string>
    {
		protected int _mode = 0;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionCommand() : base()
		{
			_mode = Mode.DIALOG_FILE_SELECT;
		}

		/// <summary>
		/// Constructor with mode.
		/// </summary>
		/// <param name="mode">Mode of dialog.
		/// mode  shows a dialog as folder selection, and 1 shows file dialog.
		/// Others are invalid.
		/// </param>
		public PathSelectionCommand(int mode) : base()
		{
			_mode = mode;
		}

		/// <summary>
		/// Destructor.
		/// </summary>
		~PathSelectionCommand()
		{
			Debug.WriteLine("PathSelectionCommand destructor called.");

			_dialog = null;
		}

		public override string Execute(string parameter)
		{
			_dialog = new PathSelectionDialog(Mode.DIALOG_FILE_SELECT);

			return base.Execute(parameter);
		}

		/// <summary>
		/// Extract result of window input.
		/// </summary>
		/// <param name="window">Window object to show as dialog.</param>
		/// <returns>Result of window, dialog, a user input.</returns>
		protected override string GetDialogResult(Window? window)
		{
			Debug.WriteLine($"{nameof(PathSelectionCommand)}::{nameof(GetDialogResult)} called");

			try
			{
				PathSelectionDialogViewModel? viewModel = (PathSelectionDialogViewModel?)window?.DataContext;
				var selectedPath = viewModel?.InputPath;

				return selectedPath ?? string.Empty;
			}
			catch (NullReferenceException)
			{
				throw;
			}
		}
	}
}
