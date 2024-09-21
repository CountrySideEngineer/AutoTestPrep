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
			pathSelectView.Title = Properties.Resources.IDS_SELECT_TEST_SPEC_FILE_DIALOG_TITLE;
			bool? dialogResult = pathSelectView.ShowDialog();

			if (dialogResult is null)
			{
				Log.DEBUG("Path selection failed.");

				return parameter;
			}
			else
			{
				if (dialogResult.Value)
				{
					Log.DEBUG("Path selected.");

					var context = (PathSelectionDialogViewModel)pathSelectView.DataContext;
					var selectedPath = context.InputPath;

					Log.DEBUG($"{nameof(selectedPath),16} = {selectedPath}");

					return selectedPath;
				}
				else
				{
					Log.DEBUG("Path selection canceled..");

					return parameter;
				}
			}
		}
	}
}
