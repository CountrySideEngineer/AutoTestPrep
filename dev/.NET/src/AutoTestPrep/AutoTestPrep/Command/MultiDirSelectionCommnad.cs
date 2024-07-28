using CustomUserControls.Command;
using DialogUserInterfaces.Command;
using DialogUserInterfaces.View;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.Command
{
	internal class MultiDirSelectionCommnad : ICustomUserCommand<string>
	{
		protected string _dirSplitter = ";";

		public MultiDirSelectionCommnad() : base() { }

		public string Execute(string parameter)
		{
			Log.TRACE();
			Log.DEBUG($"{"parameter", 16} = {parameter}");

			IEnumerable<string>? list = null;
			try
			{
				list = parameter.Split(_dirSplitter).ToList();
			}
			catch (Exception)
			{
				list = new List<string>();
			}

			var command = new MultiPathSelectionCommand();
			IEnumerable<string> result = command.Execute(list);

			IEnumerable<string> resultWihoutEmpty 
				= result.Where(_ => !string.IsNullOrEmpty(_) && !string.IsNullOrWhiteSpace(_));
			string resultInLine = string.Join(_dirSplitter, resultWihoutEmpty);

			return resultInLine;
		}
	}
}
