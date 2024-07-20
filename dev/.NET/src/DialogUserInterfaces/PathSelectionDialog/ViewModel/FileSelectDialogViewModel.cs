using PathCommandLibrary;

namespace DialogUserInterfaces.ViewModel
{
	public class FileSelectDialogViewModel : PathSelectionDialogViewModel
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public FileSelectDialogViewModel() : base()
		{
			PathSelect = new FilePathSelectCommand();
		}

		/// <summary>
		/// Field of window, dialog title.
		/// </summary>
		protected new string _title = Properties.Resources.IDS_FILE_SELECT_WINDOW_TITLE;
	}
}
