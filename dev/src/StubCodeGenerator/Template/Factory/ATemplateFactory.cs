using CodeGenerator.Stub.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParser.Target;

namespace CodeGenerator.Stub.Template.Factory
{
	public abstract class ATemplateFactory
	{
		/// <summary>
		/// Rule about name.
		/// </summary>
		public NameRule Rule { get; set; }

		/// <summary>
		/// Constructor with argument
		/// </summary>
		/// <param name="rule">Rule about name.</param>
		public ATemplateFactory(NameRule rule)
		{
			Rule = rule;
		}

		public abstract ABufferTemplate Create(Function function, Parameter argument);
	}
}
