﻿using Logger;

namespace TestReader.Config
{
	internal class FunctionListConfig : AConfiguration
	{
		/// <summary>
		/// Get FunctionList configuration from test configuration.
		/// </summary>
		/// <param name="config">Root configuration.</param>
		/// <returns>FunctionListConfiguration.</returns>
		/// <exception cref="FileLoadException">File invalid.</exception>
		protected override TestConfigurationElement GetConfigEelement(TestConfiguration config)
		{
			Log.TRACE();

			if (null != config.FunctionList)
			{
				return config.FunctionList;
			}
			else
			{
				throw new FileLoadException();
			}
		}
	}
}
