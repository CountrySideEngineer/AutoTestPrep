﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Stub.Template.BufferInit
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using CodeGenerator.Stub.Template;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class FunctionBufferTemplate : ABufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\t");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetCalledCounter(Target)));
            
            #line default
            #line hidden
            this.Write(" = 0;\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
