using System.Windows;
using DialogUserInterfaces.View;
using Logger;

namespace DialogUserInterfaces.Command
{
	public class MultiPathSelectionCommand : DialogCommand<IEnumerable<string>>
	{
		/// <summary>
		/// Path selection mode.
		/// </summary>
		public int Mode { get; set; } = DialogUserInterfaces.Mode.DIALOG_FILE_SELECT;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathSelectionCommand() : base() { }

		/// <summary>
		/// Constructor with path selection mode.
		/// </summary>
		/// <param name="mode">Path selectin mode.</param>
		public MultiPathSelectionCommand(int mode) : base()
		{
			Mode = mode;
		}

		/// <summary>
		/// Returns the MultiPathSelectionDialog object.
		/// </summary>
		/// <param name="parameter">Collection of string to set to the dialog.</param>
		/// <returns>MultiPathSelectionDialog object.</returns>
		protected override Window GetDialog(IEnumerable<string> parameter)
		{
			Log.TRACE();

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
			Log.TRACE();

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
