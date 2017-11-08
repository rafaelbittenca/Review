namespace System
{
	public static class StringExtensions
    {
		public static string RemoveSpecialChars(this string str, string [] specialStr = null)
		{
			string[] especialChars = { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'" };

			if (specialStr != null) especialChars = specialStr;
			
			for (int i = 0; i < especialChars.Length; i++)
			{
				if (str.Contains(especialChars[i]))
					str = str.Replace(especialChars[i], "");
			}
			return str;
		}

		public static string RemoveDuplicateChars(this string str)
		{
			string table = "";
			string result = "";
			foreach(char val in str)
			{
				if (table.IndexOf(val) == -1)
				{
					table += val;
					result += val;
				}
			}
			return result;
		}

		public static string ReverseString(this string str)
		{
			var result = "";
			for (var i = str.Length-1; i >= 0; i--)
			{
				result += str[i];
			}
			return result;
		}

		public static int NumberOfWords(this string str)
		{
			var result = 0;
			str = str.Trim();

			if (str == "")
				return 0;

			while (str.Contains("  "))
				str = str.Replace("  ", " ");

			foreach (string i in str.Split(' '))
				result++;
			return result;
		}
	}
}
