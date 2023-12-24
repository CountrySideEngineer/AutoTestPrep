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
    public class GoogleTestSetUpSourcePerFunctionCodeGenerator : GoogleTestSourceCodeGenerator
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public GoogleTestSetUpSourcePerFunctionCodeGenerator() : base() { }

        protected override GoogleTestTemplate CreateTemplate(WriteData writeData)
        {
			Debug.Assert(null != writeData.Test, $"{nameof(GoogleTestSourceCodeGenerator)}.{nameof(CreateTemplate)}.writeData.Test");
			Debug.Assert(null != writeData.Test.Target, $"{nameof(GoogleTestSourceCodeGenerator)}.{nameof(CreateTemplate)}.writeData.Test.Target");
			Debug.Assert(null != writeData.CodeConfig, $"{nameof(GoogleTestSourceCodeGenerator)}.{nameof(CreateTemplate)}.writeData.CodeConfig");

			INFO("Generate test driver code template of google test.");

			var template = new GoogleTestSourcePerTestFunctionSetUpTemplate()
			{
				TargetFunction = writeData.Test.Target,
				Test = writeData.Test,
				Config = writeData.CodeConfig,
				DriverHeaderFileName = TestHeaderFileName,
				StubHeaderFileName = StubHeaderFileName,
			};
			return template;
		}
	}
}
