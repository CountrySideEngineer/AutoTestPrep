using CustomUserControls.Command;
using DialogUserInterfaces;
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

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiDirSelectionCommnad() : base() { }

		/// <summary>
		/// Execute command 
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		public string Execute(string parameter)
		{
			Log.TRACE();
			Log.DEBUG($"{nameof(parameter),16} = {parameter}");

			IEnumerable<string>? list = null;
			try
			{
				list = parameter.Split(_dirSplitter).ToList();
			}
			catch (Exception)
			{
				list = new List<string>();
			}

			var command = new MultiPathSelectionCommand(Mode.DIALOG_FOLDER_SELECT);
			IEnumerable<string> result = command.Execute(list);

			IEnumerable<string> resultWihoutEmpty 
				= result.Where(_ => !string.IsNullOrEmpty(_) && !string.IsNullOrWhiteSpace(_));
			string resultInLine = string.Join(_dirSplitter, resultWihoutEmpty);

			return resultInLine;
		}
	}
}
