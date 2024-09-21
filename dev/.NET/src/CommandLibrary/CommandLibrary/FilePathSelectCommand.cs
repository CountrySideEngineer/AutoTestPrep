using Logger;

namespace PathCommandLibrary
{
	public class FilePathSelectCommand : IPathSelectCommand
	{
		/// <summary>
		/// Select a file by open file dialog.
		/// </summary>
		/// <param name="defaultPath">Default folder path.</param>
		/// <returns>Selected file path.</returns>
		/// <exception cref="InvalidOperationException">Operation canceled.</exception>
		public string Select(string defaultPath = "")
		{
			Log.TRACE();
			Log.DEBUG($"({nameof(defaultPath)}, 16) = {defaultPath}");

			Microsoft.Win32.OpenFileDialog dialog = new();

			dialog.Multiselect = false;
			dialog.Title = Resources.IDS_FILE_SELECT_DIALOG_TITLE;
			if (!string.IsNullOrEmpty(defaultPath))
			{
				dialog.InitialDirectory = defaultPath;
			}
			bool? result = dialog.ShowDialog();

			if (true == result)
			{
				return dialog.FileName;
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
	}
}
