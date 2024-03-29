﻿using CodeGenerator.Stub.Template.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Stub.Source.Part
{
	public partial class TemplateCommonBase
	{
		public Function Target { get; set; }

		/// <summary>
		/// Template factory of function buffer.
		/// </summary>
		public ATemplateFactory FunctionBufferTemplateFactory { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public ATemplateFactory ArgumentBufferTemplateFactory { get; set; }
	}
}
