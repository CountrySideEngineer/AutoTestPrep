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
    
    #line 1 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class StubHeaderBodyTemplate : StubTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n *\tBuffer for stub of ");
            
            #line 8 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFunction.Name));
            
            #line default
            #line hidden
            this.Write(".\r\n */\r\n");
            
            #line 10 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateFunctoinCalledCountBufferDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n//External declaration of the buffer to store value the method should return." +
                    "\r\n");
            
            #line 13 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateFunctionReturnBufferDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n//External declaration of the buffers which store the value of arguments. \r\n");
            
            #line 16 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
 foreach (var argItem in this.TargetFunction.Arguments) {
            
            #line default
            #line hidden
            
            #line 17 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateArgumentBufferDeclare(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 18 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n//External declaration of the buffers that store the values the method should r" +
                    "eturn via a pointer argument.\r\n");
            
            #line 21 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
 foreach (var argItem in this.TargetFunction.Arguments) {
            
            #line default
            #line hidden
            
            #line 22 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateOutputBufferDeclare(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 23 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n//Function to initialize buffers.\r\n");
            
            #line 26 "E:\development\TestSupportTools_0_2_0\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubHeaderBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateInitializeFunctionDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
