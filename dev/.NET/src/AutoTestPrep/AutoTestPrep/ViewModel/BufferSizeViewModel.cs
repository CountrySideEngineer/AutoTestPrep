using CustomUserControls.ViewModel;
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
		public BufferSizeViewModel() : base()
		{
			CategoryName = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_INFORMATION;

			Items = new List<CommandGridExpanderItem>()
			{
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_SIZE_1,
					Item = "100"
				},
				new CommandGridExpanderItem()
				{
					Title = Properties.Resources.IDS_TEST_DOUBLE_BUFFER_SIZE_2,
					Item = "100"
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
				try
				{
					return Convert.ToInt64(Items.ElementAt(0).Item);
				}
				catch (Exception ex)
				when ((ex is ArgumentNullException) || (ex is ArgumentOutOfRangeException))
				{
					return 100;
				}
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
					// Ignore the exceptoin.
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
				try
				{
					return Convert.ToInt64(Items.ElementAt(0).Item);
				}
				catch (Exception ex)
				when ((ex is ArgumentNullException) || (ex is ArgumentOutOfRangeException))
				{
					return 100;
				}
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
