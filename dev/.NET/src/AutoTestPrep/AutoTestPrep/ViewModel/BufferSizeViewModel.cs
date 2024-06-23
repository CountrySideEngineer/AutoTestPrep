using AutoTestPrep.Command;
using CustomUserControls.ViewModel;
using DialogUserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class BufferSizeViewModel : AutoTestPrepViewModelBase<long>
	{
		/// <summary>
		/// Default buffer1 size.
		/// </summary>
		protected long _defaultBufferSize1 = 100;

		/// <summary>
		/// Default buffer2 size.
		/// </summary>
		protected long _defaultBufferSize2 = 100;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferSizeViewModel() : base()
		{
			CategoryName = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_INFORMATION;

			Items = new List<CommandGridExpanderItem<long>>()
			{
				new CommandGridExpanderItem<long>()
				{
					Title = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_SIZE_1,
					Item = _defaultBufferSize1,
					CustomCommand = new NumericSelectionCommand()
				},
				new CommandGridExpanderItem<long>()
				{
					Title = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_SIZE_2,
					Item = _defaultBufferSize2,
					CustomCommand = new NumericSelectionCommand()
				}
			};
		}

		/// <summary>
		/// Stub buffer size 1 property.
		/// </summary>
		public long BufferSize1
		{
			get
			{
				return ExtractItem(0);
			}
			set
			{
				try
				{
					var itemsList = (List<CommandGridExpanderItem>)Items;
					itemsList[0].Item = value.ToString();
					RaisePropertyChanged();
				}
				catch (NullReferenceException)
				{
					// Ignore the exception.
				}
			}
		}

		/// <summary>
		/// Stub buffer size 2 property.
		/// </summary>
		public long BufferSize2
		{
			get
			{
				return ExtractItem(1);
			}
			set
			{
				try
				{
					var itemsList = (List<CommandGridExpanderItem>)Items;
					itemsList[1].Item = value.ToString();
					RaisePropertyChanged();
				}
				catch (NullReferenceException)
				{
					// Ignore the exception.
				}
			}
		}
	}
}
