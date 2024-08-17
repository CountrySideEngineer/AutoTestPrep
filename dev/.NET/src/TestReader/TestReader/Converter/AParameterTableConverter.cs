using Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Model;

namespace TestReader.Converter
{
	internal abstract class AParameterTableConverter<T> : ITableConverter<T>
	{
		public abstract T Convert(DataTable data);

		protected virtual Parameter Row2Parameter(DataRow row)
		{
			Log.TRACE();

			string prefix = row["データ型前置修飾"].ToString() ?? string.Empty;
			List<string> prefixList = new List<string>();
			if (!string.IsNullOrEmpty(prefix))
			{
				prefixList.Add(prefix);
			}

			string dataType = row["データ型"].ToString() ?? string.Empty;
			if (string.IsNullOrEmpty(dataType))
			{
				Log.ERROR("Data type is not set.");

				throw new InvalidDataException();
			}

			string postfix = row["データ型後置修飾"].ToString() ?? string.Empty;
			List<string> postfixList = new List<string>();
			if (!string.IsNullOrEmpty(postfix))
			{
				postfixList.Add(postfix);
			}

			string funcName = row["名前"].ToString() ?? string.Empty;
			if (string.IsNullOrEmpty(funcName))
			{
				Log.ERROR("Function name is not set.");

				throw new InvalidDataException();
			}

			string inOut = row["入出力"].ToString() ?? string.Empty;
			Parameter.ACCESS_MODE accMode = Parameter.ACCESS_MODE.NONE;
			if (!string.IsNullOrEmpty(inOut))
			{
				try
				{
					accMode = Parameter.ToAccessMode(inOut);
				}
				catch (ArgumentOutOfRangeException)
				{
					Log.WARN($"Input access mode, \"{inOut}\", is invalid.");
					Log.WARN("The input is ignored and handle as \"NONE\".");

					accMode = Parameter.ACCESS_MODE.NONE;
				}
			}

			string description = row["備考/説明"].ToString() ?? string.Empty;

			int pointerNum = postfix.Where(_ => _ == '*').Count();

			Log.DEBUG($"{nameof(prefix),12} = {prefix}");
			Log.DEBUG($"{nameof(dataType),12} = {dataType}");
			Log.DEBUG($"{nameof(postfix),12} = {postfix}");
			Log.DEBUG($"{nameof(pointerNum),12} = {pointerNum}");
			Log.DEBUG($"{nameof(funcName),12} = {funcName}");
			Log.DEBUG($"{nameof(accMode),12} = {accMode}");
			Log.DEBUG($"{nameof(description),12} = {description}");

			Parameter parameter = new Parameter()
			{
				Prefix = prefixList,
				DataType = dataType,
				Postfix = postfixList,
				PointerNum = pointerNum,
				Name = funcName,
				Mode = accMode,
				Description = description,
			};
			return parameter;
		}
	}
}
