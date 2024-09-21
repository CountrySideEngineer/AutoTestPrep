using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
	public interface ICopy<T>
	{
		void CopyTo(T dst);

		T ShallowCopy();

		T DeepCopy();
	}
}
