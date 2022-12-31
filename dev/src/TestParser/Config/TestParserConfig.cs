using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestParser.Reader;

namespace TestParser.Config
{
	/// <summary>
	/// Root class of test parser configuration.
	/// </summary>
	[XmlRoot("TestParserConfig")]
	public class TestParserConfig
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public TestParserConfig()
		{
			TestFunctionListTable = new FunctionTableConfig();
			FunctionTable = new FunctionTableConfig();
			TestCaseTable = new TestCaseTableConfig();
		}

		/// <summary>
		/// Configuration about list of test.
		/// </summary>
		[XmlElement("TestFunctionListTable")]
		public TableConfig TestFunctionListTable { get; set; }

		/// <summary>
		/// Configuration about target test definition table.
		/// </summary>
		[XmlElement("FunctionTable")]
		public FunctionTableConfig FunctionTable { get; set; }

		/// <summary>
		/// Configuration about test.
		/// </summary>
		[XmlElement("TestCaseTable")]
		public TestCaseTableConfig TestCaseTable { get; set; }

		/// <summary>
		/// Load configuration file from default config file.
		/// </summary>
		/// <returns>Loaded configuration.</returns>
		public static TestParserConfig LoadConfig()
		{
			string configFilePath = @".\TestParserConfg.xml";
			return LoadConfig(configFilePath);
		}

		/// <summary>
		/// Load test parser configuration file.
		/// </summary>
		/// <param name="path">Paht to test parser configuration file.</param>
		/// <returns>Test parser configuration.</returns>
		public static TestParserConfig LoadConfig(string path)
		{
			try
			{
				TestParserConfig config = null;
				var reader = new XmlConfigReader();
				config = (TestParserConfig)reader.Read(path);
				return config;
			}
			catch (System.IO.FileNotFoundException)
			{
				throw;
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Load configuration about test parser with default data.
		/// </summary>
		/// <returns>Default test parser configuration.</returns>
		public static TestParserConfig LoadDefaultConfig()
		{
			TestParserConfig config = DefaultTestParserConfigFactory.Create();
			return config;
		}
	}

}
