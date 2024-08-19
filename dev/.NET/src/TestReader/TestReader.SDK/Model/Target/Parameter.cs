using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Properties = TestReader.Properties;

namespace TestReader.Model
{
	public class Parameter : ICopy<Parameter>
	{
		public enum ACCESS_MODE
		{
			IN,		// Input
			OUT,	// Output
			BOTH,	// Input/Output
			NONE	// No mode set.
		};

		protected static Dictionary<string, ACCESS_MODE> _modeDictionary = new Dictionary<string, ACCESS_MODE>()
		{
			{ Properties.Resources.IDS_PARAMETER_ACCESS_MODE_INPUT, ACCESS_MODE.IN },
			{ Properties.Resources.IDS_PARAMETER_ACCESS_MODE_OUTPUT, ACCESS_MODE.OUT },
			{ Properties.Resources.IDS_PARAMETER_ACCESS_MODE_BOTH, ACCESS_MODE.BOTH },
		};

		/// <summary>
		/// Convert mode string into ACCESS_MODE value.
		/// </summary>
		/// <param name="mode">Access mode in string.</param>
		/// <returns>Converted mode in ACCESS_MODE.</returns>
		/// <exception cref="ArgumentOutOfRangeException">The mode is invalid.</exception>
		/// <exception cref="ArgumentNullException">The mode value is null, not allowed.</exception>
		public static ACCESS_MODE ToAccessMode(string mode)
		{
			Log.TRACE();

			try
			{
				Log.TRACE();
				Log.DEBUG($"{nameof(mode), 12} = {mode}");

				string modeInsentive = mode.ToLower();
				ACCESS_MODE accessMode = _modeDictionary[modeInsentive];
				return accessMode;
			}
			catch (KeyNotFoundException)
			{
				string message = $"Mode \"{mode}\" is not supported.";
				Log.WARN(message);
				throw new ArgumentOutOfRangeException(message);
			}
			catch (NullReferenceException)
			{
				string message = $"Mode value must not null";
				Log.FATAL(message);
				throw new ArgumentNullException(message);
			}
		}

		/// <summary>
		/// Parameter name.
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Parameter data type.
		/// </summary>
		public string DataType { get; set; } = string.Empty;

		/// <summary>
		/// Collection of prefix of parameter data type.
		/// </summary>
		public IEnumerable<string>? Prefix { get; set; } = null;

		/// <summary>
		/// Collection of postfix of parameter data type.
		/// </summary>
		public IEnumerable<string>? Postfix { get; set; } = null;

		/// <summary>
		/// The number of pointer.
		/// </summary>
		public int PointerNum { get; set; } = 0;

		/// <summary>
		/// Access mode.
		/// </summary>
		public ACCESS_MODE Mode { get; set; } = ACCESS_MODE.NONE;

		/// <summary>
		/// Overview of parameter.
		/// </summary>
		public string Overview { get; set; } = string.Empty;

		/// <summary>
		/// Description of parameter.
		/// </summary>
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Convert scripts (pre- or post) into one line string.
		/// </summary>
		/// <param name="script">Collection of script to be converted.</param>
		/// <returns>Script in one line.</returns>
		protected virtual string ScriptToString(IEnumerable<string>? script)
		{
			Log.TRACE();

			if ((null == script) || (0 == script.Count()))
			{
				return string.Empty;
			}
			else
			{
				IEnumerable<string> scriptsWithoutEmpty = 
					script.Where(_ => (!string.IsNullOrEmpty(_)) && (!string.IsNullOrWhiteSpace(_)));
				string scriptString = string.Join(" ", scriptsWithoutEmpty);
				return scriptString;
			}
		}

		/// <summary>
		/// Convert prefix into one line.
		/// </summary>
		/// <returns>Prefix in one line.</returns>
		protected virtual string PrefixToString()
		{
			Log.TRACE();

			string prefix = ScriptToString(Prefix);
			return prefix;
		}

		/// <summary>
		/// Convert postfix into one line.
		/// </summary>
		/// <returns>Prefix in one line.</returns>
		protected virtual string PostfixToString()
		{
			Log.TRACE();

			string postfix = ScriptToString(Postfix);
			return postfix;
		}

		/// <summary>
		/// Get pointer sign in "*".
		/// </summary>
		/// <returns>Pointer sign.</returns>
		protected virtual string GetPointerSign()
		{
			Log.TRACE();

			string pointerNumSign = string.Empty;
			for (int index = 0; index < PointerNum; index++)
			{
				pointerNumSign += "*";
			}
			return pointerNumSign;
		}

		/// <summary>
		/// Returns parameter object in string.
		/// </summary>
		/// <returns>Parameter object in strign data.</returns>
		public override string ToString()
		{
			Log.TRACE();

			// Create data type string with prefix, postfix, and pointer code.
			var nameScipt = new List<string>();
			if (null != Prefix)
			{
				nameScipt.AddRange(Prefix);
			}
			nameScipt.Add(DataType);
			if (null != Postfix)
			{
				nameScipt.AddRange(Postfix);
			}
			nameScipt.Add(Name);

			string toString = ScriptToString(nameScipt);
			return toString;
		}

		/// <summary>
		/// Return data type with pointer.
		/// </summary>
		/// <returns>Actual data type.</returns>
		public virtual string ActualDataType()
		{
			Log.TRACE();

			string pointerSign = new string('*', PointerNum);
			string dataType = DataType + pointerSign;

			return dataType;
		}

		/// <summary>
		/// Copy data to other Parameter object.
		/// </summary>
		/// <param name="dst">Parameter object to copy to.</param>
		public virtual void CopyTo(Parameter dst)
		{
			Log.TRACE();

			dst.Name = new(Name);
			dst.DataType = new(dst.DataType);
			if (null != Prefix)
			{
				dst.Prefix = new List<string>(Prefix.ToList());
			}
			else
			{
				dst.Prefix = null;
			}
			if (null != Postfix)
			{
				dst.Postfix = new List<string>(Postfix.ToList());
			}
			else
			{
				dst.Postfix = null;
			}
			dst.PointerNum = PointerNum;
			dst.Mode = Mode;
			dst.Overview = new(Overview);
			dst.Description = new(Description);
		}

		/// <summary>
		/// Shallow copy.
		/// </summary>
		/// <returns>Shallow copied object.</returns>
		public virtual Parameter ShallowCopy()
		{
			Log.TRACE();

			return (Parameter)MemberwiseClone();
		}

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copy object.</returns>
		public virtual Parameter DeepCopy()
		{
			Log.TRACE();

			var copyItem = (Parameter)MemberwiseClone();
			CopyTo(copyItem);

			return copyItem;
		}
	}
}
