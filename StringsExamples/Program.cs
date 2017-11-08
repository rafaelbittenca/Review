using System;

namespace StringsExamples
{
	class Program
	{
		static void Main(string[] args)
		{
			string test = "tel@/0123;m,pp";
			Console.WriteLine(test.RemoveSpecialChars());

			test = "Rafael";
			Console.WriteLine(test.RemoveDuplicateChars());

			Console.WriteLine(test.ReverseString());

			string phrase = "Toronto is a  great city.";
			Console.WriteLine(phrase.NumberOfWords());

			Tools.NumberOfOcurr("Rafael");
			var input = 10345;
			var result = Tools.SumNumberDigits(input);
			Console.WriteLine(string.Format("Sum of {0} digits is {1}", input, result));
			Console.ReadLine();
		}
	}
}
