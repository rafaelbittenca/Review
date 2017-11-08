using System;

namespace EventExample2
{
	public class Number
    {
		private PrintHelper _printHelper;

		public int Val { get; set; }

		public Number(int val)
		{
			this.Val = val;
			_printHelper = new PrintHelper();
			_printHelper.beforePrintEvent += printHelper_beforePrintEvent;
		}

		private void printHelper_beforePrintEvent()
		{
			Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
		}

		public void PrintNumber()
		{
			_printHelper.PrintNumber(Val);
		}

		public void PrintDecimal()
		{
			_printHelper.PrintDecimal(Val);
		}
	}
}
