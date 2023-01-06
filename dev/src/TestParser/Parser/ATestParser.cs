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
using TestParser.Config;
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
		public ATestParser() : base(string.Empty) { }

		/// <summary>
		/// Constructor with target.
		/// </summary>
		/// <param name="target"></param>
		public ATestParser(string target) : base(target) { }

		/// <summary>
		/// Common read sequence.
		/// </summary>
		/// <param name="stream">Stream to read.</param>
		/// <returns>Object read data from stream converted.</returns>
		protected override object Read(Stream stream)
		{
			ITableReader reader = GetReader(stream);
			string tableName = GetTableName();
			Content content = reader.GetTable(tableName);
			IContentConverter converter = GetConverter();
			object converted = converter.Convert(content);

			return converted;
		}

		/// <summary>
		/// Abstract method which returns 
		/// </summary>
		/// <returns>Converter to convert read data.</returns>
		public abstract IContentConverter GetConverter();

		protected abstract string GetTableName();
	}
}
