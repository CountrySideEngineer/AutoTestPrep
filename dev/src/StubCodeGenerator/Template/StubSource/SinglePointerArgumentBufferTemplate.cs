﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Stub.Template.StubSource
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SinglePointerArgumentBufferTemplate : ArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            this.Write("\r\n\tfor (int index = 0;\r\n\t\tindex < ");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentValueSizeBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetCalledCounter(Target)));
            
            #line default
            #line hidden
            this.Write("];\r\n\t\tindex++)\r\n\t{\r\n\t\t");
            
            #line 13 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetSinglePointerArgumentValueBuffer(Target, Argument)));
            
            #line default
            #line hidden
            this.Write("[");
            
            #line 13 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetCalledCounter(Target)));
            
            #line default
            #line hidden
            this.Write("][index] = *(");
            
            #line 13 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSource\SinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Argument.Name));
            
            #line default
            #line hidden
            this.Write(" + index);\r\n\t}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}