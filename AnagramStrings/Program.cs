using AnagramStrings;
using System;

namespace ArraysChallenges
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Console.WriteLine(Anagram.CheckTwoAnagramStrings("the Morse code", "Here come dots"));
			Console.WriteLine(Anagram.CheckTwoAnagramStrings("the Morse codey", "Here come dotsx"));

			int[] array = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };
			Anagram.pair_sum(array, 7);

			Console.ReadLine();
		}
	}
}
