using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
	//public class Logger
	//{
	//	public void Log(string message, LogType logType)
	//	{
	//		switch (logType)
	//		{
	//			case LogType.Console:
	//				Console.WriteLine(message);
	//				break;
	//			case LogType.File:
	//				//some code
	//				break;
	//		}
	//	}
	//}

	//public enum LogType
	//{
	//	Console,
	//	File
	//}

	/// <summary>
	/// *** Open / Closed Principal ***
	/// Open to Extension
	/// Closed for Modification
	/// Use interfaces
	/// Limits the need to change code once it has been tested and debugged
	/// Reduces risks of introducing new bugs
	/// Reduced coupling
	/// </summary>

	public class Logger
	{
		IMessageLogger _messageLogger;

		public Logger(IMessageLogger messageLogger)
		{
			_messageLogger = messageLogger;
		}

		public void Log(string message)
		{
			_messageLogger.Log(message);
		}

	}
	public interface IMessageLogger
	{
		void Log(string message);
	}

	public class ConsoleLogger : IMessageLogger
	{
		public void Log(string message)
		{
			Console.WriteLine("Console log implementation Msg: {0}", message);
		}
	}


	public class PrinterLogger : IMessageLogger
	{
		public void Log(string message)
		{
			Console.WriteLine("Printer log implementation Msg: {0}", message);
		}
	}
}
