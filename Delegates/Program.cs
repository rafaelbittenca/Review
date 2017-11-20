using System;
using System.Collections.Generic;

namespace Delegates
{
	delegate bool MyDelegate(int n);

	class Program
	{
		static void Main(string[] args)
		{
			PlayerStats[] myPlayers =
			{
				new PlayerStats {name="xx1", deaths=10, flagsCaptured=5, kills=18 },
				new PlayerStats {name="xx2", deaths=05, flagsCaptured=15, kills=20 },
				new PlayerStats {name="xx3", deaths=8, flagsCaptured=2, kills=25 },
				new PlayerStats {name="xx4", deaths=3, flagsCaptured=6, kills=15 }
			};

			var showStats = new DisplayPlayerNamesWithDelegates();
			showStats.OnGameOver(myPlayers);
			Console.WriteLine("------------------------------------");


			//------------Another Simple Example --------------
			
			int[] numbers = { 10, 5, 9, 8, 4, 3, 12, 7, 20 };

			IEnumerable<int> result =
				RunNumbersThroughCondition(numbers, GreaterThanTen);
			foreach(int number in result)
				Console.WriteLine(number);
			Console.WriteLine("------------------------------------");
			//With lambda 
			IEnumerable<int> result2 =
				RunNumbersThroughCondition(numbers, res=> res >15);
			foreach (int number in result2)
				Console.WriteLine(number);

			Console.ReadLine();
		}

		static bool LessThanTen(int n) { return n < 10; }
		static bool GreaterThanTen(int n) { return n > 10; }

		static IEnumerable<int> RunNumbersThroughCondition(int[] numbers, MyDelegate condition)
		{
			foreach (int number in numbers)
				if (condition(number))
					yield return number;
		}
	}
}
