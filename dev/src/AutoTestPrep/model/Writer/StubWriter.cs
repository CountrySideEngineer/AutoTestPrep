﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AutoTestPrep.Model.Tempaltes;

namespace AutoTestPrep.Model.Writer
{
	/// <summary>
	/// Class to write code of function stub, or mock into text file.
	/// </summary>
	public class StubWriter : IWriter
	{
		public void Write(string path, object[] parameters)
		{
			var stubWriters = new List<IWriter>
			{  
				new StubSourceWriter(),  
				new StubHeaderWriter() 
			};
			foreach	(var stubWriter in stubWriters)
			{
				stubWriter.Write(path, parameters);
			}
		}
	}
}
