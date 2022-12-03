using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser.Target
{
	/// <summary>
	/// Parameter class
	/// </summary>
	public class Parameter
	{
		/// <summary>
		/// Definition of access mode.
		/// </summary>
		public enum AccessMode {
			In,     //Input
			Out,    //Output
			Both,   //Input and Output
			None,   //No access, error mode.
		}

		public static AccessMode ToMode(string mode)
		{
			var accessMode = AccessMode.None;
			if (0 == string.Compare(mode, "in", true))
			{
				accessMode = AccessMode.In;
			}
			else if (0 == string.Compare(mode, "out", true))
			{
				accessMode = AccessMode.Out;
			}
			else if (0 == string.Compare(mode, "in/out", true))
			{
				accessMode = AccessMode.Both;
			}
			else
			{
				throw new ArgumentException();
			}
			return accessMode;
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Parameter()
		{
			this.Name = string.Empty;
			this.DataType = string.Empty;
			this.Prefix = new List<string>();
			this.Postfix = new List<string>();
			this.PointerNum = 0;
			this.Mode = AccessMode.None;
			this.Overview = string.Empty;
			this.Description = string.Empty;
		}

		/// <summary>
		/// Copy constructor of Parameter object.
		/// </summary>
		/// <param name="src">Source Parameter object.</param>
		public Parameter(Parameter src)
		{
			this.Name = src.Name;
			this.DataType = src.DataType;
			this.Prefix = new List<string>(src.Prefix);
			this.Postfix = new List<string>(src.Postfix);
			this.PointerNum = src.PointerNum;
			this.Mode = src.Mode;
			this.Overview = src.Overview;
			this.Description = src.Description;
		}

		/// <summary>
		/// String data of access mode input.
		/// </summary>
		protected static string ModeInput = "input";

		/// <summary>
		/// String data of access mode output.
		/// </summary>
		protected static string ModeOutput = "output";

		/// <summary>
		/// String data of access mode both, input and output.
		/// </summary>
		protected static string ModeBoth = "in/out";

		/// <summary>
		/// Name of parameter
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Name of data type.
		/// </summary>
		public string DataType { get; set; }

		/// <summary>
		/// Prefix of data type.
		/// </summary>
		public IEnumerable<string> Prefix { get; set; }

		/// <summary>
		/// Postfix of data type.
		/// </summary>
		public IEnumerable<string> Postfix { get; set; }

		/// <summary>
		/// Number of pointer.
		/// </summary>
		public int PointerNum { get; set; }

		/// <summary>
		/// Access mode, input, output, or both.
		/// </summary>
		public AccessMode Mode { get; set; }

		/// <summary>
		/// Overview of this parameter.
		/// </summary>
		public string Overview { get; set; }

		/// <summary>
		/// Description of this 
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Returns parameter object in string.
		/// </summary>
		/// <returns>Parameter object in strign data.</returns>
		public override string ToString()
		{
			//Create data type string with prefix, postfix, and pointer code.
			string toString = string.Empty;
			try
			{
				foreach (var item in Prefix)
				{
					if (!(string.IsNullOrEmpty(item)) &&
						(!(string.IsNullOrWhiteSpace(item))))
					{
						toString += item;
						toString += " ";
					}
				}
			}
			catch (Exception)
			{
				//Skip prefix.
			}
			toString += this.DataType;
			try
			{
				bool isTop = true;
				foreach (var item in Postfix)
				{
					if (!(string.IsNullOrEmpty(item)) &&
						(!(string.IsNullOrWhiteSpace(item))))
					{
						if (!((isTop) && (item.Equals("*"))))
						{
							toString += " ";
						}
						toString += item;
						isTop = false;
					}
				}
			}
			catch (Exception)
			{
				//Skip postfix
			}
			toString += " ";
			toString += this.Name;
			return toString;
		}

		/// <summary>
		/// Returns actual data type, data type name and "*" with the number of pointer.
		/// </summary>
		/// <returns>Actual data type.</returns>
		public virtual string ActualDataType()
		{
			string actualDataType = string.Empty;

			actualDataType = this.DataType;
			for (int index = 0; index < this.PointerNum; index++)
			{
				actualDataType += "*";
			}
			return actualDataType;
		}

		/// <summary>
		/// Add prefix string.
		/// </summary>
		/// <param name="prefix">Prefix data in string.</param>
		public virtual void AddPrefix(string prefix)
		{
			if ((string.IsNullOrEmpty(prefix)) || (string.IsNullOrWhiteSpace(prefix)))
			{
				return;
			}
			else
			{
				var newPrefix = new List<string>(Prefix);
				newPrefix.Add(prefix);
				Prefix = newPrefix;
			}
		}

		/// <summary>
		/// Add postfix string.
		/// </summary>
		/// <param name="postfix">Prefix data in string.</param>
		public virtual void AddPostfix(string postfix)
		{
			if ((string.IsNullOrEmpty(postfix)) || (string.IsNullOrWhiteSpace(postfix)))
			{
				return;
			}else
			{
				var newPostfix = new List<string>(Postfix);
				newPostfix.Add(postfix);
				Postfix = newPostfix;
			}
		}
	}
}
