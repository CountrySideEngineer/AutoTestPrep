// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.TestDriver.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class GoogleTestSourceTemplate : GoogleTestTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n *\t");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFunction.Name));
            
            #line default
            #line hidden
            this.Write(" test driver source code.\r\n */\r\n");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

	foreach (var headerFile in Config.StandardHeaderFiles) {
		if ((!string.IsNullOrEmpty(headerFile)) && (!string.IsNullOrWhiteSpace(headerFile))) {

            
            #line default
            #line hidden
            this.Write("#include <");
            
            #line 14 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(headerFile));
            
            #line default
            #line hidden
            this.Write(">\r\n");
            
            #line 15 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("#include \"gtest/gtest.h\"\r\n");
            
            #line 20 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

	foreach (var headerFile in Config.UserHeaderFiles) { 
		if ((!string.IsNullOrEmpty(headerFile)) && (!string.IsNullOrWhiteSpace(headerFile))) {

            
            #line default
            #line hidden
            this.Write("#include \"");
            
            #line 24 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(headerFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 25 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

		}
	}

            
            #line default
            #line hidden
            
            #line 29 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

	if ((!string.IsNullOrEmpty(DriverHeaderFileName)) && (!string.IsNullOrWhiteSpace(DriverHeaderFileName))) {

            
            #line default
            #line hidden
            this.Write("#include \"");
            
            #line 32 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DriverHeaderFileName));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 33 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

	}

            
            #line default
            #line hidden
            
            #line 36 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

	if ((!string.IsNullOrEmpty(StubHeaderFileName)) && (!string.IsNullOrWhiteSpace(StubHeaderFileName))) {

            
            #line default
            #line hidden
            this.Write("#include \"");
            
            #line 39 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StubHeaderFileName));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 40 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"

	}

            
            #line default
            #line hidden
            
            #line 43 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateDecalreGlobalVariable(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n//Test target function declare\r\n");
            
            #line 46 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFunction.ToString()));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 48 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateSetUpCode(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 49 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTestCaseCode(this.TargetFunction, this.Test)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
