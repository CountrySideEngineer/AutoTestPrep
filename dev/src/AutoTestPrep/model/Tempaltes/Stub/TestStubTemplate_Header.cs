﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AutoTestPrep.Model.Tempaltes.Stub
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class TestStubTemplate_Header : TestStubTemplate_Base
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("#pragma once\r\n");
            
            #line 8 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
 foreach (var functionItem in Function.SubFunctions) { 
            
            #line default
            #line hidden
            this.Write("\t\r\n//Sub function called count.\r\n");
            
            #line 10 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctionCalledCountBufferDecalre(functionItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 11 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctionReturnBufferDeclare(functionItem)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n//Argument buffer.\r\n");
            
            #line 14 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
 foreach (var argumentItem in functionItem.Arguments) { 
            
            #line default
            #line hidden
            
            #line 15 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctionArgumentBufferDeclare(functionItem, argumentItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 16 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
	}	
            
            #line default
            #line hidden
            this.Write("//Return value buffer\r\n");
            
            #line 18 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
 foreach (var argumentItem in functionItem.Arguments) { 
            
            #line default
            #line hidden
            
            #line 19 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateFunctionOutputBufferDeclare(functionItem, argumentItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 20 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
	}	
            
            #line default
            #line hidden
            
            #line 21 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"
	}	
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 23 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Stub\TestStubTemplate_Header.tt"

	/// <summary>
	/// Create code declaring variable to set the count the function called.
	/// </summary>
	/// <param name="function">Function information</param>
	/// <returns>Code to declare variable to set the count function called.</returns>
	protected override string CreateFunctionCalledCountBufferDecalre(Function function)
	{
		string calledCountBufferName = base.CreateFunctionCalledCountBufferDecalre(function);
		calledCountBufferName = "extern " + calledCountBufferName;
		calledCountBufferName += ";";
		return calledCountBufferName;
	}

	protected override string CreateFunctionReturnBufferDeclare(Function function)
	{
		string returnBufferName = base.CreateFunctionReturnBufferDeclare(function);
		if (!(string.IsNullOrEmpty(returnBufferName))) {
			returnBufferName = "extern " + returnBufferName;
			returnBufferName += "[];";
		}
		return returnBufferName;
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}