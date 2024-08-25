using Logger;
using System.Security.Cryptography.X509Certificates;
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
				FunctionList = new TargetFunctionListConfigurationElement()
				{
					Name = Properties.Resources.IDS_TABLE_NAME_TARGET_TEST_FUNCTION_LIST,
					RowOffset = 1,
					ColOffset = 1,
				},
				Function = new TestFunctionParamConfigurationElement()
				{
					Name = Properties.Resources.IDS_TABLE_NAME_TARGET_FUNCTION,
					RowOffset = 1,
					ColOffset = 1
				},
				TestCase = new TestCaseConfigurationElement()
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

	public class TargetFunctionListConfigurationElement : TestConfigurationElement
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		internal TargetFunctionListConfigurationElement() : base() { }

		/// <summary>
		/// Function number column name.
		/// </summary>
		public string Number
		{
			get => Properties.Resources.IDS_TARGET_TEST_FUNCTION_LIST_TABLE_COL_NAME_NO;
		}

		/// <summary>
		/// Test name column name.
		/// </summary>
		public string TestName
		{
			get => Properties.Resources.IDS_TARGET_TEST_FUNCTION_LIST_TABLE_COL_NAME_TEST_NAME;
		}

		/// <summary>
		/// Test case declared sheet name.
		/// </summary>
		public string SheetName
		{
			get => Properties.Resources.IDS_TARGET_TEST_FUNCTION_LIST_TABLE_COL_NAME_TEST_DEF_SHEET_NAME;
		}

		/// <summary>
		/// Source file name column name.
		/// </summary>
		public string SourceName
		{
			get => Properties.Resources.IDS_TARGET_TEST_FUNCTION_LIST_TABLE_COL_NAME_TEST_FILE_NAME;
		}

		/// <summary>
		/// Source file path column name.
		/// </summary>
		public string SourcePath
		{
			get => Properties.Resources.IDS_TARGET_TEST_FUNCTION_LIST_TABLE_COL_NAME_TEST_FILE_PATH;
		}
	}

	public class TestFunctionParamConfigurationElement : TestConfigurationElement
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		internal TestFunctionParamConfigurationElement() : base() { }

		public string Category
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_CATEGORY;
		}

		public string Classification
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_CLASSIFICATION;
		}

		/// <summary>
		/// Data type prefix column name.
		/// </summary>
		public string DataTypePrefix
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_DATA_PREFIX;
		}

		/// <summary>
		/// Data type column name.
		/// </summary>
		public string DataType 
		{ 
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_DATA_TYPE; 
		}

		/// <summary>
		/// Data type postfix name.
		/// </summary>
		public string DataTypePostfix
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_DATA_POSTFIX;
		}

		/// <summary>
		/// Function, argument, or variable name column name.
		/// </summary>
		public string VariableName
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_FUNC_PARAM_NAME;
		}

		/// <summary>
		/// Direction column name.
		/// </summary>
		public string Direction
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_DIRECTION;
		}

		/// <summary>
		/// Remarks column name.
		/// </summary>
		public string Remarks
		{
			get => Properties.Resources.IDS_TARGET_FUNCTION_TABLE_COL_NAME_REMARKS;
		}
	}

	public class TestCaseConfigurationElement : TestConfigurationElement
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		internal TestCaseConfigurationElement() : base() { }

		/// <summary>
		/// Parameter category column name.
		/// </summary>
		public string InputCategory
		{
			get => Properties.Resources.IDS_TEST_CASE_TABLE_COL_NAME_INPUT_CATEGORY;
		}

		/// <summary>
		/// Parameter type column name.
		/// </summary>
		public string ParameterType
		{
			get => Properties.Resources.IDS_TEST_CASE_TABLE_COL_NAME_PARAM_TYPE;
		}

		/// <summary>
		/// Variable name column name.
		/// </summary>
		public string VariableName
		{
			get => Properties.Resources.IDS_TEST_CASE_TABLE_COL_NAME_VARIABLE_NAME;
		}

		/// <summary>
		/// Test typical value column name.
		/// </summary>
		public string TypicalValue
		{
			get => Properties.Resources.IDS_TEST_CASE_TABLE_COL_NAME_TYPICAL_VALUE;
		}
	}

}
