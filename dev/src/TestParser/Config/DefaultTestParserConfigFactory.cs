using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Config
{
	public class DefaultTestParserConfigFactory
	{
		/// <summary>
		/// Create default TestParserConfig object.
		/// </summary>
		/// <returns>TestParserConfig object with default parameter.</returns>
		public static TestParserConfig Create()
		{
			TableConfig testFunctionListTable = CreateTestFunctionTableConfig();
			FunctionTableConfig functionTableConfig = CreateFunctionTableConfig();
			TestCaseTableConfig testCaseTableConfig = CreateTestCaseTableConfig();
			TestParserConfig config = new TestParserConfig()
			{
				TestFunctoinListTable = testFunctionListTable,
				FunctionTable = functionTableConfig,
				TestCaseTable = testCaseTableConfig
			};
			return config;
		}

		/// <summary>
		/// Create test function list table configuration with default values.
		/// </summary>
		/// <returns>FunctionTableConfig object with default configuration.</returns>
		protected static FunctionTableConfig CreateTestFunctionTableConfig()
		{
			var config = new FunctionTableConfig()
			{
				Title = "○テスト対象関数一覧",
				TableTopRowOffset = 1,
				TableTopColOffset = 1,
			};
			return config;
		}

		/// <summary>
		/// Create function table configuration with default values.
		/// </summary>
		/// <returns>Function table configuratoin with default values.</returns>
		protected static FunctionTableConfig CreateFunctionTableConfig()
		{
			var targetFunction = new FunctionConfig()
			{
				Category = "テスト対象関数",
				Function = "本体",
				Argument = "引数"
			};
			var subFunction = new FunctionConfig()
			{
				Category = "子関数",
				Function = "本体",
				Argument = "引数"
			};
			var variable = new VariableConfig()
			{
				Category = "グローバル変数",
				Internal = "内部",
				External = "外部",
			};
			var config = new FunctionTableConfig()
			{
				Title = "○対象関数情報",
				TableTopRowOffset = 1,
				TableTopColOffset = 1,
				TargetFunction = targetFunction,
				SubFunction = subFunction,
				Variable = variable
			};
			return config;
		}

		/// <summary>
		/// Create test case table configuration with default values.
		/// </summary>
		/// <returns>Test case table configuration with default values.</returns>
		protected static TestCaseTableConfig CreateTestCaseTableConfig()
		{
			var config = new TestCaseTableConfig()
			{
				Title = "○テスト/デシジョンテーブル",
				TableTopRowOffset = 1,
				TableTopColOffset = 1,
				Input = "入力",
				Exepct = "期待値"
			};
			return config;
		}
	}
}
