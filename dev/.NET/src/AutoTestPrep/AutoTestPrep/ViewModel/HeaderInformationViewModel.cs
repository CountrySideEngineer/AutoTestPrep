using CustomUserControls;
using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	internal class HeaderInformationViewModel : AutoTestPrepViewModelBase
    {
		/// <summary>
		/// Default constructor.
		/// </summary>
		public HeaderInformationViewModel() : base() { }

		/// <summary>
		/// Property of Standard header.
		/// </summary>
		public string StandardHeader
		{
			get
			{
				return ExtractItem(0);
			}
		}

		/// <summary>
		/// Property of user header.
		/// </summary>
		public string UserHeader
		{
			get
			{
				return ExtractItem(1);
			}
		}

		/// <summary>
		/// Property of include directories.
		/// </summary>
		public string IncludeDirectories
		{
			get
			{
				return ExtractItem(2);
			}
		}

		/// <summary>
		/// Extract an item from collection of item, Items property in base class.
		/// </summary>
		/// <param name="index">Index of the item in collection.</param>
		/// <returns>Item in string.</returns>
		protected string ExtractItem(int index)
		{
			if (null == Items)
			{
				return string.Empty;
			}
			else
			{
				try
				{
					return Items.ElementAt(index).Item;
				}
				catch (Exception ex)
				when ((ex is IndexOutOfRangeException) || (ex is NullReferenceException))
				{
					return string.Empty;
				}
			}
		}
	}
}
