using Logger;
using TestParser.Model.Test;

namespace TestParser.Model
{
	public class TestComponent : ICopy<TestComponent>
	{
		/// <summary>
		/// Test component name.
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Test component description.
		/// </summary>
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Source file name the test target function is implemented.
		/// </summary>
		public string SourceName { get; set; } = string.Empty;

		/// <summary>
		/// Path to source file name.
		/// </summary>
		public string SourcePath { get; set;} = string.Empty;

		/// <summary>
		/// Test target function.
		/// </summary>
		public Function? Target { get; set; } = null;

		/// <summary>
		/// Test suite to test the target function.
		/// </summary>
		public TestSuite? TestSuite { get; set; } = null;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestComponent() : base() { }

		/// <summary>
		/// Copy data to other TestCompnent object.
		/// </summary>
		/// <param name="dst"></param>
		public void CopyTo(TestComponent dst)
		{
			Log.TRACE();

			dst.Name = new(Name);
			dst.Description = new(Description);
			dst.SourceName = new(SourceName);
			dst.SourcePath = new(SourcePath);

			dst.Target = Target?.DeepCopy();
			dst.TestSuite = TestSuite?.DeepCopy();
		}

		/// <summary>
		/// Shallow copy object.
		/// </summary>
		/// <returns></returns>
		public TestComponent ShallowCopy()
		{
			Log.TRACE();

			return (TestComponent)MemberwiseClone();
		}

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns></returns>
		public TestComponent DeepCopy()
		{
			Log.TRACE();

			TestComponent component = (TestComponent)MemberwiseClone();
			CopyTo(component);

			return component;
		}
	}
}
