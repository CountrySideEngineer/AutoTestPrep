using Logger;
using System.Xml.Serialization;

namespace TestReader.Config
{
	[XmlRoot("TestReaderConfiguration")]
	public class TestConfiguration
	{
		[XmlElement("FunctionList")]
		public TestConfigurationElement? FunctionList { get; set; } = null;

		[XmlElement("Function")]
		public TestConfigurationElement? Function { get; set;} = null;

		[XmlElement("TestCase")]
		public TestConfigurationElement? TestCase { get; set; } = null;

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <remarks>
		/// TestConfiguration class is singleton. So it is not allowed to instantiate.
		/// </remarks>
		internal TestConfiguration() { }

		private static string _configFilePath = @".\TestReaderConfig.xml";

		private static TestConfiguration? _instance = null;

		/// <summary>
		/// Returns test configuration data.
		/// </summary>
		/// <returns>Test configuration.</returns>
		/// <exception cref="FileLoadException">Exception detected while loading test configuration file.</exception>
		public static TestConfiguration Get()
		{
			Log.TRACE();

			try
			{
				if (null == _instance)
				{
					_instance = Load();
				}
				return _instance;
			}
			catch (FileLoadException)
			{
				Log.FATAL("Fatal error detected while loading test configuration file.");
				Log.FATAL($"Check file named {System.IO.Path.GetFileName(_configFilePath)} is existing and its format.");

				throw;
			}
		}

		/// <summary>
		/// Load test configuration.
		/// </summary>
		/// <returns>Test configuration.</returns>
		/// <exception cref="FileLoadException">FileLoadException</exception>
		protected static TestConfiguration Load()
		{
			Log.TRACE();

			_instance = new TestConfiguration()
			{
				FunctionList = new TestConfigurationElement()
				{
					Name = Properties.Resources.IDS_TABLE_NAME_TARGET_TEST_FUNCTION_LIST,
					RowOffset = 1,
					ColOffset = 1,
				},
				Function = new TestConfigurationElement()
				{
					Name = Properties.Resources.IDS_TABLE_NAME_TARGET_FUNCTION,
					RowOffset = 1,
					ColOffset = 1
				},
				TestCase = new TestConfigurationElement()
				{
					Name = Properties.Resources.IDS_TABLE_NAME_TEST_CASE_DEFINITION,
					RowOffset = 1,
					ColOffset = 1,
				}
			};
			return _instance;
		}
	}

	public class TestConfigurationElement
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		internal TestConfigurationElement() { }

		[XmlElement("name")]
		public string Name { get; set; } = string.Empty;

		[XmlElement("rowOffset", IsNullable =true)]
		public int? RowOffset { get; set; } = 0;

		[XmlElement("colOffset", IsNullable = true)]
		public int? ColOffset { get; set; } = 0;

		[XmlElement("rowSize", IsNullable = true)]
		public int? RowSize { get; set; } = 0;

		[XmlElement("colSize", IsNullable = true)]
		public int? ColSize { get; set; } = 0;
	}
}
