using System;

namespace StringsExamples
{
	public static class Tools
	{
		public static void NumberOfOcurr(string str)
		{
			while (str.Length >0)
			{
				int total = 0;
				Console.Write(str[0] + ": ");
				for ( int i = 0; i < str.Length; i++)
				{
					if (str[0] == str[i])
						total++;
				}
				Console.WriteLine(total);
				str = str.Replace(str[0].ToString(), string.Empty);
			}
		}

		public static int SumNumberDigits(int num)
		{
			if (num != 0)
			{
				return (num % 10 + SumNumberDigits(num / 10));
			}
			else
			{
				return 0;
			}
		}
	}
}
