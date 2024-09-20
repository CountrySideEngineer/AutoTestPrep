using Logger;
using System.Diagnostics.Contracts;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Body
{
	public partial class BodyTemplate
	{
		public BodyTemplate() : base() { }

		public virtual string ArgumentCode()
		{
			Log.TRACE();

			Function targetFunction = (Function)Target;

			Log.DEBUG($"{nameof(targetFunction.Name),16} = {targetFunction.Name}");

			string argumentCode = string.Empty;
			if ((null == targetFunction.Arguments) || (!targetFunction.Arguments.Any()))
			{
				throw new NullReferenceException();
			}
			foreach (var argument in targetFunction.Arguments)
			{
				string code = ArgumentCode(targetFunction, argument);
				argumentCode += code;
			}

			return argumentCode;
		}

		public virtual string ArgumentCode(Function function, Parameter argument)
		{
			Log.TRACE();
			Log.DEBUG($"{"ArgumentName",16} = \"{argument.Name}\"");
			Log.DEBUG($"{nameof(argument.PointerNum),16} = \"{argument.PointerNum}\"");

			BufferTemplateCommonBase? template = null;

			if (0 == argument.PointerNum)
			{
				if ((string.IsNullOrEmpty(argument.DataType)) || 
					(string.IsNullOrWhiteSpace(argument.DataType)) ||
					("void" == argument.DataType.ToLower()))
				{
					template = null;
				}
				else
				{
					template = new ArgumentBufferTemplate()
					{
						Function = function,
						Target = argument
					};
				}
			}
			else if (1 == argument.PointerNum)
			{
				if (Parameter.ACCESS_MODE.IN == argument.Mode)
				{
					template = new InputSinglePointerArgumentBufferTemplate()
					{
						Function = function,
						Target = argument
					};
				}
				else if (Parameter.ACCESS_MODE.OUT == argument.Mode)
				{
					template = new OutputSinglePointerArgumentBufferTemplate()
					{
						Function = function,
						Target = argument
					};
				}
				else if (Parameter.ACCESS_MODE.BOTH == argument.Mode)
				{
					template = new InputOutputSinglePointerArgumentBufferTemplate()
					{
						Function = function,
						Target = argument
					};
				}
				else
				{
					Log.ERROR("Not supported mode is set.");

					throw new ArgumentOutOfRangeException();
				}
			}
			else if (2 == argument.PointerNum)
			{
				template = new OutputDoublePointerArgumentBufferTemplate()
				{
					Function = function,
					Target = argument
				};
			}
			else
			{
				Log.ERROR("Not supported pointer is set.");

				throw new ArgumentOutOfRangeException();
			}

			string code = template?.TransformText() ?? string.Empty;

			Log.DEBUG($"{nameof(code),16} = {code}");

			return code;
		}

		public virtual string FunctionCode()
		{
			Log.TRACE();

			BufferTemplateCommonBase? template = null;

			Function targetFunction = (Function)Target;
			if (targetFunction.HasReturn())
			{
				template = new FunctionWithReturnValueBufferTemplate()
				{
					Target = targetFunction,
				};
			}
			else
			{
				template = new FunctionBufferTemplate()
				{
					Target = targetFunction
				};
			}
			string functionCode = template.TransformText();

			Log.DEBUG($"{nameof(functionCode),16} = {functionCode}");

			return functionCode;
		}
	}
}
