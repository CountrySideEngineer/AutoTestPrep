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
    
    #line 1 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class StubSourceBodyTemplate : StubTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n *\tStub of ");
            
            #line 8 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.TargetFunction.Name));
            
            #line default
            #line hidden
            this.Write(".\r\n */\r\n/*\r\n *\tDeclare buffers to store a value passed and pass.\r\n */\r\n//Declare " +
                    "a buffer to store the number of function calls.\r\n");
            
            #line 14 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctoinCalledCountBufferDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n//Declare a buffer to store a value the stub method should return.\r\n");
            
            #line 17 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctionReturnBufferDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 19 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
	if (null != this.TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            this.Write("//Declare buffer to store a value passed via arguments.\r\n");
            
            #line 21 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		foreach (var argItem in this.TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            
            #line 22 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateArgumentBufferDeclare(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 23 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		}	
            
            #line default
            #line hidden
            this.Write("\r\n//Declare buffer to store values the stub should return via argument, pointer.\r" +
                    "\n");
            
            #line 26 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		foreach (var argItem in this.TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            
            #line 27 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateOutputBufferDeclare(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 28 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		}	
            
            #line default
            #line hidden
            
            #line 29 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n//Initialize buffers.\r\n");
            
            #line 32 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateInitializeFunctionDeclare(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t");
            
            #line 34 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateCalledCountInitialize(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(" \r\n\tfor (int index = 0; index < STUB_BUFFER_SIZE_1; index++)\r\n\t{\r\n\t\t");
            
            #line 37 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateFunctionReturnBufferInitialize(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 38 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
	if (null != this.TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            
            #line 39 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		foreach (var argItem in this.TargetFunction.Arguments) { 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 40 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateArgumentBufferInitialize(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 41 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		}	
            
            #line default
            #line hidden
            this.Write("\t\tfor (int index2 = 0; index2 < STUB_BUFFER_SIZE_2; index2++)\r\n\t\t{\r\n");
            
            #line 44 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		foreach (var argItem in this.TargetFunction.Arguments) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 45 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateOutputArgumentInitialize(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 46 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		}	
            
            #line default
            #line hidden
            
            #line 47 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\t}\r\n}\r\n\r\n//Body of stub function.\r\n");
            
            #line 53 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.TargetFunction.ToString()));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t");
            
            #line 55 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateLatchReturnValueCode(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\t//Set argument into buffer.\r\n");
            
            #line 58 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
	if (null != this.TargetFunction.Arguments) {	
            
            #line default
            #line hidden
            
            #line 59 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		foreach (var argItem in this.TargetFunction.Arguments) { 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 60 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateArgumentBufferName(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("[");
            
            #line 60 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateFunctionCalledBufferName(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("] = ");
            
            #line 60 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argItem.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 61 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		}	
            
            #line default
            #line hidden
            this.Write("\r\n\t//Set back buffer value into argument.\r\n");
            
            #line 64 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		foreach (var argItem in this.TargetFunction.Arguments) { 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 65 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateSetOutputBufferToArgument(this.TargetFunction, argItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 66 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
		}	
            
            #line default
            #line hidden
            
            #line 67 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n\t//Increment called count;\r\n\t");
            
            #line 70 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctionCalledBufferName(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write("++;\r\n\r\n\t");
            
            #line 72 "E:\development\AutoTestPrep\dev\src\StubCodeGenerator\Template\StubSourceBodyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateReturnLatchedValueCode(this.TargetFunction)));
            
            #line default
            #line hidden
            this.Write(";\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
