using PathCommandLibrary;
using PathSelectionDialog.Command;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PathSelectionDialog.ViewModel
{
	public class PathSelectionDialogViewModel : ViewModelBase
	{
		/// <summary>
		/// Command to select path.
		/// </summary>
		protected IPathSelectCommand? PathSelect { get; set; } = null;

		/// <summary>
		/// Path select command.
		/// </summary>
		protected DelegateCommand? _pathSelectCommand = null;
		public DelegateCommand PathSelectCommand
		{
			get
			{
				if (null == _pathSelectCommand)
				{
					_pathSelectCommand = new DelegateCommand(() =>
					{
						try
						{
							InputPath = PathSelect?.Select() ?? string.Empty;
						}
						catch (Exception)
						{
							// This path will be reached when canceled.
						}
					});
				}
				return _pathSelectCommand;
			}
		}

		/// <summary>
		/// Field of window, dialog title.
		/// </summary>
		protected string _title = Properties.Resources.IDS_WINDOW_TITLE;

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
		protected string _okTitle = Properties.Resources.IDS_OK_BUTTON_TITLE;

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
		protected string _cancelTitle = Properties.Resources.IDS_CANCEL_BUTTON_TITLE;

		/// <summary>
		/// Cancel button title property.
		/// </summary>
		public string CancelTitle
		{
			get => _cancelTitle;
		}

		/// <summary>
		/// Input path field.
		/// </summary>
		protected string _inputPath = string.Empty;

		/// <summary>
		/// Input path property.
		/// </summary>
		public string InputPath
		{
			get => _inputPath;
			set
			{
				_inputPath = value;
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PathSelectionDialogViewModel() : base() { }

		/// <summary>
		/// User has been selected a path or not.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				if ((string.IsNullOrEmpty(InputPath)) || (string.IsNullOrWhiteSpace(InputPath)))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}
	}
}
