using Logger;

namespace TestReader.Config
{
	internal abstract class AConfiguration : IConfiguration
	{
		public (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig()
		{
			Log.TRACE();

			TestConfiguration config = TestConfiguration.Get();

			TestConfigurationElement configElement = GetConfigEelement(config);

			Log.DEBUG($"{"Name",12} = {configElement?.Name ?? string.Empty}");
			Log.DEBUG($"{"RowOffset",12} = {configElement?.RowOffset ?? -1}");
			Log.DEBUG($"{"ColOffset",12} = {configElement?.ColOffset ?? -1}");
			Log.DEBUG($"{"RowSize",12} = {configElement?.RowSize ?? -1}");
			Log.DEBUG($"{"ColSize",12} = {configElement?.ColSize ?? 0 - 1}");

			return (configElement?.Name ?? string.Empty,
				configElement?.RowOffset ?? -1,
				configElement?.ColOffset ?? -1,
				configElement?.RowSize ?? -1,
				configElement?.ColSize ?? -1);
		}

		protected abstract TestConfigurationElement GetConfigEelement(TestConfiguration config);
	}
}
