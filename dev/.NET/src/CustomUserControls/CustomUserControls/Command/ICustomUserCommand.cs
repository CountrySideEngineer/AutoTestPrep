using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomUserControls.Command
{
    public interface ICustomUserCommand<T>
    {
		T Execute(T parameter);
    }

	public interface ICustomUserCommand
	{
		object? Execute(object? parameter);
	}
}
