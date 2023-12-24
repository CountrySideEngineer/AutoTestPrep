using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Data
{
	/// <summary>
	/// Test data model.
	/// </summary>
	public class TestData
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestData()
		{
			this.Condition = string.Empty;
			this.Descriotion = string.Empty;
			this.Name = string.Empty;
			this.Value = string.Empty;
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="src"></param>
		public TestData(TestData src)
		{
			this.Condition = string.Copy(src.Condition);
			this.Descriotion = string.Copy(src.Descriotion);
			this.Name = string.Copy(src.Name);
			this.Value = string.Copy(src.Value);
		}

		/// <summary>
		/// Condition of test data
		/// </summary>
		public string Condition { get; set; }

		/// <summary>
		/// Description of test data.
		/// </summary>
		public string Descriotion { get; set; }

		/// <summary>
		/// Name of test data.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Test data value.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied object.</returns>
		public TestData ShallowCopy()
        {
			return (TestData)MemberwiseClone();
        }

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied object.</returns>
		public TestData DeepCopy()
        {
			var copyItem = new TestData(this);

			return copyItem;
        }

	}
}
