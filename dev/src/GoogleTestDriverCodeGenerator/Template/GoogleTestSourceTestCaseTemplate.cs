﻿// ------------------------------------------------------------------------------
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
    
    #line 1 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class GoogleTestSourceTestCaseTemplate : GoogleTestTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nTEST_F(");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TestClassName(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TestCaseMethodName(this.TargetFunction, this.TestCase)));
            
            #line default
            #line hidden
            this.Write(")\r\n{\r\n");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
	if (null != TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            this.Write("\t//Declare argument for target\r\n");
            
            #line 12 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
		foreach (var argument in TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            
            #line 13 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateCodeToDeclareArgument(argument)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 14 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
		}	
            
            #line default
            #line hidden
            
            #line 15 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t//Setup test parameters.\r\n");
            
            #line 18 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
 foreach (var input in TestCase.Input) {	
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 19 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SetInputValues(input)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 20 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 22 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTargetFunctionCall(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\t//Check the test result by comparing the output with the expected value.\r\n");
            
            #line 25 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
 foreach (var expect in TestCase.Expects) {	
            
            #line default
            #line hidden
            this.Write("\tASSERT_EQ(");
            
            #line 26 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(expect.Value));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 26 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(expect.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 27 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
