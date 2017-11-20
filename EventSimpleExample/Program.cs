using System;

namespace EventSimpleExample
{
	public delegate void myEventHandler(string signValue);

	class Program
	{
		static void Main(string[] args)
		{
			ExampleClass myEvent = new ExampleClass();
			myEvent.valueChanged += new myEventHandler(myEventValueChanged);

			//Could be use a Action
			//Action<string> f = myEventValueChanged;
			//myEvent.valueChanged = f;

			string str = "";
			do
			{
				str = Console.ReadLine();
				if (!str.Equals("exit"))
					myEvent.Value = str;
			} while (!str.Equals("exit"));

		}

		static void myEventValueChanged(string myNewValue)
		{
			Console.WriteLine("The value changed to {0}", myNewValue);
		}
	}

	public class ExampleClass
	{
		private string _value;
		public event myEventHandler valueChanged;

		//Could be use a Action too
		//public Action<string> valueChanged;

		public string Value
		{
			set
			{
				this._value = value;
				this.valueChanged(_value);
			}
		}
	}
}
