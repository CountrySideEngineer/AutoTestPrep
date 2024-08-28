using CustomUserControls.Command;
using DialogUserInterfaces.View;
using DialogUserInterfaces.ViewModel;
using Logger;

namespace AutoTestPrep.Command
{
	internal class PathSelectionCommand : ICustomUserCommand<string>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionCommand() { }

		/// <summary>
		/// Select folder path.
		/// </summary>
		/// <param name="parameter">Command parameter.</param>
		/// <returns>Path to folder selected by user.</returns>
		public string Execute(string parameter)
		{
			Log.TRACE();

			var pathSelectView = new PathSelectionDialog(DialogUserInterfaces.Mode.DIALOG_FILE_SELECT);
			bool? dialogResult = pathSelectView.ShowDialog();

			if (dialogResult is null)
			{
				return parameter;
			}
			else
			{
				if (dialogResult.Value)
				{
					var context = (PathSelectionDialogViewModel)pathSelectView.DataContext;
					var selectedPath = context.InputPath;

					return selectedPath;
				}
				else
				{
					return parameter;
				}
			}
		}
	}
}
