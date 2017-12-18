using System;
using System.Linq;

namespace AlgortGeneral
{
	public static class FindMaxNumberArray
	{
		public static void FindMax(int[] array)
		{
			int maxIndex = -1;
			int maxInt = Int32.MinValue;

			for (int i = 0; i < array.Length; i++)
			{
				int value = array[i];
				if (value > maxInt)
				{
					maxInt = value;
					maxIndex = i;
				}
			}

			Console.WriteLine($"Maximum int {maxInt} is found at index {maxIndex}");
		}
	}

	public static class ArrayExtensions
	{
		public static int MaxIndexOf<T>(this T[] input)
		{
			var max = input.Max();
			int index = Array.IndexOf(input, max);
			return index;
		}

		public static long TotalEvenNumbers(this int[] input)
		{
			return input.Where(i => i % 2 == 0).Sum(i => (long)i);
		}

		public static int[] EvenNumbers(this int[] input)
		{
			return input.Where(i => i % 2 == 0).ToArray();
		}
	}
}
