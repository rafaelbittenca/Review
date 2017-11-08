using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AlgortGeneral
{
	public static class MatchRegex
    {
        public static MatchCollection MatchRegexFromFile(string currentFile, string regex)
        {
            try
            {
                // Input string.
                string value = File.ReadAllText(currentFile);

                //Get a collection of matches.
                MatchCollection matches = Regex.Matches(value, regex, RegexOptions.IgnoreCase);
                return matches;
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("Something wrong happened when trying to convert the expression: {0}", e.Message));
            }
        }
    }
}
