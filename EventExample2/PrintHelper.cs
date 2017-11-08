using System;

namespace EventExample2
{
	public class PrintHelper
    {
		//declare delegate
		public delegate void BeforePrint();
		//declare event type delegate
		public event BeforePrint beforePrintEvent;

		public PrintHelper()
		{

		}

		public void PrintNumber(int number)
		{
			if (beforePrintEvent != null)
				beforePrintEvent();
			Console.WriteLine("Print number {0,-12:N0}", number);
		}

		public void PrintDecimal(int number)
		{
			if (beforePrintEvent != null)
				beforePrintEvent();
			Console.WriteLine("Print decimal {0:G}", number);
		}
	}
}
