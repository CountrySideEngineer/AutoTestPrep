using CodeGenerator;
using CodeGenerator.SDK.Data;
using Logger;
using System.Collections.Specialized;
using TestDoubleCodeGenerator.TestDouble.Template;

namespace TestDoubleCodeGenerator.TestDouble
{
    public abstract class ACodeGenerator : ICodeGenerator
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ACodeGenerator() { }

        public virtual string Generate(CodeInput codeInput)
        {
			Log.TRACE();

			Log.INFO($"Start generating test dobule.");

			try
			{
				if (null == codeInput)
				{
					throw new NullReferenceException();
				}
				var template = GetTemplate(codeInput);
				string codes = template.TransformText();

				return codes;
			}
			catch (NullReferenceException)
			{
				Log.FATAL("Input data to generagte code is invalid.");
				Log.FATAL($"Argument \"{nameof(codeInput)}\".");

				throw;
			}
		}

		protected abstract TestDoubleCodeTemplate GetTemplate(CodeInput codeInput);
	}
}
