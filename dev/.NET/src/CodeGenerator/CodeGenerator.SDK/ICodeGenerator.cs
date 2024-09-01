using CodeGenerator.SDK.Data;

namespace CodeGenerator.SDK
{
	interface ICodeGenerator
	{
		string Generate(CodeInput codeInput);
	}
}
