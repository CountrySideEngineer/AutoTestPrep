using CustomUserControls.Command;
using DialogUserInterfaces.View;
using DialogUserInterfaces.ViewModel;

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
			var pathSelectView = new PathSelectionDialog();
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
