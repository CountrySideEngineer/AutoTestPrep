using CodeGenerator.Data;
using CodeGenerator.TestDriver.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.TestDriver.GoogleTest.CodeGenerator
{
    public class GoogleTestSetUpSourceCodeGenerator : GoogleTestSourceCodeGenerator
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public GoogleTestSetUpSourceCodeGenerator() : base() { }

        /// <summary>
        /// Create template to generaete code to setup test.
        /// </summary>
        /// <param name="data">Write data to setup.</param>
        /// <returns>Template object of setup method.</returns>
        protected override GoogleTestTemplate CreateTemplate(WriteData data)
        {
            INFO("Generate test driver setup template of google test.");

            var template = new GoogleTestSourceSetUpTemplate(data.Test.Target);
            return template;
        }
    }
}
