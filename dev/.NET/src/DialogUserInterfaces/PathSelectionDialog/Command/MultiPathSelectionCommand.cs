using DialogUserInterfaces.View;
using DialogUserInterfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;

namespace DialogUserInterfaces.Command
{
	public class MultiPathSelectionCommand : DialogCommand<IEnumerable<string>>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathSelectionCommand() : base() { }

		/// <summary>
		/// Returns the MultiPathSelectionDialog object.
		/// </summary>
		/// <param name="parameter">Collection of string to set to the dialog.</param>
		/// <returns>MultiPathSelectionDialog object.</returns>
		protected override Window GetDialog(IEnumerable<string> parameter)
		{
			var dialog = new MultiPathSelectionDialog();
			dialog.InputPath = parameter;

			return dialog;
		}

		/// <summary>
		/// Get result of dialog user input.
		/// </summary>
		/// <param name="window">Window object user controlled.</param>
		/// <returns>Result of dialog.</returns>
		protected override IEnumerable<string> GetDialogResult(Window? window)
		{
			try
			{
				var dialog = (MultiPathSelectionDialog?)window;
				IEnumerable<string>? nullableContent = dialog?.InputPath;
				IEnumerable<string> content = nullableContent ?? new List<string>();

				return content;
			}
			catch (NullReferenceException)
			{
				throw;
			}
		}
	}
}
