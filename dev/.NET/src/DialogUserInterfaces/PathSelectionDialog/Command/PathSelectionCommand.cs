using DialogUserInterfaces.View;
using DialogUserInterfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
    public class PathSelectionCommand : DialogCommand<string>
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionCommand() : base()
		{
			_dialog = new PathSelectionDialog(Mode.DIALOG_FILE_SELECT);
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
			_dialog = new PathSelectionDialog(mode);
		}

		/// <summary>
		/// Extract result of window input.
		/// </summary>
		/// <param name="window">Window object to show as dialog.</param>
		/// <returns>Result of window, dialog, a user input.</returns>
		protected override string GetDialogResult(Window? window)
		{
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
