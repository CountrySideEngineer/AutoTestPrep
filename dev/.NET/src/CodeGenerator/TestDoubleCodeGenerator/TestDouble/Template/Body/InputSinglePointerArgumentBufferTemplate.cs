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
    
    #line 1 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class InputSinglePointerArgumentBufferTemplate : ArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 11 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"

	string	calledCountBuffName = NameRule.CalledCount((Function)Function);
	string	argumentBuffName = NameRule.ArgumentBuffer(Function, Target);
	string	argumentName = Target.Name;
	string	argumentValueBuffName = NameRule.SinglePointerArgumentValueBuffer(Function, Target);
	string	argumentValueSizeBuffName = NameRule.SinglePointerArgumentValueSizeBuffer(Function, Target);

	Log.DEBUG($"{nameof(calledCountBuffName), 16} = {calledCountBuffName}");
	Log.DEBUG($"{nameof(argumentBuffName), 16} = {argumentBuffName}");
	Log.DEBUG($"{nameof(argumentName), 16} = {argumentName}");
	Log.DEBUG($"{nameof(argumentValueBuffName), 16} = {argumentValueBuffName}");
	Log.DEBUG($"{nameof(argumentValueSizeBuffName), 16} = {argumentValueSizeBuffName}");

            
            #line default
            #line hidden
            
            #line 24 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
 Log.TRACE(); 
            
            #line default
            #line hidden
            
            #line 25 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            this.Write("\tfor (int index = 0; index < ");
            
            #line 26 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argumentValueSizeBuffName));
            
            #line default
            #line hidden
            this.Write("[");
            
            #line 26 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(calledCountBuffName));
            
            #line default
            #line hidden
            this.Write("]; index++) {\r\n\t\t");
            
            #line 27 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argumentValueBuffName));
            
            #line default
            #line hidden
            this.Write("[");
            
            #line 27 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(calledCountBuffName));
            
            #line default
            #line hidden
            this.Write("][index] = ");
            
            #line 27 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Body\InputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argumentName));
            
            #line default
            #line hidden
            this.Write("[index];\r\n\t}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
