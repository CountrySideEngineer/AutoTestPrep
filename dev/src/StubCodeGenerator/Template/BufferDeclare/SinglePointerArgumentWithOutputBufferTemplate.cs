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
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\SinglePointerArgumentWithOutputBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SinglePointerArgumentWithOutputBufferTemplate : SinglePointerArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\SinglePointerArgumentWithOutputBufferTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\SinglePointerArgumentWithOutputBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Argument.DataType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\SinglePointerArgumentWithOutputBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentReturnValueBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[STUB_BUFFER_SIZE_1][STUB_BUFFER_SIZE_2];\r\nlong ");
            
            #line 9 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\SinglePointerArgumentWithOutputBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentReturnValueSizeBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[STUB_BUFFER_SIZE_1];\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
