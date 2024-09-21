using AutoTestPrep.ViewModel;
using Logger;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.Command
{
	internal class ExecReadTestCommand : 
		IPluginCommand<IEnumerable<TreeNodeBaseViewModel>>, 
		IPluginCommand<TreeNodeBaseViewModel>,
		IPluginCommand
	{
		public object Execute(object argument)
		{
			Log.TRACE();

			IEnumerable<TreeNodeBaseViewModel> nodes = (IEnumerable<TreeNodeBaseViewModel>)argument;
			IEnumerable<TreeNodeBaseViewModel> result = Execute(nodes);

			return nodes;
		}

		public IEnumerable<TreeNodeBaseViewModel> Execute(IEnumerable<TreeNodeBaseViewModel> argument)
		{
			Log.TRACE();

			foreach (TreeNodeBaseViewModel item in argument)
			{
				var projectItem = (ProjectTreeNodeViewModel)item;

				Log.DEBUG($"{nameof(projectItem.Title),16} : {projectItem.Title}");
				Log.DEBUG($"{nameof(projectItem.TestProjectConfig.TestInformation.TestSpecFilePath),16} : {projectItem.TestProjectConfig.TestInformation.TestSpecFilePath}");
			}

			return null;
		}

		public TreeNodeBaseViewModel Execute(TreeNodeBaseViewModel argument)
		{
			throw new NotImplementedException();
		}
	}
}
