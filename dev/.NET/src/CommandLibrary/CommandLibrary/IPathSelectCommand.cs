using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathCommandLibrary
{
	public interface IPathSelectCommand
	{
		public string Select(string defaultPath = "");
	}
}
