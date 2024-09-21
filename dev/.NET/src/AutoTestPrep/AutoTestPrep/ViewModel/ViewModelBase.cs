using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public virtual void RaisePropertyChanged([CallerMemberName]string propertName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertName));
		}
	}
}
