using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
	public class NumericSelectionCommand : DialogCommand<long>
	{
		public NumericSelectionCommand() : base()
		{
			_dialog = new NumericSelectionDialog();
		}

		protected override long GetDialogResult(Window? window)
		{
			long result = ((NumericSelectionDialog)_dialog).InputValue;

			return result;
		}

		public override long Execute(long parameter)
		{
			((NumericSelectionDialog)_dialog).InputValue = parameter;

			return base.Execute(parameter);
		}
	}
}
