using Logger;

namespace TestParser.Model.Test
{
    public class TestSuite
	{
		/// <summary>
		/// Function data to be tested.
		/// </summary>
		public Function Function { get; set; } = new Function();

		/// <summary>
		/// Colllection of test case.
		/// </summary>
		public IEnumerable<TestCase> TestCases { get; set; } = new List<TestCase>();

		/// <summary>
		/// Test suite name.
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Copy data to other TestSuite object.
		/// </summary>
		/// <param name="dst">TestSuite object to copy to.</param>
		public virtual void CopyTo(TestSuite dst)
		{
			Log.TRACE();

			dst.Name = new(Name);
			try
			{
				dst.TestCases = new List<TestCase>(TestCases);
			}
			catch (NullReferenceException)
			{
				Log.INFO("Test cases can not copy to other object.");
			}

			try
			{
				Function.CopyTo(dst.Function);
			}
			catch (NullReferenceException)
			{
				Log.INFO("Function object can not copy to other object.");
			}
		}

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns></returns>
		public virtual TestSuite ShallowCopy()
		{
			Log.TRACE();

			return (TestSuite)MemberwiseClone();
		}

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns></returns>
		public virtual TestSuite DeepCopy()
		{
			Log.TRACE();

			TestSuite testSuite = (TestSuite)MemberwiseClone();
			CopyTo(testSuite);
			return testSuite;
		}
	}
}
