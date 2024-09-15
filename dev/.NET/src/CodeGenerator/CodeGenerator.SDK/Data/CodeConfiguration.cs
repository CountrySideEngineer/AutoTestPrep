using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.SDK.Data
{
	public class CodeConfiguration
	{
		/// <summary>
		/// Size of buffer 1, 100 is set in default.
		/// </summary>
		public int BufferSize1 { get; set; } = 100;

		/// <summary>
		/// Size of buffer 2, 100 is set in default.
		/// </summary>
		public int BufferSize2 { get; set; } = 100;

		/// <summary>
		/// Collection of standard header files the test code should includes.
		/// </summary>
		public IEnumerable<string> StandardHeaderFiles { get; set; } = new List<string>();

		/// <summary>
		/// Collectin of user hdar files the test codes should includes.
		/// </summary>
		public IEnumerable<string> UserHeaderFiles { get; set; } = new List<string>();

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CodeConfiguration() { }

		/// <summary>
		/// Add standard header file the test code should includes.
		/// </summary>
		/// <param name="fileName">Standard header file name.</param>
		public void AddStdHeader(string fileName)
		{
			if (null == StandardHeaderFiles)
			{
				StandardHeaderFiles = new List<string>();
			}
			((List<string>)StandardHeaderFiles).Add(fileName);
		}

		/// <summary>
		/// Add standard header files the test code should includes.
		/// </summary>
		/// <param name="fileNames">Standard header file names.</param>
		public void AddStdHeaders(IEnumerable<string> fileNames)
		{
			foreach (var fileName in fileNames)
			{
				AddStdHeader(fileName);
			}
		}

		/// <summary>
		/// Add user header file the test code should includes.
		/// </summary>
		/// <param name="fileName">User header file name.</param>
		public void AddUserHeader(string fileName)
		{
            if (null == UserHeaderFiles)
			{
				UserHeaderFiles = new List<string>();
			}
			((List<string>)UserHeaderFiles).Add(fileName);
        }

		/// <summary>
		/// Add user header files the test code should includes.
		/// </summary>
		/// <param name="fileNames">User header file names.</param>
		public void AddUserHeader(IEnumerable<string> fileNames)
		{
			foreach (var fileName in fileNames)
			{
				AddUserHeader(fileName);
			}
		}
	}
}
