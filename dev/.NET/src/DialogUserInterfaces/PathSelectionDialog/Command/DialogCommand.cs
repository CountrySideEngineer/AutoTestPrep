using System.Windows;
using Logger;

namespace DialogUserInterfaces.Command
{
	public abstract class DialogCommand<T> : IDialogCommand<T>
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public DialogCommand() { }

		/// <summary>
		/// Destructor
		/// </summary>
		~DialogCommand()
		{
			Log.DEBUG("DialogCommand destructor called.");
		}

		/// <summary>
		/// Abstract method which returns the result of dialog.
		/// </summary>
		/// <param name="window">Dialog.</param>
		/// <returns>Result of dialog.</returns>
		protected abstract T GetDialogResult(Window window);

		/// <summary>
		/// Returns a dialog object to show.
		/// </summary>
		/// <returns>A dialog object to show.</returns>
		protected abstract Window GetDialog(T parameter);

		/// <summary>
		/// Execute command to show and get result of 
		/// </summary>
		/// <param name="parameter">Parameter to set to dialog.</param>
		/// <returns>Result of dialog.</returns>
		public virtual T Execute(T parameter)
		{
			Log.TRACE();

			var dialog = GetDialog(parameter);
			bool? result = dialog.ShowDialog();
			if (null == result)
			{
				return parameter;
			}
			else
			{
				if (result.Value)
				{
					T resultData = GetDialogResult(window: dialog);

					return resultData;
				}
				else
				{
					return parameter;
				}
			}
		}
	}
}
