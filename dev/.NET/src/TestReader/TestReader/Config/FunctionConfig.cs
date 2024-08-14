using Logger;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader.Config
{
	internal class FunctionConfig : AConfiguration
	{
		/// <summary>
		/// Get Function configuration from test configuration.
		/// </summary>
		/// <param name="config">Root configuration.</param>
		/// <returns>Function configuration.</returns>
		/// <exception cref="FileLoadException">File invalid.</exception>
		protected override TestConfigurationElement GetConfigEelement(TestConfiguration config)
		{
			Log.TRACE();

			if (null != config.Function)
			{
				return config.Function;
			}
			else
			{
				throw new FileLoadException();
			}
		}
	}
}
