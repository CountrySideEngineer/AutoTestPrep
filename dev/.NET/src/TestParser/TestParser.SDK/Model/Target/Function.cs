using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Model
{
	public class Function : Parameter, ICopy<Function>
	{
		/// <summary>
		/// Collection of argument of function.
		/// </summary>
		public IEnumerable<Parameter>? Arguments { get; set; } = null;

		/// <summary>
		/// Collection of functin the function will call.
		/// </summary>
		public IEnumerable<Function>? SubFunctions { get; set; } = null;

		/// <summary>
		/// Collection of global variables declared in the source file the method is implemented.
		/// </summary>
		public IEnumerable<Parameter>? InternalVariables { get; set; } = null;

		/// <summary>
		/// Collection of global variables declared other source file the method is implemented.
		/// </summary>
		public IEnumerable<Parameter>? ExternalVariables { get; set; } = null;

		/// <summary>
		/// Copy data to other Function object.
		/// </summary>
		/// <param name="dst">Function object to copy to.</param>
		public virtual void CopyTo(Function dst)
		{
			Log.TRACE();

			Parameter dstParam = dst as Parameter;
			base.CopyTo(dstParam);

			if (null != SubFunctions)
			{
				dst.SubFunctions = new List<Function>(SubFunctions);
			}
			else
			{
				dst.SubFunctions = null;
			}
			if (null != InternalVariables)
			{
				dst.InternalVariables = new List<Parameter>(InternalVariables);
			}
			else
			{
				dst.InternalVariables = null;
			}
			if (null != ExternalVariables)
			{
				dst.ExternalVariables = new List<Parameter>(ExternalVariables);
			}
			else
			{
				dst.ExternalVariables = null;
			}
		}

		/// <summary>
		/// Create string of function definition in string.
		/// </summary>
		/// <returns>Function definition in string.</returns>
		public override string ToString()
		{
			Log.TRACE();

			string toString = base.ToString();
			toString += "(";

			string arguments = string.Empty;
			if (null != Arguments)
			{
				arguments = string.Join(", ", Arguments);
			}
			toString += arguments;
			toString += ")";

			return toString;
		}

		/// <summary>
		/// Returns whether the function will return any value or not.
		/// </summary>
		/// <returns>
		/// Returns true if the function will return any value, 
		/// otherwise return false.
		/// </returns>
		public virtual bool HasReturn()
		{
			Log.TRACE();

			bool hasReturn = false;
			if ((("void").Equals(this.DataType.ToLower(), StringComparison.Ordinal)) &&
				(PointerNum <= 0))
			{
				//A case that the data type without pointer means the function returns no value via return value.
				hasReturn = false;
			}
			else
			{
				hasReturn = true;
			}
			return hasReturn;
		}

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied object.</returns>
		public new Function ShallowCopy()
		{
			Log.TRACE();

			return (Function)MemberwiseClone();
		}

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied method.</returns>
		public new Function DeepCopy()
		{
			Log.TRACE();

			Function copyItem = (Function)MemberwiseClone();
			CopyTo(copyItem);
			return copyItem;
		}
	}
}
