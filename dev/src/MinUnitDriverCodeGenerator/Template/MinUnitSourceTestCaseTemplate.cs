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
    
    #line 1 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class MinUnitSourceTestCaseTemplate : MinUnitTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nstatic char* ");
            
            #line 8 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTestCaseMethodName(this.TargetFunction, this.TestCase)));
            
            #line default
            #line hidden
            this.Write("()\r\n{\r\n\t//Declare argument for target\r\n");
            
            #line 11 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
 foreach (var argument in TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 12 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argument.ActualDataType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 12 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argument.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 13 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t//Declare return value buffer.\r\n\t");
            
            #line 16 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateReturnValueBufferDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\r\n\r\n\t//Initialize stub parameters.\r\n\t");
            
            #line 20 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateStubInitMethodName(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n\t//Setup test parameters.\r\n");
            
            #line 23 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
 foreach (var input in TestCase.Input) {	
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 24 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(input.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 24 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(input.Value));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 25 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 27 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTargetFunctionCall(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 29 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
 foreach (var expect in TestCase.Expects) {	
            
            #line default
            #line hidden
            this.Write("\tmu_assert(");
            
            #line 30 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(expect.Value));
            
            #line default
            #line hidden
            this.Write(" == ");
            
            #line 30 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(expect.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 31 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\MinUnitDriverCodeGenerator\Template\MinUnitSourceTestCaseTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
