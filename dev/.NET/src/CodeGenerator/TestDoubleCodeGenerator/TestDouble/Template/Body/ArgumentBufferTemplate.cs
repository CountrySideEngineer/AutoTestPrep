﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 17.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TestDoubleCodeGenerator.TestDouble.Template.Body
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using TestReader.Model;
    using TestDoubleCodeGenerator.Rule;
    using Logger;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\ArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ArgumentBufferTemplate : BufferTemplateCommonBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 11 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\ArgumentBufferTemplate.tt"

	string	calledCountBuffName = NameRule.CalledCount((Function)Function);
	string	argumentBuffName = NameRule.ArgumentBuffer(Function, Target);
	string	argumentName = Target.Name;

            
            #line default
            #line hidden
            
            #line 16 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\ArgumentBufferTemplate.tt"
 Log.TRACE(); 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 17 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\ArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argumentBuffName));
            
            #line default
            #line hidden
            this.Write("[");
            
            #line 17 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\ArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(calledCountBuffName));
            
            #line default
            #line hidden
            this.Write("] = ");
            
            #line 17 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\ArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argumentName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
