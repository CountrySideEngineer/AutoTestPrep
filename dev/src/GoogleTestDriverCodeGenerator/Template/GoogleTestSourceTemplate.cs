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
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateIncludeHeaderCode(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 11 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateDecalreGlobalVariable(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n//Test target function declare\r\n");
            
            #line 14 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFunction.ToString()));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 16 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateSetUpCode(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 17 "E:\development\AutoTestPrep\dev\src\GoogleTestDriverCodeGenerator\Template\GoogleTestSourceTemplate.tt"
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
