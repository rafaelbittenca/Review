using System;
using System.IO;

namespace AlgortGeneral
{
	public static class SumIntFile
    {
	  public static int TotalInt(string path)
	  {
		//Write a function that sums up integers from a text file, one int per line.
		StreamReader ar = new StreamReader(path);
		// Prepare the first line.
		int total = 0;
		string line = ar.ReadLine();
		while (line != null)
		{
		    // Split on space
		    string[] spl = line.Trim(' ').Split(' ');

		    int value;
		    // Try to parse the strings into the numbers and display the sum
		    for (int x = 0; x < spl.Length; x++)
		    {
			  string s = String.Join(string.Empty, System.Text.RegularExpressions.Regex.Split(spl[x], "[^\\d]"));
			  if (int.TryParse(s, out value)) { total += value; }
		    }
		    line = ar.ReadLine();
		}
		return total;
	  }
    }
}
