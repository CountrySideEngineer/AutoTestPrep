﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Stub.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class StubHeaderTemplate : StubTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("#pragma once\r\n//Buffer size macro\r\n#ifndef\tSTUB_BUFFER_SIZE_1\r\n#define\tSTUB_BUFFE" +
                    "R_SIZE_1\t\t\t(");
            
            #line 10 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BufferSize1));
            
            #line default
            #line hidden
            this.Write(")\r\n#endif\r\n#ifndef\tSTUB_BUFFER_SIZE_2\r\n#define\tSTUB_BUFFER_SIZE_2\t\t\t(");
            
            #line 13 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BufferSize2));
            
            #line default
            #line hidden
            this.Write(")\r\n#endif\r\n\r\n");
            
            #line 16 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderTemplate.tt"

	if (null != this.ParentFunction.SubFunctions) {
		foreach (var subFunction in this.ParentFunction.SubFunctions) {

            
            #line default
            #line hidden
            
            #line 20 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateStubBody(this.ParentFunction, subFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 21 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderTemplate.tt"
	
		}
	}

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
