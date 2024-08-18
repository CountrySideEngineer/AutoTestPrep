using Logger;

namespace TestReader.Converter
{
	internal class InternalVariableConverter : VariableConverter
	{
		/// <summary>
		/// Returns type name of internal variable.
		/// </summary>
		/// <returns>Type name of internal variable.</returns>
		/// <remarks>
		/// "Internal variable" means global variable declined in the same soruce code file the function is implemented.
		/// </remarks>
		internal override string GetTypeName()
		{
			Log.TRACE();

			string typeName = "内部";
			return typeName;
		}
	}
}
