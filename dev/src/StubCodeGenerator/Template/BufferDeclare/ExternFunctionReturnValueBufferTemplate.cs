﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Stub.Template.BufferDeclare
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternFunctionReturnValueBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ExternFunctionReturnValueBufferTemplate : FunctionReturnValueBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("extern long ");
            
            #line 7 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternFunctionReturnValueBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetCalledCounter(Target)));
            
            #line default
            #line hidden
            this.Write(";\r\nextern ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternFunctionReturnValueBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Target.ActualDataType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternFunctionReturnValueBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetReturnValue(Target)));
            
            #line default
            #line hidden
            this.Write("[];\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}