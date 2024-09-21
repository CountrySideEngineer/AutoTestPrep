﻿using Logger;

namespace TestReader.Converter
{
	internal class ExternalVariableConverter : VariableConverter
	{
		/// <summary>
		/// Returns type name of external variable.
		/// </summary>
		/// <returns>Type name of external variable.</returns>
		/// <remarks>
		/// "External variable" means global variable declined in the other soruce code file the function is implemented.
		/// </remarks>
		internal override string GetTypeName()
		{
			Log.TRACE();

			string typeName = Properties.Resources.IDS_TARGET_FUNCTION_TABLE_CLASSIFICATION_COL_ITEM_EXTERNAL;
			return typeName;
		}
	}
}
