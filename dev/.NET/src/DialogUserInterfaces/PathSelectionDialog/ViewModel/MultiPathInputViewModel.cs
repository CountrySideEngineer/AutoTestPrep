using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogUserInterfaces.ViewModel
{
    internal class MultiPathInputViewModel : ViewModelBase
    {
		protected readonly string _splitter = ";";

		public string Title { get => Properties.Resources.IDS_WINDOW_TITLE; }

		public string OkTitle { get => Properties.Resources.IDS_OK_BUTTON_TITLE; }

		public string CancelTitle { get => Properties.Resources.IDS_CANCEL_BUTTON_TITLE;  }

		protected string _inputPath = string.Empty;	

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
		public MultiPathInputViewModel() : base() { }
    }
}
