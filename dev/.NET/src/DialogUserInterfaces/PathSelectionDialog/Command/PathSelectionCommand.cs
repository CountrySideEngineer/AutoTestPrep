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
		public PathSelectionCommand() : base() { }

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
