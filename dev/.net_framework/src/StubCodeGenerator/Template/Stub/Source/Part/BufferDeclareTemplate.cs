﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Stub.Template.Stub.Source.Part
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\Stub\Source\Part\BufferDeclareTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class BufferDeclareTemplate : TemplateCommonBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n *\tBuffers for the ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\Stub\Source\Part\BufferDeclareTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Target.Name));
            
            #line default
            #line hidden
            this.Write(" stub method.\r\n */\r\n");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\Stub\Source\Part\BufferDeclareTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}