using CodeGenerator.SDK.Data;

namespace CodeGenerator
{
	public interface ICodeGenerator
	{
		string Generate(CodeInput codeInput);
	}
}
