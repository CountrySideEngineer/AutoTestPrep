﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 17.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TestDoubleCodeGenerator.TestDouble.Template.Buffer
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
    
    #line 1 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class PointerArgumentBufferTemplate : ArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 11 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"
 Log.TRACE(); 
            
            #line default
            #line hidden
            
            #line 12 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            
            #line 13 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"

	string buffDataType = Target.DataType;
	string buffName = NameRule.SinglePointerArgumentValueBuffer(Function, Target);
	string buffDeclare = NameRule.DeclareFormat(buffDataType, buffName);
	string buffDecCode = $"{buffDeclare}[{NameRule.BufferSize1MacroName}][{NameRule.BufferSize2MacroName}];";

	Log.DEBUG($"{nameof(buffDecCode),16} = \"{buffDecCode}\"");

            
            #line default
            #line hidden
            
            #line 21 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(buffDecCode));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 22 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"

	string sizeBuffDataType = "long";
	string sizeBuffName = NameRule.SinglePointerArgumentValueSizeBuffer(Function, Target);
	string sizeBuffDeclare = NameRule.DeclareFormat(sizeBuffDataType, sizeBuffName);
	string buffSizeDecCode = $"{sizeBuffDeclare}[{NameRule.BufferSize1MacroName}];";

	Log.DEBUG($"{nameof(buffSizeDecCode),16} = \"{buffSizeDecCode}\"");

            
            #line default
            #line hidden
            
            #line 30 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\PointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(buffSizeDecCode));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
