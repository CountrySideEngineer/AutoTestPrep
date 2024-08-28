using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.Command
{
	internal class ExecReadTestCommand : IPluginCommand
	{
		public object Execute(object argument)
		{
			Log.TRACE();

			return argument;
		}
	}
}
