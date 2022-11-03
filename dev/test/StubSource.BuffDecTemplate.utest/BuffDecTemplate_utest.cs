using CodeGenerator.Stub.Rule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TestParser.Target;

namespace StubSource.BuffDecTemplate.utest
{
	[TestClass]
	public class BuffDecTemplate_utest
	{
		[TestMethod]
		[TestCategory("UnitTest")]
		public void TransformText_test_001()
		{
			var function = new Function()
			{
				DataType = "int"
				Name = "Function",
				Arguments = new List<Parameter>
				{
					new Parameter()
					{
						DataType = "int",
						Name = "Argument1",
					}
				}
			};
			var rule = new NameRule();
			var template = new ArgumentBufferTemplate()
			{

			};
		}
	}
}
