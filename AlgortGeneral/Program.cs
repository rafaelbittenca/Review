using System;
using System.Threading.Tasks;

namespace AlgortGeneral
{
	class Program
	{
		private static string resultTask;
		static async Task<string> SaySomething()
		{
			await Task.Delay(5);
			//Thread.Sleep(5);
			resultTask = "Hello world!";
			return "Something";
		}

		static void Main(string[] args)
		{
			#region asyncawait
			#endregion
			SaySomething();
			Console.WriteLine("Result: " + resultTask);

			Console.ReadLine();
			#region General
			//Search Phones Files - Regular Expression
			//PhonesFromSearch.ExtractPhonesFromSearch();
			//Calculate FibonacciNumber ??
			//int number = 144;
			//int result = FibonacciNumber.CalculateFibonacci(number);
			//Console.Write("Fibonacci numer for {0} is {1}\n", number, result);
			//int length = Convert.ToInt32(number);
			//for (int i = 0; i < length; i++)
			//{
			//	Console.Write("{0} ", FibonacciNumber.FibonacciSeries(i));
			//}
			//Console.ReadKey();

			//Find the largest int value in an int array. 
			//var array = new int[] { 1, 2, 4, 10, 50, 2, 45, 33, 1, 4 };
			//var max = array.Max();


			//var evenNumbers = ArrayExtensions.EvenNumbers(array);
			//var total = ArrayExtensions.TotalEvenNumbers(array);

			//FindMaxNumberArray.FindMax(array);
			//int index = -1;
			//int maxValue = Int32.MinValue;
			//for (int x = 0; x < array.Length; x++)
			//{
			//	int value = array[x];
			//	if (value > maxValue)
			//	{
			//		maxValue = value;
			//		index = x;
			//	}
			//}
			//Console.WriteLine(string.Format("The max value is {0} position {1}", maxValue, index));


			//var array2 = new double[] { 1.0, 2.0, 4.0, 10.8, 10.9, 2.0 };
			//var index2 = array2.MaxIndexOf();
			//Console.WriteLine($"Maximum int {array2[index2]} is found at index {index2}");

			//Grade multiplication 12x12
			//MultTableGrade.ShowTableGrade();
			//Rafa
			//int number = 4;
			//for (var i = 1; i <= number; i++)
			//{
			//	Console.WriteLine("\n");
			//	for (var j = 1; j <= number; j++)
			//	{
			//		Console.Write("{0,6} ", i * j);
			//	}
			//}

			//OddNumbers (pares)
			//OddNumber.ShowOddNumber(50);
			//int number = 50;
			//for(var i = 0; i <= number;i++)
			//{
			//	if (i % 2 != 0) {
			//		Console.WriteLine("{0} ", i);
			//	}
			//}

			//Reverse String
			//string originalString = "Today is a great day!!";
			//var reverseText = ReverseString.ReverseText(originalString);
			//Console.WriteLine(string.Format("The reverse string of: {0} is: {1}", originalString ,reverseText));

			//char[] array = text.ToCharArray();
			//Array.Reverse(array);
			//return new String(array);

			//RGB
			//Color myColor = Color.FromArgb(70, 130, 180);
			//string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
			//Console.WriteLine(string.Format("The hexadecimal color for ARGB color {0} is {1}: ", myColor, hex));

			//Write a function that sums up integers from a text file, one int per line.
			//int total = SumIntFile.TotalInt(@"C:\Users\rafae\OneDrive\CA\Job Hunt\AplicacoesRafael\Codes\111.txt");
			//Console.WriteLine(string.Format("Total int in the file: {0}", total));

			#endregion

			//int index = 111;
			//int result = 0;
			//index = Convert.ToInt32(index);
			//for (var i=0; i < index; i++)
			//{
			//	result = FibonanciRafa.CalcFibonanci(i);
			//	Console.Write("{0} ", result.ToString());
			//}
			//Console.WriteLine(string.Format("The Fibonanci number {0} is {1}", index, result.ToString()));

			//-----------------------------------------------------------------------------------------------
			//MSDN
			//// Declare and initialize an array.
			//string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

			//// Pass the array as an argument to PrintArray.
			//PrintArray(weekDays);

			//// ChangeArray tries to change the array by assigning something new
			//// to the array in the method. 
			//ChangeArray(weekDays);

			//// Print the array again, to verify that it has not been changed.
			//System.Console.WriteLine("Array weekDays after the call to ChangeArray:");
			//PrintArray(weekDays);
			//System.Console.WriteLine();

			//// ChangeArrayElements assigns new values to individual array
			//// elements.
			//ChangeArrayElements(weekDays);

			//// The changes to individual elements persist after the method returns.
			//// Print the array, to verify that it has been changed.
			//System.Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
			//PrintArray(weekDays);
			//------------------------------------------------------------------------------------------------------

			// Declare an instance of class A, class B, and class C.
			A a = new A();
			B b = new B();
			C c = new C();

			// For a, b, and c, call the following methods:
			//      -- MethodA with an int argument
			//      -- MethodA with a string argument
			//      -- MethodB with no argument.

			// A contains no MethodA, so each call to MethodA resolves to 
			// the extension method that has a matching signature.
			a.MethodA(1);           // Extension.MethodA(object, int)
			a.MethodA("hello");     // Extension.MethodA(object, string)

			// A has a method that matches the signature of the following call
			// to MethodB.
			a.MethodB();            // A.MethodB()

			// B has methods that match the signatures of the following
			// method calls.
			b.MethodA(1);           // B.MethodA(int)
			b.MethodB();            // B.MethodB()

			// B has no matching method for the following call, but 
			// class Extension does.
			b.MethodA("hello");     // Extension.MethodA(object, string)

			// C contains an instance method that matches each of the following
			// method calls.
			c.MethodA(1);           // C.MethodA(object)
			c.MethodA("hello");     // C.MethodA(object)
			c.MethodB();            // C.MethodB()

			//-------------------------------------------------------------------------
			Mod3And5Interval.PrintMod3And5FromInterval(1, 50);
			Console.Read();

			Console.ReadLine();
		}

		//static void PrintArray(string[] arr)
		//{
		//	for (int i = 0; i < arr.Length; i++)
		//	{
		//		System.Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
		//	}
		//	System.Console.WriteLine();
		//}
		//static void ChangeArray(string[] arr)
		//{
		//	// The following attempt to reverse the array does not persist when
		//	// the method returns, because arr is a value parameter.
		//	arr = (arr.Reverse()).ToArray();
		//	// The following statement displays Sat as the first element in the array.
		//	System.Console.WriteLine("arr[0] is {0} in ChangeArray.", arr[0]);
		//}

		//static void ChangeArrayElements(string[] arr)
		//{
		//	// The following assignments change the value of individual array 
		//	// elements. 
		//	arr[0] = "Sat";
		//	arr[1] = "Fri";
		//	arr[2] = "Thu";
		//	// The following statement again displays Sat as the first element
		//	// in the array arr, inside the called method.
		//	System.Console.WriteLine("arr[0] is {0} in ChangeArrayElements.", arr[0]);
		//}

	}
}
