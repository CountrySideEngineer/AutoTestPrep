using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TestParser.Config;
using TestParser.Converter.Function;
using TestParser.Target;

namespace FunctionConverter_utest
{
	public partial class FunctionConverter_utest
	{
		[TestMethod]
		[TestCategory("GetSetter")]
		public void GetSetter_utest_001()
		{
			FunctionTableConfig config = new FunctionTableConfig()
			{
				TargetFunction = new FunctionConfig()
				{
					Category = "テスト対象関数",
					Function = "本体",
					Argument = "引数"
				},
				SubFunction = new FunctionConfig()
				{
					Category = "子関数",
					Function = "本体",
					Argument = "引数"
				},
				Variable = new VariableConfig()
				{
					Category = "グローバル変数",
					External = "外部",
					Internal = "内部"
				}
			};
			var src = new List<string>()
			{
				"テスト対象関数", "本体"
			};
			var converter = new FunctionConverter(config);
			var converterPrivate = new PrivateObject(converter);
			object setter = converterPrivate.Invoke("GetSetter", src);

		}
	}
}
