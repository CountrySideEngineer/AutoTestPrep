using CustomUserControls.ViewModel;
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
					Item = 100
				},
				new CommandGridExpanderItem<long>()
				{
					Title = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_SIZE_2,
					Item = 100
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
