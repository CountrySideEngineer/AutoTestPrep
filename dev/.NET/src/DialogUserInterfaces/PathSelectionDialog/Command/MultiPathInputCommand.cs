using DialogUserInterfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogUserInterfaces.Command
{
	public class MultiPathInputCommand : DialogCommand<string>
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathInputCommand() : base() { }

		protected override Window GetDialog(string parameter)
		{
			var dialog = new MultiPathInputDialog();
			dialog.Path = parameter;

			return dialog;
		}

		protected override string GetDialogResult(Window window)
		{
			try
			{
				var dialog = (MultiPathInputDialog)window;
				string path = dialog.Path;
				return path;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
