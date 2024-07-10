using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogUserInterfaces.Command
{
    public interface IDialogCommand<T>
    {
		T Execute(T parameter);
    }

	public interface IDialogCommand
	{
		object Execute(object parameter);
	}
}
