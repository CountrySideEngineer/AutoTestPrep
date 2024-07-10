using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
	public class NumericSelectionCommand : DialogCommand<long>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NumericSelectionCommand() : base() { }

		/// <summary>
		/// Returns the NumericSelectionDialog object.
		/// </summary>
		/// <param name="parameter">Parameter to input the generated dialog.</param>
		/// <returns>NumericSelectionDialog object.</returns>
		protected override Window GetDialog(long parameter)
		{
			var dialog = new NumericSelectionDialog();
			dialog.InputValue = parameter;
			return dialog;
		}

		/// <summary>
		/// Returns value the user input into the dialog.
		/// </summary>
		/// <param name="window">NumericSelectionDialog object.</param>
		/// <returns>The value the user input.</returns>
		protected override long GetDialogResult(Window window)
		{
			NumericSelectionDialog dialog = (NumericSelectionDialog)window;
			long result = dialog.InputValue;

			return result;
		}
	}
}
