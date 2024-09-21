﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Target
{
	public class Function : Parameter
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public Function() : base()
		{
			this.Arguments = new List<Parameter>(0);
			this.SubFunctions = new List<Function>(0);
			this.InternalVariables = new List<Parameter>(0);
			this.ExternalVariables = new List<Parameter>(0);
		}

		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="src"></param>
		public Function(Function src) : base(src)
		{
			if (src is Function)
			{
				this.SubFunctions = new List<Function>(src.SubFunctions);
				this.Arguments = new List<Parameter>(src.Arguments);
				this.InternalVariables = new List<Parameter>(src.InternalVariables);
				this.ExternalVariables = new List<Parameter>(src.ExternalVariables);
			}
		}

		/// <summary>
		/// List of sub functions.
		/// </summary>
		public IEnumerable<Function> SubFunctions { get; set; }

		/// <summary>
		/// List of  arguments.
		/// </summary>
		public IEnumerable<Parameter> Arguments { get; set; }

		/// <summary>
		/// Create string of funtion definition.
		/// </summary>
		/// <returns>Function definition in string.</returns>
		public override string ToString()
		{
			var toString = base.ToString();
			toString += "(";
			try
			{
				bool isTop = true;
				foreach (var argument in Arguments)
				{
					if (!isTop)
					{
						toString += ", ";
					}
					toString += argument.ToString();
					isTop = false;
				}
			}
			catch (NullReferenceException)
			{
				//No argument -> Skip!
			}
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
		public bool HasReturn()
		{
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
		/// Copy data to other Function object.
		/// </summary>
		/// <param name="dst">Function object to copy to.</param>
		public virtual void CopyTo(ref Function dst)
		{
			Parameter param = dst as Parameter;
			base.CopyTo(ref param);

			dst.SubFunctions = new List<Function>(SubFunctions);
			dst.InternalVariables = new List<Parameter>(InternalVariables);
			dst.ExternalVariables = new List<Parameter>(ExternalVariables);
		}

		/// <summary>
		/// Copy data from ohter Function object.
		/// </summary>
		/// <param name="src"></param>
		public virtual void CopyFrom(Function src)
		{
			base.CopyFrom(src);

			SubFunctions = new List<Function>(src.SubFunctions);
			InternalVariables = new List<Parameter>(src.InternalVariables);
			ExternalVariables = new List<Parameter>(src.ExternalVariables);
		}

		/// <summary>
		/// Global variables declared in code the function is implemented.
		/// </summary>
		public IEnumerable<Parameter> InternalVariables { get; set; }

		/// <summary>
		/// Gloval variables declared in code the function is not implemented.
		/// </summary>
		public IEnumerable<Parameter> ExternalVariables { get; set; }

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied method.</returns>
        public new Function ShallowCopy()
        {
			return (Function)MemberwiseClone();
        }

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied method.</returns>
		public new Function DeepCopy()
        {
			var copyItme = (Function)MemberwiseClone();

			CopyTo(ref copyItme);

			return copyItme;
        }
    }
}