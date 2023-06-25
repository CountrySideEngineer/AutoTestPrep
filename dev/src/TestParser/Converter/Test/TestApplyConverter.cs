using System;
using System.Collections.Generic;
using System.Data;
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
		public override object Convert(DataTable src)
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
		protected IEnumerable<IEnumerable<int>> GetApplied(DataTable src)
		{
			TRACE($"{nameof(GetApplied)} in {nameof(TestApplyConverter)} called.");

			DataView dataView = new DataView(src);
			var indexes = new List<List<int>>();
			foreach (DataColumn column in src.Columns)
			{
				DataColumn col = src.Columns[column.ColumnName];
				IEnumerable<int> applied = GetApplied(src, col);
				indexes.Add(applied.ToList());
			}
			return indexes;
		}

		/// <summary>
		/// Returns the collection of index of applied test data.
		/// </summary>
		/// <param name="src">Collection of test data.</param>
		/// <returns>Collection of index of applied test data.</returns>
		protected IEnumerable<int> GetApplied(DataTable src, DataColumn column)
		{
			TRACE($"{nameof(GetApplied)} in {nameof(TestApplyConverter)} called.");

			DataView dataView = new DataView(src);
			DataTable extracted = dataView.ToTable(false, column.ColumnName);
			var indexes = extracted.AsEnumerable()
				.Select(_ => _[column.ColumnName])
				.Select((item, i) => new { Item = item, Index = i})
				.Where(_ => _.Item.ToString().ToLower().Equals(_applySign.ToLower()))
				.Select(_ => _.Index);
			return indexes;
		}
	}
}
