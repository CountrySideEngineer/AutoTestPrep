﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 16.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AutoTestPrep.Model.Tempaltes.Driver.gtest
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class TestDriverTemplate_gtest_Source : TestDriverTemplate_gtest_Base
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n *\t");
            
            #line 8 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.TargetFunction.Name));
            
            #line default
            #line hidden
            this.Write(" test driver source code.\r\n */\r\n");
            
            #line 10 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

	foreach (var headerFile in this.TestDataInfo.DriverIncludeStandardHeaderFiles) {
		if ((!(string.IsNullOrEmpty(headerFile))) && (!(string.IsNullOrWhiteSpace(headerFile)))) {

            
            #line default
            #line hidden
            this.Write("#include <");
            
            #line 14 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(headerFile));
            
            #line default
            #line hidden
            this.Write(">\r\n");
            
            #line 15 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
		
		}
	}

            
            #line default
            #line hidden
            
            #line 19 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

	foreach (var headerFile in this.TestDataInfo.DriverIncludeUserHeaderFiles) {
		if ((!(string.IsNullOrEmpty(headerFile))) && (!(string.IsNullOrWhiteSpace(headerFile)))) {

            
            #line default
            #line hidden
            this.Write("#include \"");
            
            #line 23 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(headerFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 24 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
		}
	}

            
            #line default
            #line hidden
            this.Write("\r\n//Test target function.\r\n");
            
            #line 29 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.TargetFunction.ToString()));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n//Setup test case.(Called before all test functions tun.)\r\n");
            
            #line 32 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateSetupTestCaseMethodEntryPointCode()));
            
            #line default
            #line hidden
            this.Write(" { }\r\n\r\n//Initialize test stub buffers.\r\n");
            
            #line 35 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateSetupMethodEntryPointCode()));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 37 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
 foreach (var subFunctionItem in this.SubFunctions) {	
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 38 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateInitializeStubMethodCall(subFunctionItem)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 39 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
	}	
            
            #line default
            #line hidden
            this.Write("}\r\n\r\n//Finalize test case.\r\n");
            
            #line 43 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTearDownMethodEntryPointCode()));
            
            #line default
            #line hidden
            this.Write(" { }\r\n\r\n//Finalize test cases.(Called after all test functions have run.)\r\n");
            
            #line 46 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateTearDownTestCaseMethodEntryPointCode()));
            
            #line default
            #line hidden
            this.Write(" { }\r\n\r\n//Test method\r\n");
            
            #line 49 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
 foreach (var testCase in this.Test.TestCases) {	
            
            #line default
            #line hidden
            this.Write("TEST_F(");
            
            #line 50 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(base.CreateTestClassName()));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 50 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.CreateTestCaseMethodName(testCase)));
            
            #line default
            #line hidden
            this.Write(")\r\n{\r\n\t//Declare arguments.\r\n");
            
            #line 53 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

	if ((null != this.TargetFunction.Arguments) && (0 < this.TargetFunction.Arguments.Count())) {
		foreach (var argumentItem in this.TargetFunction.Arguments) {

            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 57 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateCodeToDeclareArgument(argumentItem)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 58 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
		}	
	
	}

            
            #line default
            #line hidden
            this.Write("\r\n\t//Setup test values.\r\n");
            
            #line 64 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
	if ((null != testCase.Input) && (0 < testCase.Input.Count())) {
		foreach (var inputItem in testCase.Input) {

            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 67 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateCodeToSetUpTestParameter(inputItem)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 68 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("\t//Call target function.\r\n\t");
            
            #line 73 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateCodeToCallTargetFunction()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n\t//Check output and expectes.\r\n");
            
            #line 76 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

	if ((null != testCase.Expects) &&
		(0 < testCase.Expects.Count()))
	{
		foreach (var expectItem in testCase.Expects)
		{

            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 83 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreateCodeToCheckOutputAndExpect(expectItem)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 84 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("}\r\n\r\n");
            
            #line 90 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"
	}	
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 91 "E:\development\TestSupportTools\AutoTestPrep\dev\src\AutoTestPrep\Model\Tempaltes\Driver\gtest\TestDriverTemplate_gtest_Source.tt"

	//Methods used to create test driver code using google test as test framework.

	/// <summary>
	///	Create entry point of method to setup test case.
	///	</summary>
	/// <return>Entry point of method to setup test case.</return>
	protected virtual string CreateSetupTestCaseMethodEntryPointCode()
	{
		string setupTestCaseMethodEntryPointCode = string.Empty;
		setupTestCaseMethodEntryPointCode = $"void {base.CreateTestClassName()}" +
			"::" +
			$"{base.CreateTestSetUpMethodName()}()";
		return setupTestCaseMethodEntryPointCode;
	}

	/// <summary>
	///	Create entry point of method to setup test.
	///	</summary>
	///	<return>Entry point of method to setup test.</return>
	protected virtual string CreateSetupMethodEntryPointCode()
	{
		string setupMethodEntryPointCode = string.Empty;
		setupMethodEntryPointCode = $"void {base.CreateTestClassName()}" +
			"::" +
			$"{base.CreateSetupMethodName()}()";
		return setupMethodEntryPointCode;
	}

	/// <summary>
	///	Create code to call stub initialize method.
	///	</summary>
	/// <return>Code to call stub initialize method.</return>
	protected virtual string CreateInitializeStubMethodCall(Function subFunction)
	{
		string stubInitMethodCall = string.Empty;
		stubInitMethodCall = $"{subFunction.Name}_init();";
		return stubInitMethodCall;
	}

	/// <summary>
	///	Create entry point of method to tear down test.
	///	</summary>
	///	<return>Entry point of method to tear down test.</return>
	protected virtual string CreateTearDownMethodEntryPointCode()
	{
		string tearDownMethodEntryPointCode = string.Empty;
		tearDownMethodEntryPointCode = $"void {base.CreateTestClassName()}" +
			"::" +
			$"{base.CreateTearDownMethodName()}()";
		return tearDownMethodEntryPointCode;
	}

	/// <summary>
	///	Create entry point of method to tear down test cases.
	/// </summary>
	/// <return>Entry point of method to tear down test case.</return>
	protected virtual string CreateTearDownTestCaseMethodEntryPointCode()
	{
		string tearDownMethodTestCaseEntryPointCode = string.Empty;
		tearDownMethodTestCaseEntryPointCode = $"void {base.CreateTestClassName()}" +
			"::" +
			$"{base.CreateTestTearDownMethodName()}()";
		return tearDownMethodTestCaseEntryPointCode;
	}

	/// <summary>
	/// Create test case name.
	/// </summary>
	///	<return>test case name.</return>
	protected virtual string CreateTestCaseMethodName(TestCase testCase)
	{
		string testCaseMethodName = string.Empty;
		testCaseMethodName = $"{this.TargetFunction.Name}_{testCase.Id}";
		return testCaseMethodName;
	}

	///	<summary>
	///	Creat code to declare argument.
	///	</summary>
	///	<return>Code to declare argument.</return>
	protected virtual string CreateCodeToDeclareArgument(Parameter argument)
	{
		string declareArgumentCode = string.Empty;
		declareArgumentCode = argument.ToString();
		return declareArgumentCode;
	}

	///	<summary>
	///	Create code to set value to argument variable.
	///	</summary>
	///	<return>Code to set value to argument variable.</return>
	protected virtual string CreateCodeToSetUpTestParameter(TestData testData)
	{
		string codeToSetupTestParameter = string.Empty;
		codeToSetupTestParameter = $"{testData.Name} = {testData.Value}";
		return codeToSetupTestParameter;
	}

	///	<summary>
	///	Create code to call test target function.
	///	</summary>
	///	<return>Code to call test target function.</return>
	protected virtual string CreateCodeToCallTargetFunction()
	{
		string codeToCallTargetFunction = string.Empty;

		if (this.TargetFunction.HasReturn())
		{
			codeToCallTargetFunction = this.TargetFunction.DataType;
			codeToCallTargetFunction += " ";
			codeToCallTargetFunction += "returnValue = ";
		}
		codeToCallTargetFunction += this.TargetFunction.Name;
		codeToCallTargetFunction += "(";
		if (null != this.TargetFunction.Arguments) {
			bool isTop = true;
			foreach (var argumentItem in this.TargetFunction.Arguments) {
				if (!isTop)
				{
					codeToCallTargetFunction += ",";
					codeToCallTargetFunction += " ";
				}
				codeToCallTargetFunction += argumentItem.Name;
				isTop = false;
			}
		}
		codeToCallTargetFunction += ")";

		return codeToCallTargetFunction;
	}

	///	<summary>
	///	Create code to check output value whether it equals to expect.
	///	</summary>
	///	<return>Code to check output value whether it equals to expect.</return>
	protected virtual string CreateCodeToCheckOutputAndExpect(TestData expect)
	{
		string codeToCheckExpect = string.Empty;

		codeToCheckExpect = "ASSERT_EQ(";
		if (("return").Equals(expect.Name)) {
			codeToCheckExpect = $"{codeToCheckExpect}returnValue";
		}
		else
		{
			codeToCheckExpect = $"{codeToCheckExpect}{expect.Name}";
		}
		codeToCheckExpect = $"{codeToCheckExpect}, {expect.Value})";
		return codeToCheckExpect;
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
