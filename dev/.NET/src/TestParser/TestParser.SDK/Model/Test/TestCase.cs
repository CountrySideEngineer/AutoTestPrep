using Logger;

namespace TestParser.Model.Test
{
	public class TestCase
	{
		/// <summary>
		/// Test case input datas.
		/// </summary>
		public IEnumerable<TestData> Inputs { get; set; } = new List<TestData>();

		/// <summary>
		/// Test case expect datas, not output.
		/// </summary>
		public IEnumerable<TestData> Expects { get; set; } = new List<TestData>();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestCase() { }

		/// <summary>
		/// Copy to other TestCase object.
		/// </summary>
		/// <param name="dst">TestCase object to copy to.</param>
		public virtual void CopyTo(TestCase dst)
		{
			Log.TRACE();

			dst.Inputs = new List<TestData>(Inputs);
			dst.Expects = new List<TestData>(Expects);
		}

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied method.</returns>
		public virtual TestCase ShallowCopy()
		{
			Log.TRACE();

			return (TestCase)MemberwiseClone();
		}

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied TestCase object.</returns>
		public virtual TestCase DeepCopy()
		{
			Log.TRACE();

			TestCase testCase = (TestCase)MemberwiseClone();
			CopyTo(testCase);
			return testCase;
		}
	}
}
