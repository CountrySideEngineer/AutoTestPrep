namespace DialogUserInterfaces.ViewModel
{
	public class NumericSelectionDialogViewModel : ViewModelBase
	{
		/// <summary>
		/// Sub control view model.
		/// </summary>
		public NumericUpDownViewModel UpDownViewModel { get; set; } = new NumericUpDownViewModel();

		/// <summary>
		/// Default constructor
		/// </summary>
		public NumericSelectionDialogViewModel() : base() { }

		/// <summary>
		/// User input value.
		/// </summary>
		public Int64 InputValue
		{
			get
			{
				try
				{
					Int64 inputValue = Convert.ToInt64(UpDownViewModel.InputValue);
					return inputValue;
				}
				catch (Exception)
				{
					throw;
				}
			}
			set
			{
				UpDownViewModel.InputValue = value.ToString();
			}
		}
	}
}
