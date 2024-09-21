using Logger;

namespace TestReader.Config
{
	internal class TestCaseConfiguration : AConfiguration
	{
		/// <summary>
		/// Get TestCase configuration from test configuration.
		/// </summary>
		/// <param name="config">Root configuration.</param>
		/// <returns>Test case configuration.</returns>
		/// <exception cref="FileLoadException">File invalid.</exception>
		protected override TestConfigurationElement GetConfigEelement(TestConfiguration config)
		{
			Log.TRACE();

			if (null != config.TestCase)
			{
				return config.TestCase;
			}
			else
			{
				throw new FileLoadException();
			}
		}
	}
}
