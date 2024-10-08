﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace TestParser.Data
{
	/// <summary>
	/// Test model class.
	/// </summary>
	public class Test
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public Test()
		{
			Target = null;
			TestCases = null;
			Name = string.Empty;
			TestInformation = string.Empty;
			SourceName = string.Empty;
			SourcePath = string.Empty;
		}

		/// <summary>
		/// Test target function class.
		/// </summary>
		public Function Target { get; set; }

		/// <summary>
		/// List of test data class.
		/// </summary>
		public IEnumerable<TestCase> TestCases { get; set; }

		/// <summary>
		/// Test name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// About test
		/// </summary>
		public string TestInformation { get; set; }

		/// <summary>
		/// Test source name.
		/// </summary>
		public string SourceName { get; set; }

		/// <summary>
		/// Path to file to test.
		/// </summary>
		public string SourcePath { get; set; }

		/// <summary>
		/// Shallow copy method.
		/// </summary>
		/// <returns>Shallow copied method.</returns>
		public Test ShalloCopy()
        {
			return (Test)MemberwiseClone();
        }

		/// <summary>
		/// Deep copy method.
		/// </summary>
		/// <returns>Deep copied method.</returns>
		public Test DeepCopy()
        {
			var copyItem = (Test)MemberwiseClone();

			copyItem.Target = Target.DeepCopy();
			copyItem.TestCases = new List<TestCase>(TestCases);

			copyItem.Name = string.Copy(Name);
			copyItem.TestInformation = string.Copy(TestInformation);
			copyItem.SourceName = string.Copy(SourceName);
			copyItem.SourcePath = string.Copy(SourcePath);

			return copyItem;
        }
	}
}
