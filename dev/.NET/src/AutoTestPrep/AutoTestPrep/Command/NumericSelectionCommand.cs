using CustomUserControls.Command;
using DialogUserInterfaces;
using DialogUserInterfaces.ViewModel;
using Logger;

namespace AutoTestPrep.Command
{
	internal class NumericSelectionCommand : ICustomUserCommand<long>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NumericSelectionCommand() { }

		/// <summary>
		/// Select numeric number.
		/// </summary>
		/// <param name="parameter">Command parameter.</param>
		/// <returns>User input or selected value.</returns>
		public long Execute(long parameter)
		{
			Log.TRACE();

			var selectionView = new NumericSelectionDialog(parameter);
			bool? dialogResult = selectionView.ShowDialog();

			if (dialogResult is null)
			{
				return parameter;
			}
			else
			{
				if (dialogResult.Value)
				{
					var context = (NumericSelectionDialogViewModel)selectionView.DataContext;
					var selectedValue = context.InputValue;

					return selectedValue;
				}
				else
				{
					return parameter;
				}
			}
		}
	}
}
