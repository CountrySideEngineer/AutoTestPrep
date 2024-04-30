﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathCommandLibrary
{
	public class FolderPathSelectCommand : IPathSelectCommand
	{
		/// <summary>
		/// Select a folder by folder select dialog.
		/// </summary>
		/// <param name="initPath">Default folder dialog.</param>
		/// <returns>Path to folder selected by user.</returns>
		/// <exception cref="InvalidOperationException">Operation canceled.</exception>
		public string Select(string initPath = "")
		{
			Microsoft.Win32.OpenFolderDialog dialog = new();

			dialog.Multiselect = false;
			dialog.Title = Resources.IDS_PATH_SELECT_DIALOG_TITLE;
			if (!string.IsNullOrEmpty(initPath))
			{
				dialog.InitialDirectory = initPath;
			}
			bool? result = dialog.ShowDialog();

            if (true == result)
            {
				return dialog.FolderName;
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
	}
}
