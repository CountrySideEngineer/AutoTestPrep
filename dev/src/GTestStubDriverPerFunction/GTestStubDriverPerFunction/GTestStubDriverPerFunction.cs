using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StubDriverPlugin.GTestStubDriver;
using CountrySideEngineer.ProgressWindow.Model;
using CountrySideEngineer.ProgressWindow.Task;
using CountrySideEngineer.ProgressWindow.Task.Interface;

namespace GTestStubDriverPerFunction.GTestStubDriverPerFunction
{
    public class GTestStubDriverPerFunction : GTestStubDriver
    {
        protected override void SetupAction(ref AsyncTask<ProgressInfo> task)
        {
			task.TaskAction = ((progress) =>
			{
				_progress = progress;

				var pluginExecute = new GTestStubDriverPerFunctionExecute();
				pluginExecute.NotifyPluginProgressDelegate += NotifyParseProgress;
				pluginExecute.NotifyPluginFinishDelegate += NotifyPluginFinish;
				_pluginOutput = pluginExecute.Execute(_pluginInput);
			});
		}
	}
}
