using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogUserInterfaces.ViewModel
{
    internal class MultiPathInputViewModel : ViewModelBase
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
		public MultiPathInputViewModel(string inputPath = "") : base()
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
			string content = InputPath.Replace(_splitterReplace, _splitterReplace);

			return content;
		}
    }
}
