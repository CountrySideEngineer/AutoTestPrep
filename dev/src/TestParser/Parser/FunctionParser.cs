﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSEngineer;
using CSEngineer.TestSupport.Utility;
using TestParser.Reader;
using TestParser;
using TestParser.Target;
using TestParser.ParserException;
using TestParser.Config;
using TestParser.Converter;
using TableReader.Excel;
using TableReader.TableData;
using System.Security;

namespace TestParser.Parser
{
	public class FunctionParser : ATestParser
	{
		/// <summary>
		/// Configuration of target function table parser.
		/// </summary>
		public FunctionTableConfig Config;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FunctionParser() : base() { }

		/// <summary>
		/// Constructor with argument, target sheet name.
		/// </summary>
		/// <param name="targe">Target sheet name.</param>
		public FunctionParser(string targe) : base(targe) { }

		/// <summary>
		/// Constructor with arguments, parsing configuration.
		/// </summary>
		/// <param name="config"></param>
		public FunctionParser(FunctionTableConfig config) : base()
		{
			Config = config;
		}

		public override IContentConverter GetConverter()
		{
			throw new NotImplementedException();
		}
	}
}
