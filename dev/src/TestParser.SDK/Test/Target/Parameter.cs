﻿using System;
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
		protected static string _modeIn = "in";
		protected static string _modeOut = "out";
		protected static string _modeInOut = "in/out";

		/// <summary>
		/// Definition of access mode.
		/// </summary>
		public enum AccessMode {
			In,     //Input
			Out,    //Output
			Both,   //Input and Output
			None,   //No access, error mode.
		}

		/// <summary>
		/// Convert mode string into AccessMode object.
		/// </summary>
		/// <param name="mode">Mode in string data type.</param>
		/// <returns>Mode as AccessMode object.</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <remarks>The mode in string is not case sensitive.</remarks>
		public static AccessMode ToMode(string mode)
		{
			var modeInsensitive = mode.ToLower();
			var accessMode = AccessMode.None;
			if (modeInsensitive.Equals(_modeIn))
			{
				accessMode = AccessMode.In;
			}
			else if (modeInsensitive.Equals(_modeOut))
			{
				accessMode = AccessMode.Out;
			}
			else if (modeInsensitive.Equals(_modeOut))
			{
				accessMode = AccessMode.Both;
			}
			else
			{
				throw new ArgumentOutOfRangeException();
			}
			return accessMode;
		}

		/// <summary>
		/// Convert mode string into AccessMode object.
		/// </summary>
		/// <param name="mode">Mode in string data type.</param>
		/// <param name="defaultMode">Mode to be returned if the mode can not convert into the object.</param>
		/// <returns>Mode as AccessMode object.</returns>
		/// <remarks>The mode in string is not case sensitive.</remarks>
		public static AccessMode ToMode(string mode, AccessMode defaultMode)
		{
			try
			{
				AccessMode accessMode = ToMode(mode);
				return accessMode;
			}
			catch (ArgumentOutOfRangeException)
			{
				return default;
			}
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
			this.Name = string.Copy(src.Name);
			this.DataType = string.Copy(src.DataType);
			this.Prefix = new List<string>(src.Prefix);
			this.Postfix = new List<string>(src.Postfix);
			this.PointerNum = src.PointerNum;
			this.Mode = src.Mode;
			this.Overview = string.Copy(src.Overview);
			this.Description = string.Copy(src.Description);
		}

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
			string prefix = PrefixToString();
			if (!string.IsNullOrEmpty(prefix))
			{
				toString += prefix;
				toString += " ";
			}
			toString += DataType;
			toString += " ";
			string postfix = PostfixToString();
			if (!string.IsNullOrEmpty(postfix))
			{
				toString += postfix;
				toString += " ";
			}
			toString += Name;

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
				Prefix = Prefix.Append(prefix);
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
			}
			else
			{
				Postfix = Postfix.Append(postfix);
			}
		}

		/// <summary>
		/// Convert collection of prefix modifier to string.
		/// </summary>
		/// <returns>Prefix modifier in a string.</returns>
		protected virtual string PrefixToString()
		{
			string prefix = PScritpToString(Prefix);
			return prefix;
		}

		/// <summary>
		/// Converts a set of prepositions into a single string.
		/// </summary>
		/// <returns>Prefix modifier in a string.</returns>
		protected virtual string PostfixToString()
		{
			string postfix = PScritpToString(Postfix);
			return postfix;
		}

		/// <summary>
		/// Convert collection of script into a single string.
		/// </summary>
		/// <param name="scripts"></param>
		/// <returns></returns>
		protected virtual string PScritpToString(IEnumerable<string> scripts)
		{
			try
			{
				IEnumerable<string> scriptsWithoutEmpty =
					scripts.Where(_ => ((!string.IsNullOrEmpty(_)) && (!string.IsNullOrWhiteSpace(_))));
				string script = string.Join(" ", scriptsWithoutEmpty);
				return script;
			}
			catch (Exception ex)
			when ((ex is NullReferenceException) || (ex is ArgumentNullException))
			{
				string script = string.Empty;
				return script;
			}
		}

		/// <summary>
		/// Copy data to other Parameter object.
		/// </summary>
		/// <param name="dst">Parameter object to copy to.</param>
		public virtual void CopyTo(ref Parameter dst)
		{
			dst.Name = string.Copy(Name);
			dst.DataType = string.Copy(DataType);
			dst.Prefix = new List<string>(Prefix);
			dst.Postfix = new List<string>(Postfix);
			dst.PointerNum = PointerNum;
			dst.Mode = Mode;
			dst.Overview = string.Copy(Overview);
			dst.Description = string.Copy(Description);
		}

		/// <summary>
		/// Copy data from ohter Parameter object.
		/// </summary>
		/// <param name="src"></param>
		public virtual void CopyFrom(Parameter src)
		{
			Name = string.Copy(src.Name);
			DataType = string.Copy(src.DataType);
			Prefix = new List<string>(src.Prefix);
			Postfix = new List<string>(src.Postfix);
			PointerNum = src.PointerNum;
			Mode = src.Mode;
			Overview = string.Copy(src.Overview);
			Description = string.Copy(src.Description);
		}

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied method.</returns>
		public virtual Parameter ShallowCopy()
        {
			return (Parameter)MemberwiseClone();
        }

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied object.</returns>
		public virtual Parameter DeepCopy()
        {
			var copyItem = (Parameter)MemberwiseClone();

			CopyTo(ref copyItem);

			return copyItem;
        }
	}
}
