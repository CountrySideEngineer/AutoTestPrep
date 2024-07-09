using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
	public abstract class DialogCommand<T> : IDialogCommand<T>
	{
		/// <summary>
		/// Field of an object Window class inherits.
		/// </summary>
		protected Window? _dialog = null;

		/// <summary>
		/// Default constructor
		/// </summary>
		public DialogCommand() { }

		/// <summary>
		/// Destructor
		/// </summary>
		~DialogCommand()
		{
			Debug.WriteLine("DialogCommand destructor called.");

			_dialog = null;
		}

		protected abstract T GetDialogResult(Window? window);

		/// <summary>
		/// Execute command to show and get result of 
		/// </summary>
		/// <param name="parameter">Parameter to set to dialog.</param>
		/// <returns>Result of dialog.</returns>
		public virtual T Execute(T parameter)
		{
			try
			{
				bool? dlgResult = (null == _dialog) ? false : _dialog.ShowDialog();
				if (null == dlgResult)
				{
					return parameter;
				}
				else
				{
					if (dlgResult.Value)
					{
						T resultData = GetDialogResult(window: _dialog);

						return resultData;
					}
					else
					{
						return parameter;
					}
				}
			}
			finally
			{
				_dialog = null;
			}
		}
	}
}
