using System.IO.Packaging;

namespace DialogUserInterfaces.ViewModel
{
    public class MultiPathInputViewModel : ViewModelBase
    {
		protected readonly string _splitter = ";";

		protected readonly string _splitterReplace = Environment.NewLine;

		public string Title { get => Properties.Resources.IDS_WINDOW_TITLE; }

		public string OkTitle { get => Properties.Resources.IDS_OK_BUTTON_TITLE; }

		public string CancelTitle { get => Properties.Resources.IDS_CANCEL_BUTTON_TITLE;  }

		protected string _inputPath = string.Empty;	

		public string InputPath
		{
			protected get => _inputPath;
			set
			{
				string inputPath = value.Replace(";", Environment.NewLine);
				_inputPath = inputPath;
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathInputViewModel() :base()
		{
			InputPath = string.Empty;
		}

		/// <summary>
		/// Constructor with input parameter.
		/// </summary>
		public MultiPathInputViewModel(string inputPath) : base()
		{
			InputPath = inputPath;
		}

		/// <summary>
		/// Set content as user input path.
		/// </summary>
		/// <param name="path">User input path.</param>
		public virtual void SetContent(string path)
		{
			string content = path.Replace(_splitter, _splitterReplace);
			InputPath = content;
		}

		/// <summary>
		/// Get path user input.
		/// </summary>
		/// <returns>User input path.</returns>
		public virtual string GetContent()
		{
			IEnumerable<string> inputPathList = InputPath.Split(_splitterReplace).ToList();
			IEnumerable<string> inputPathListWithoutEmpty = 
				inputPathList
					.Where(_ => (!string.IsNullOrWhiteSpace(_) && (!string.IsNullOrEmpty(_))))
					.ToList();
			string content = string.Empty;
			foreach (var item in inputPathListWithoutEmpty)
			{
				if (!string.IsNullOrEmpty(content))
				{
					content += _splitter;
				}
				content += item;
			}
			return content;
		}
    }
}
