using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class MainWindowViewModel : ViewModelBase
	{
		public string Title
		{
			get => Properties.Resources.IDS_APP_TITLE;
		}

		protected IEnumerable<ProjectItemViewModel>? _projectRootItem = null;

		public IEnumerable<ProjectItemViewModel>? ProjectRootItem
		{
			get => _projectRootItem;
			set
			{
				_projectRootItem = value;
				RaisePropertyChanged();
				RaisePropertyChanged(nameof(IsProjectSet));
			}
		}

		/// <summary>
		/// Project set or not.
		/// </summary>
		public bool IsProjectSet
		{
			get
			{
				return ProjectRootItem != null;
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainWindowViewModel() : base()
		{
			ProjectRootItem = null;
		}
	}
}
