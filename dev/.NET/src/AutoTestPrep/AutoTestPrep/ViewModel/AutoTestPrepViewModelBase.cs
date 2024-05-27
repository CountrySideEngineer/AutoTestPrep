using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class AutoTestPrepViewModelBase : ViewModelBase
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public AutoTestPrepViewModelBase() : base()
		{
			ViewModelIndex = 0;
			IsSelected = true;
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="viewModelIndex">View model index.</param>
		public AutoTestPrepViewModelBase(int viewModelIndex)
		{
			this.ViewModelIndex = viewModelIndex;
			this.IsSelected = true;
		}

		/// <summary>
		/// View model index.
		/// </summary>
		public int ViewModelIndex { get; protected set; }

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
				return this._IsSelected;
			}
			set
			{
				this._IsSelected = value;
				this.RaisePropertyChanged(nameof(IsSelected));
			}
		}
	}
}
