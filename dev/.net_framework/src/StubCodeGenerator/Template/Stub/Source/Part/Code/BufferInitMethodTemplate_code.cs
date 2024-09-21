using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Stub.Template.Stub.Source.Part
{
	public partial class BufferInitMethodTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferInitMethodTemplate() : base()
		{
			var rule = new Rule.NameRule();
			FunctionBufferTemplateFactory = new FuncBufferInitTemplateFactory(rule);
			ArgumentBufferTemplateFactory = new ArgBufferInitTemplateFactory(rule);
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public BufferInitMethodTemplate(NameRule rule) : base()
		{
			FunctionBufferTemplateFactory = new FuncBufferInitTemplateFactory(rule);
			ArgumentBufferTemplateFactory = new ArgBufferInitTemplateFactory(rule);
		}
	}
}
