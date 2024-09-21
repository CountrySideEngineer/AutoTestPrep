using Logger;
using System.Net.Http.Headers;
using System.Reflection;
using TestReader.Model;

namespace TestDoubleCodeGenerator.TestDouble.Template.Init
{
	public partial class BufferInitializeMethodTemplate
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferInitializeMethodTemplate() : base() { }

		public virtual string InitFunctionBuffer()
		{
			Log.TRACE();

			BufferTemplateCommonBase template = null;

			Function targetFunction = (Function)Target;

			if (targetFunction.HasReturn())
			{
				Log.DEBUG($"{targetFunction.Name} has return value.");

				template = new FunctionWithReturnValueBufferTemplate()
				{
					Target = targetFunction
				};
			}
			else
			{
				Log.DEBUG($"{targetFunction.Name} does not have return value.");

				template = new FunctionBufferTemplate()
				{
					Target = targetFunction
				};
			}
			string code = template.TransformText();

			Log.DEBUG($"{nameof(code),16} = {code}");

			return code;
		}

		public virtual string InitArgumentBuffers()
		{
			Log.TRACE();


			try
			{
				Function targetFunction = (Function)Target;

				string initCode = string.Empty;
				if ((null == targetFunction.Arguments) || 
					(!targetFunction.Arguments.Any()))
				{
					throw new NullReferenceException();
				}
				foreach (var argument in targetFunction.Arguments)
				{
					string code = InitArgumentBuffers(targetFunction, argument);
					initCode += code;
				}

				return initCode;
			}
			catch (NullReferenceException)
			{
				Log.INFO($"Function \"{Target.Name}\" has not argument.");
				Log.INFO($"Skip generating code to initialize buffers for argument.");

				string message =
					$"\t//\t\"{Target.Name}\" does not have argument." + Environment.NewLine +
					$"\t//\tSkip generating code to initialize buffers for argument.";
				return message;
			}
			catch (InvalidCastException)
			{
				Log.FATAL("Target data type is invalid.");

				throw;
			}
		}

		public virtual string InitArgumentBuffers(Function function, Parameter argument)
		{
			Log.TRACE();

			BufferTemplateCommonBase? template = null;

			Log.DEBUG($"{"ArgumentName",16} = \"{argument.Name}\"");
			Log.DEBUG($"{nameof(argument.PointerNum),16} = \"{argument.PointerNum}\"");

			if (0 == argument.PointerNum)
			{
				template = new ArgumentBufferTemplate()
				{
					Function = function
				};
			}
			else if (1 == argument.PointerNum)
			{
				Log.DEBUG($"{nameof(argument.Mode),16} = \"{argument.Mode}\"");

				if (argument.Mode == Parameter.ACCESS_MODE.IN)
				{
					template = new PointerArgumentBufferTemplate()
					{
						Function = function
					};
				}
				else if ((Parameter.ACCESS_MODE.OUT == argument.Mode) ||
					(Parameter.ACCESS_MODE.BOTH == argument.Mode))
				{
					template = new OutputSinglePointerArgumentBufferTemplate()
					{
						Function = function
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
				Log.DEBUG($"{nameof(argument.Mode),16} = \"{argument.Mode}\"");

				if (Parameter.ACCESS_MODE.OUT == argument.Mode) {
					template = new OutputDoublePointerArgumentBufferTemplate()
					{
						Function = function
					};
				}
				else
				{
					Log.ERROR("Not supported mode is set.");

					throw new ArgumentOutOfRangeException();
				}
			}
			else
			{
				Log.ERROR("Not supported pointer num is set.");

				throw new ArgumentOutOfRangeException();
			}

			template.Target = argument;

			string code = template.TransformText();

			Log.DEBUG($"{nameof(code),16} = {code}");

			return code;
		}
	}
}
