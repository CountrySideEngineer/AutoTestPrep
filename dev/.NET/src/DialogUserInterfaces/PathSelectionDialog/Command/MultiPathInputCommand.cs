using DialogUserInterfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
	public class MultiPathInputCommand : DialogCommand<string>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathInputCommand() : base() { }

		/// <summary>
		/// Returns the MultiPathInputDialog object.
		/// </summary>
		/// <param name="parameter">Parameter to set to the dialog.</param>
		/// <returns>MultiPathInputDialog object.</returns>
		protected override Window GetDialog(string parameter)
		{
			var dialog = new MultiPathInputDialog();
			dialog.Path = parameter;

			return dialog;
		}

		/// <summary>
		/// Get the result of user input.
		/// </summary>
		/// <param name="window">Window object user controlled.</param>
		/// <returns>Result of the dialog.</returns>
		protected override string GetDialogResult(Window window)
		{
			try
			{
				var dialog = (MultiPathInputDialog)window;
				string path = dialog.Path;
				return path;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
