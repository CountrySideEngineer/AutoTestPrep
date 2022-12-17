using CSEngineer.TestSupport.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.ParserException;
using TestParser.Target;

namespace TestParser.Converter
{
	/// <summary>
	/// Convert table item into Function object.
	/// </summary>
	public class FunctionConverter : AFunctionTableItemConverter
	{
		/// <summary>
		/// Convert function table content into Function object.
		/// </summary>
		/// <param name="src">Table item</param>
		/// <param name="dst">Reference to Function object to set converted.</param>
		public override void Convert(IEnumerable<string> src, ref Parameter dst)
		{
			try
			{
				string dataType = src.ElementAt(3);
				if ((string.IsNullOrEmpty(dataType)) || (string.IsNullOrWhiteSpace(dataType)))
				{
					ERROR("Variable data type has not been set.");
					throw new TestParserException(TestParserException.Code.PARSER_ERROR_TEST_FUNCTION_DATA_INVALID);
				}
				string name = src.ElementAt(5);
				if ((string.IsNullOrEmpty(name)) || (string.IsNullOrWhiteSpace(name)))
				{
					ERROR("Variable name has not been set.");
					throw new TestParserException(TestParserException.Code.PARSER_ERROR_TEST_FUNCTION_DATA_INVALID);
				}

				char[] deliminaters = { ' ', '\t', '\r', '\n', };

				dst.Prefix = src.ElementAt(2).Split(deliminaters);
				dst.DataType = dataType;
				string postfix = src.ElementAt(4);
				dst.Postfix = postfix.Split(deliminaters);
				dst.PointerNum = Util.GetPointerNum(postfix);
				dst.Name = name;
				try
				{
					dst.Description = src.ElementAt(7);
				}
				catch (ArgumentOutOfRangeException)
				{
					DEBUG($"Description about {name} has not been set, skip!");

					dst.Description = string.Empty;
				}
			}
			catch (ArgumentOutOfRangeException)
			{
				throw new TestParserException(TestParserException.Code.PARSER_ERROR_TEST_FUNCTION_DATA_INVALID);
			}
		}
	}
}
