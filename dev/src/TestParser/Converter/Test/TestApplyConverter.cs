using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;

namespace TestParser.Converter.Test
{
	class TestApplyConverter : IContentConverter
	{
		protected const string _applySign = "A";

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestApplyConverter() { }

		public object Convert(Content src)
		{
			IEnumerable<IEnumerable<int>> content = GetApplied(src);
			return content;
		}

		protected IEnumerable<IEnumerable<int>> GetApplied(Content src)
		{
			var indexes = new List<List<int>>();
			for (int index = 0; index < src.ColCount(); index++)
			{
				IEnumerable<string> content = src.GetContentsInCol(index);
				IEnumerable<int> applied = GetApplied(content, index);
				indexes.Add(applied.ToList());
			}
			return indexes;
		}

		protected IEnumerable<int> GetApplied(IEnumerable<string> src, int index)
		{
			IEnumerable<int> indexes = src.Select((item, i) => new { Item = item, Index = i })
				.Where(_ => _.Item.ToLower().Equals(_applySign))
				.Select(_ => _.Index);
			return indexes;
		}
	}
}
