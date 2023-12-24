using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Data
{
	/// <summary>
	/// Test data model class.
	/// </summary>
	public class TestCase
	{
		public string Id { get; set; }

		/// <summary>
		/// Input information of a test case.
		/// </summary>
		public IEnumerable<TestData> Input { get; set; }

		/// <summary>
		/// Expectation of a test case.
		/// </summary>
		public IEnumerable<TestData> Expects { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestCase()
        {
			Id = string.Empty;
			Input = null;
			Expects = null;
        }

		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="src">Source object.</param>
		public TestCase(TestCase src)
        {
			Id = string.Copy(src.Id);

			if (null != src.Input)
            {
				Input = new List<TestData>(src.Input);
            }
            else
            {
				Input = null;
            }

			if (null != src.Expects)
            {
				Expects = new List<TestData>(src.Expects);
            }
            else
            {
				Expects = null;
            }
		}

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied object.</returns>
		public TestCase ShallowCopy()
        {
			var copyItme = (TestCase)MemberwiseClone();

			return copyItme;
        }

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied object.</returns>
		public TestCase DeepCopy()
        {
			var copyItem = new TestCase(this);

			return copyItem;
        }
	}
}
