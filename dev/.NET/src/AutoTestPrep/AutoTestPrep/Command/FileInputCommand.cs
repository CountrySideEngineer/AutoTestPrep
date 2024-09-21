using CustomUserControls.Command;
using Logger;
using System.Windows.Controls;

namespace AutoTestPrep.Command
{
	internal class FileInputCommand : ICustomUserCommand<string>
	{
		public string Execute(string parameter)
		{
			Log.TRACE();

			var command = new DialogUserInterfaces.Command.MultiPathInputCommand();
			string result = command.Execute(parameter);

			return result;
		}
	}
}
