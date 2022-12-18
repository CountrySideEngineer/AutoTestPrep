using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using CSEngineer.Logger;
using TableReader.Interface;
using TableReader.TableData;
using TestParser.Converter;
using TestParser.ParserException;

namespace TestParser.Parser
{
	public abstract class ATestParser : AParser
	{
		/// <summary>
		/// Parser to read function list.
		/// </summary>
		public AParser FunctionListParser { get; set; }

		/// <summary>
		/// Parser to read function.
		/// </summary>
		public AParser FunctionParser { get; set; }

		/// <summary>
		/// Parser to read test cases.
		/// </summary>
		public AParser TestCaseParser { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ATestParser()
		{
			Target = string.Empty;
		}

		/// <summary>
		/// Constructor with target.
		/// </summary>
		/// <param name="target"></param>
		public ATestParser(string target)
		{
			Target = target;
		}

		protected override object Read(Stream stream)
		{
			ITableReader reader = GetReader(stream);
			Content content = reader.GetTable(Target);
			IContentConverter converter = GetConverter();
			object converted = converter.Convert(content);

			return converted;
		}

		public abstract IContentConverter GetConverter();
	}
}
