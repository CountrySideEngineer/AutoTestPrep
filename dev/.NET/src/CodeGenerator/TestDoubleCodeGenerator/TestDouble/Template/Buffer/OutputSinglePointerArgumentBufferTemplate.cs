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
    using TestDoubleCodeGenerator.Rule;
    using Logger;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class OutputSinglePointerArgumentBufferTemplate : PointerArgumentBufferTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 10 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"
	Log.TRACE(); 
            
            #line default
            #line hidden
            
            #line 11 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"
 base.TransformText(); 
            
            #line default
            #line hidden
            
            #line 12 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"

	string returnDataType = Argument.DataType;
	string returnBuffName = NameRule.SingglePointerArgumentReturnValueBuffer(Function, Argument);
	string returnBuffDec = NameRule.DeclareFormat(returnDataType, returnBuffName);
	string returnBuffDecCode = $"{returnBuffDec}[{NameRule.BufferSize1MacroName}][{NameRule.BufferSize2MacroName}];";

	Log.DEBUG($"{nameof(returnBuffDecCode),16} = \"{returnBuffDecCode}\"");

            
            #line default
            #line hidden
            
            #line 20 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnBuffDecCode));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 21 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"
 
	string sizeDataType = "long";
	string sizeBuffName = NameRule.SingglePointerArgumentReturnValueSizeBuffer(Function, Argument);
	string sizeBuffDec = NameRule.DeclareFormat(sizeDataType, sizeBuffName);
	string sizeBuffDecCode = $"{sizeBuffDec}[{NameRule.BufferSize1MacroName}];";

	Log.DEBUG($"{nameof(sizeBuffDecCode),16} = \"{sizeBuffDecCode}\"");

            
            #line default
            #line hidden
            
            #line 29 "E:\development\AutoTestPrep\dev\.NET\src\CodeGenerator\TestDoubleCodeGenerator\TestDouble\Template\Buffer\OutputSinglePointerArgumentBufferTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sizeBuffDecCode));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
