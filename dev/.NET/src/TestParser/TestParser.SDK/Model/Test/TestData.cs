using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Model.Test
{
	public class TestData
	{
		/// <summary>
		/// Condition of test data.
		/// </summary>
		public string Condition { get; set; } = string.Empty;

		/// <summary>
		/// Test description.
		/// </summary>
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Test name.
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Test data value.
		/// </summary>
		public string Value { get; set; } = string.Empty;

		/// <summary>
		/// Copy data to other TestData object.
		/// </summary>
		/// <param name="dst">TestData object to copy to.</param>
		public virtual void CopyTo(TestData dst)
		{
			Log.TRACE();

			dst.Condition = new(Condition);
			dst.Description = new(Description);
			dst.Name = new(Name);
			dst.Value = new(Value);
		}

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied method.</returns>
		public virtual TestData ShallowCopy()
		{
			Log.TRACE();

			return (TestData)MemberwiseClone();
		}

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied object.</returns>
		public virtual TestData DeepCopy()
		{
			Log.TRACE();

			TestData newItem = (TestData)MemberwiseClone();
			CopyTo(newItem);

			return newItem;
		}
	}
}
