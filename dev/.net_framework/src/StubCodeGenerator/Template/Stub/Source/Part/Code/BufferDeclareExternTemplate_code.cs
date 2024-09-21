using CodeGenerator.Stub.Rule;
using CodeGenerator.Stub.Template.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Stub.Template.Stub.Source.Part
{
	public partial class BufferDeclareExternTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferDeclareExternTemplate() : base()
		{
			var rule = new Rule.NameRule();
			FunctionBufferTemplateFactory = new FuncBufferDecExternTemplateFactory(rule);
			ArgumentBufferTemplateFactory = new ArgBufferDecExternTemplateFactory(rule);
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="rule">Name rule.</param>
		public BufferDeclareExternTemplate(NameRule rule) : base()
		{
			FunctionBufferTemplateFactory = new FuncBufferDecExternTemplateFactory(rule);
			ArgumentBufferTemplateFactory = new ArgBufferDecExternTemplateFactory(rule);
		}
	}
}
