using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;

namespace TestParser.Converter.Test
{
	class TestApplyConverter : AContentConverter
	{
		protected const string _applySign = "A";

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TestApplyConverter() { }

		/// <summary>
		/// Convert Cotent object to collection of index applied data.
		/// </summary>
		/// <param name="src">Content object to be converted.</param>
		/// <returns>Collection of applied data indexes.</returns>
		public override object Convert(Content src)
		{
			TRACE($"{nameof(Convert)} in {nameof(TestApplyConverter)} called.");

			IEnumerable<IEnumerable<int>> content = GetApplied(src);
			return content;
		}

		/// <summary>
		/// Returns the collection of index of applied test data.
		/// </summary>
		/// <param name="src">TestData to be converted.</param>
		/// <returns>Collecton of index of applied test data.</returns>
		protected IEnumerable<IEnumerable<int>> GetApplied(Content src)
		{
			TRACE($"{nameof(GetApplied)} in {nameof(TestApplyConverter)} called.");

			var indexes = new List<List<int>>();
			for (int index = 0; index < src.ColCount(); index++)
			{
				IEnumerable<string> contents = src.GetContentsInCol(index);
				IEnumerable<int> applied = GetApplied(contents);
				indexes.Add(applied.ToList());
			}
			return indexes;
		}

		/// <summary>
		/// Returns the collection of index of applied test data.
		/// </summary>
		/// <param name="src">Collection of test data.</param>
		/// <returns>Collection of index of applied test data.</returns>
		protected IEnumerable<int> GetApplied(IEnumerable<string> src)
		{
			TRACE($"{nameof(GetApplied)} in {nameof(TestApplyConverter)} called.");

			IEnumerable<int> indexes = src.Select((item, i) => new { Item = item, Index = i })
				.Where(_ => _.Item.ToLower().Equals(_applySign.ToLower()))
				.Select(_ => _.Index);
			return indexes;
		}
	}
}
