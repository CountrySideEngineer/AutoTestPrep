using CustomUserControls.ViewModel;

namespace AutoTestPrep.ViewModel
{
	internal class AutoTestPrepViewModelBase : CommandGridExpanderViewModel
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public AutoTestPrepViewModelBase() : base()
		{
			IsSelected = false;
		}

		/// <summary>
		/// Flag about the view model object has been selected or not.
		/// </summary>
		protected bool _IsSelected;

		/// <summary>
		/// Flag about the view model object has been selected or not.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				return _IsSelected;
			}
			set
			{
				_IsSelected = value;
				RaisePropertyChanged(nameof(IsSelected));
			}
		}
	}
}
