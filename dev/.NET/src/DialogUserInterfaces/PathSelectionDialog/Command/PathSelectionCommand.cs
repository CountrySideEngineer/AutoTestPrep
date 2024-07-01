using DialogUserInterfaces.View;
using DialogUserInterfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogUserInterfaces.Command
{
    public class PathSelectionCommand : IDialogCommand<string>
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionCommand() { }

		/// <summary>
		/// Show PathSelection dialog and return the path selected in the dialog.
		/// </summary>
		/// <param name="parameter">Default command value.</param>
		/// <returns>Selected path in the dialog.</returns>
		public string Execute(string parameter)
		{
			var dialog = new PathSelectionDialog();
			bool? result = dialog.ShowDialog();

			if (null == result)
			{
				return parameter;
			}
			else
			{
				if (result.Value)
				{
					var viewModel = (PathSelectionDialogViewModel)dialog.DataContext;
					var selectedPath = viewModel.InputPath;

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
