using CustomUserControls.ViewModel;
using Logger;

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

		/// <summary>
		/// Extract an item from collection of item, Items property in base class.
		/// </summary>
		/// <param name="index">Index of the item in collection.</param>
		/// <returns>Item in string.</returns>
		protected virtual string ExtractItem(int index)
		{
			Log.TRACE();

			if (null == Items)
			{
				return string.Empty;
			}
			else
			{
				try
				{
					string item = Items.ElementAt(index).Item.ToString();
					return item;
				}
				catch (Exception ex)
				when ((ex is NullReferenceException) || (ex is IndexOutOfRangeException))
				{
					return string.Empty;
				}
			}
		}
	}

	internal class AutoTestPrepViewModelBase<T> : CommandGridExpanderViewModel<T> where T : new()
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

		/// <summary>
		/// Extract an item from collection of item, Items property in base class.
		/// </summary>
		/// <param name="index">Index of the item in collection.</param>
		/// <returns>Item in string.</returns>
		protected virtual T ExtractItem(int index)
		{
			Log.TRACE();

			try
			{
				T item = Items.ElementAt(index).Item;
				return item;
			}
			catch (Exception ex)
			when ((ex is NullReferenceException) || (ex is IndexOutOfRangeException))
			{
				return new T();
			}
		}
	}
}
