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
    
    #line 1 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
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
            
            #line 8 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TestClassName(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 8 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TestCaseMethodName(this.TestCaseNumber, this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(")\r\n{\r\n\t//Declare argument for target\r\n");
            
            #line 11 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
 foreach (var argument in TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 12 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argument.ActualDataType()));
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 12 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argument.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 13 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t//Setup test parameters.\r\n");
            
            #line 16 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
 foreach (var input in TestCase.Input) {	
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 17 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(input.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 17 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(input.Value));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 18 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 20 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTargetFunctionCall(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 22 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
 foreach (var expect in TestCase.Expects) {	
            
            #line default
            #line hidden
            this.Write("\tASSERT_EQ(");
            
            #line 23 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(expect.Value));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 23 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(expect.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 24 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTestCaseTemplate.tt"
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
