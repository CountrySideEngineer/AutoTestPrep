using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class BufferSizeViewModel : AutoTestPrepViewModelBase
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferSizeViewModel() : this(-1) { }

		public BufferSizeViewModel(int index) : base(index)
		{
        }

		/// <summary>
		/// Stub buffer size 1 field.
		/// </summary>
		protected long _bufferSize1 = 0;

		/// <summary>
		/// Stub buffer size 1 property.
		/// </summary>
		public long BufferSize1
		{
			get => _bufferSize1;
			set
			{
				_bufferSize1 = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// Stub buffer size 2 field.
		/// </summary>
		protected long _bufferSize2 = 0;

		/// <summary>
		/// Stub buffer size 2 property.
		/// </summary>
		public long BufferSize2
		{
			get => _bufferSize2;
			set
			{
				_bufferSize2 = value;
				RaisePropertyChanged();
			}
		}
	}
}
