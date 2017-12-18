using System;
using System.Collections;
using System.Collections.Generic;

namespace AnagramStrings
{
	public static class Anagram
	{
		public static void pair_sum(int[] array, int sum)
		{
			for (int i = 0; i < array.Length; i++)
			{
				int first = array[i];
				for (int j = i + 1; j < array.Length; j++)
				{
					int second = array[j];
					if ((first + second) == sum)
					{
						Console.WriteLine("({0},{1})", first, second);
					}
				}
			}
		}

		public static bool CheckTwoAnagramStrings(string s1, string s2)
		{
			s1 = s1.Replace(" ", "").ToLower();
			s2 = s2.Replace(" ", "").ToLower();

			if (s1.Length != s2.Length)
				return false;

			Dictionary<char, int> myDictionary = new Dictionary<char, int>();
			Hashtable myHashTable = new Hashtable();

			foreach (char letter in s1)
			{
				if (myDictionary.ContainsKey(letter))
					myDictionary[letter] += 1;
				else
					myDictionary[letter] = 1;
			}

			foreach (char letter in s2)
			{
				if (myDictionary.ContainsKey(letter))
					myDictionary[letter] -= 1;
				else
					myDictionary[letter] = 1;
			}

			foreach (var i in myDictionary)
			{
				if (i.Value != 0)
					return false;
			};

			return true;
		}
	}
}
