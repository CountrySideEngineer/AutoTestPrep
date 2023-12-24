using CodeGenerator.Data;
using CodeGenerator.TestDriver.Template;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.TestDriver.GoogleTest.CodeGenerator
{
    public class GoogleTestSourcePerFunctionCodeGenerator : GoogleTestSourceCodeGenerator
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public GoogleTestSourcePerFunctionCodeGenerator() : base () { }

        protected override GoogleTestTemplate CreateTemplate(WriteData writeData)
        {
			Debug.Assert(null != writeData.Test, $"{nameof(GoogleTestSourceCodeGenerator)}.{nameof(CreateTemplate)}.writeData.Test");
			Debug.Assert(null != writeData.Test.Target, $"{nameof(GoogleTestSourceCodeGenerator)}.{nameof(CreateTemplate)}.writeData.Test.Target");
			Debug.Assert(null != writeData.CodeConfig, $"{nameof(GoogleTestSourceCodeGenerator)}.{nameof(CreateTemplate)}.writeData.CodeConfig");

			INFO("Generate test driver code template of google test.");

			var template = new GoogleTestSourcePerTestFunctionTemplate()
			{
				TargetFunction = writeData.Test.Target,
				TestCase = writeData.Test.TestCases.ElementAt(0),
				Config = writeData.CodeConfig,
				DriverHeaderFileName = TestHeaderFileName,
				StubHeaderFileName = StubHeaderFileName,
			};
			return template;
		}
	}
}
