using CodeGenerator.GoogleTest.Template;
using CodeGenerator.SDK.Data;
using Logger;

namespace CodeGenerator.GoogleTest
{
	public abstract class ACodeGenerator : ICodeGenerator
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public ACodeGenerator() { }

		public string Generate(CodeInput codeInput)
		{
			Log.TRACE();

			try
			{
				Log.INFO("Start generating test driver codes using google test frameworl.");
				Log.INFO($"{"Target function name",32} = {codeInput?.TestDesignData?.Target?.Name}");

				if (null == codeInput)
				{
					throw new NullReferenceException();
				}
				var template = GetTemplate(codeInput);

				string testCode = template.TransformText();

				return testCode;
			}
			catch (NullReferenceException)
			{
				Log.FATAL("Input data to generate code is invalid.");
				Log.FATAL($"Argument \"{nameof(codeInput)}\"");

				throw;
			}
		}

		protected abstract GoogleTestCodeTemplate GetTemplate(CodeInput codeInput);
	}
}
