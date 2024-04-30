using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathSelectionDialog.ViewModel
{
	public class PathSelectionDialogViewModel : ViewModelBase
	{
		/// <summary>
		/// Field of window, dialog title.
		/// </summary>
		protected string _title = "PathSelectionDialog";

		/// <summary>
		/// Window, dialog title.
		/// </summary>
		public string Title
		{
			get => _title;
		}
		
		/// <summary>
		/// OK button title field.
		/// </summary>
		protected string _okTitle = "OK";

		/// <summary>
		/// OK button title property.s
		/// </summary>
		public string OkTitle
		{
			get => _okTitle;
		}

		/// <summary>
		/// Cancel button title field.
		/// </summary>
		protected string _cancelTitle = "Cancel";

		/// <summary>
		/// Cancel button title property.
		/// </summary>
		public string CancelTitle
		{
			get => _cancelTitle;
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionDialogViewModel() : base() { }
	}
}
