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
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class FunctionReturnValueBufferTemplate : FunctionBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            this.Write("\tfor (int index = 0; index < STUB_BUFFER_SIZE_1; index++) {\r\n");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"

	if (0 == Target.PointerNum) {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 13 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetReturnValue(Target)));
            
            #line default
            #line hidden
            this.Write("[index] = 0;\r\n");
            
            #line 14 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"

	} else {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 17 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Rule.GetReturnValue(Target)));
            
            #line default
            #line hidden
            this.Write("[index] = NULL;\r\n");
            
            #line 18 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\BufferInit\FunctionReturnValueBufferTemplate.tt"

	}

            
            #line default
            #line hidden
            this.Write("\t}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
