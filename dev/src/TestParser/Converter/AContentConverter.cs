using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableReader.TableData;
using CSEngineer.Logger;

namespace TestParser.Converter
{
	public abstract class AContentConverter : IContentConverter, CSEngineer.Logger.Interface.ILog
	{
		public abstract object Convert(Content src);

		public void TRACE(string message)
		{
#if DEBUG
			var logger = Log.GetInstance();
			logger.TRACE(message);
#endif
		}

		public void DEBUG(string message)
		{
#if DEBUG
			var logger = Log.GetInstance();
			logger.DEBUG(message);
#endif
		}

		public void INFO(string message)
		{
			var logger = Log.GetInstance();
			logger.INFO(message);
		}

		public void WARN(string message)
		{
			var logger = Log.GetInstance();
			logger.WARN(message);
		}

		public void ERROR(string message)
		{
			var logger = Log.GetInstance();
			logger.ERROR(message);
		}

		public void FATAL(string message)
		{
			var logger = Log.GetInstance();
			logger.FATAL(message);
		}
	}
}
