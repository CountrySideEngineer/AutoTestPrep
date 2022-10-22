using CodeGenerator.Stub.Template.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Stub.Source.Part
{
	public partial class BufferDeclareTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferDeclareTemplate() : base()
		{
			var rule = new Rule.NameRule();
			FunctionBufferTemplateFactory = new FuncBufferDecTemplateFactory(rule);
			ArgumentBufferTemplateFactory = new ArgBufferDecTemplateFactory(rule);
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="target">Target function data.</param>
		/// <param name="templateFactory">Template factory class.</param>
		public BufferDeclareTemplate(Rule.NameRule rule) : base()
		{
			FunctionBufferTemplateFactory = new FuncBufferDecTemplateFactory(rule);
			ArgumentBufferTemplateFactory = new ArgBufferDecTemplateFactory(rule);
		}
	}
}
