using PathCommandLibrary;

namespace DialogUserInterfaces.ViewModel
{
	public class FolderSelectionDialogViewModel : PathSelectionDialogViewModel
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <remarks>Setup to use command to select folder.</remarks>
		public FolderSelectionDialogViewModel() : base()
		{
			PathSelect = new FolderPathSelectCommand();
		}

		/// <summary>
		/// Field of window, dialog title.
		/// </summary>
		protected new string _title = Properties.Resources.IDS_FOLDER_SELECT_WINDOW_TITLE;
	}
}
