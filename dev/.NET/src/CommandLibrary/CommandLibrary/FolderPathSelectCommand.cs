using Logger;

namespace PathCommandLibrary
{
	public class FolderPathSelectCommand : IPathSelectCommand
	{
		/// <summary>
		/// Select a folder by folder select dialog.
		/// </summary>
		/// <param name="initPath">Default folder dialog.</param>
		/// <returns>Selected folder path.</returns>
		/// <exception cref="InvalidOperationException">Operation canceled.</exception>
		public string Select(string initPath = "")
		{
			Log.TRACE();
			Log.DEBUG($"({nameof(initPath)}, 16) = {initPath}");

			Microsoft.Win32.OpenFolderDialog dialog = new();

			dialog.Multiselect = false;
			dialog.Title = Resources.IDS_PATH_SELECT_DIALOG_TITLE;
			if (!string.IsNullOrEmpty(initPath))
			{
				dialog.InitialDirectory = initPath;
			}
			bool? result = dialog.ShowDialog();

            if (true == result)
            {
				return dialog.FolderName;
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
	}
}
