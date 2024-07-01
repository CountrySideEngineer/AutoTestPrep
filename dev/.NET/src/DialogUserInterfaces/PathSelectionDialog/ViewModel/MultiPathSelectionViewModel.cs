using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DialogUserInterfaces.ViewModel
{
	internal class MultiPathSelectionViewModel : ViewModelBase
	{
		protected readonly string _splitter = ";";

		protected string _title = Properties.Resources.IDS_WINDOW_TITLE;

		public string Title { get => _title; }

		public string OkTitle { get => Properties.Resources.IDS_OK_BUTTON_TITLE; }

		public string CancelTitle { get => Properties.Resources.IDS_CANCEL_BUTTON_TITLE; }

		protected ButtonListBoxViewModel _userInputPath = new();

		public ButtonListBoxViewModel UserInputPath
		{
			get => _userInputPath;
			set
			{
				_userInputPath = value;
				RaisePropertyChange();
			}
		}

		public IEnumerable<string> _inputPaths = new List<string>();

		public IEnumerable<string> InputPaths
		{
			get
			{
				return _inputPaths;
			}
			set
			{
				_inputPaths = value;
				RaisePropertyChange();
			}
		}

		public string InputPathsOneLine
		{
			get
			{
				string pathOneLine = string.Empty;
				foreach (var path in InputPaths)
				{
					pathOneLine += path;
					pathOneLine += _splitter;
				}
				if (!string.IsNullOrEmpty(pathOneLine))
				{
					pathOneLine += _splitter;
				}
				return pathOneLine;
			}
			set
			{
				IEnumerable<string> splitValue = 
					value
					.Split(_splitter, StringSplitOptions.RemoveEmptyEntries)
					.ToList();
				_inputPaths = splitValue;
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathSelectionViewModel() : base()
		{
			UserInputPath = new();
		}
	}
}
