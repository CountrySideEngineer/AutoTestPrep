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
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternSinglePointerArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ExternSinglePointerArgumentBufferTemplate : SinglePointerArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("extern ");
            
            #line 7 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Argument.ActualDataType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 7 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetArgumentBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[];\r\nextern ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Argument.DataType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentValueBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[][STUB_BUFFER_SIZE_2];\r\nextern long ");
            
            #line 9 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferDeclare\ExternSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentValueSizeBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[];\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}