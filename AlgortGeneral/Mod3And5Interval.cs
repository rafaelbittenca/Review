using System;

namespace AlgortGeneral
{
	public class Mod3And5Interval
    {
		public static void PrintMod3And5FromInterval(int start, int end)
		{
			if (end < start)
			{
				Console.WriteLine("End number should be higher than start.");
			}
			else
			{
				string result = "";
				for (int x = start; x <= end; x++)
				{
					if (x % 3 == 0)
						result += "fizz";
					if (x % 5 == 0)
						result += "buzz";
					if (result == "")
						Console.WriteLine(x);
					else
						Console.WriteLine(result);
					result = "";
				}
			}
		}
	}
}
