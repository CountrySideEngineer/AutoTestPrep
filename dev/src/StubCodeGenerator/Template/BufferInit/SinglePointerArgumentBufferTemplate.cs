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
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\SinglePointerArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SinglePointerArgumentBufferTemplate : ArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\tfor (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n\t\t");
            
            #line 9 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetArgumentBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[index] = 0;\r\n\t\tfor (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++) {\r\n\t\t" +
                    "\t");
            
            #line 11 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentValueBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[index][index2] = 0;\r\n\t\t}\r\n\t\t");
            
            #line 13 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentValueSizeBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[index] = 0;\r\n\t}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
