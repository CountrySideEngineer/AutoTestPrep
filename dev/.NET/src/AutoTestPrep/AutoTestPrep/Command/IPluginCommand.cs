using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.Command
{
	internal interface IPluginCommand
	{
		object Execute(object argument);
	}

	internal interface IPluginCommand<T>
	{
		T Execute(T argument);
	}

	internal interface IPluginCommand<T, R>
	{
		R Execute(T argument);
	}
}
