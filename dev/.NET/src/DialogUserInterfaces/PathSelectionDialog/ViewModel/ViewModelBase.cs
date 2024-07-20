using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DialogUserInterfaces.ViewModel
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		/// <summary>
		/// Raise PropertyChanged event.
		/// </summary>
		/// <param name="propertyName">Changed property name.</param>
		public virtual void RaisePropertyChange([CallerMemberName]string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
