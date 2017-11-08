using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AlgortGeneral
{
	public static class PhonesFromSearch
    {
        public static void ExtractPhonesFromSearch()
        {
            try
            {
                //Define the path
                string sourceDirectory = @"C:\Users\rafae\OneDrive\CA\Job Hunt\AplicacoesRafael\Codes\";

                //Creates List Files
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.html", SearchOption.AllDirectories);

                //Define the Regex expression
                string regex = @"\(?\d{3}\)?[-\s\.]?\d{3}[-\s\.]?\d{3,4}";
                /*                     
                    (?     - Matches the preceding character zero or one time
                    d{3}   - 3 Digits
                    \s     - Tab or space
                    d{3,4} - 3 or 4 digits (at least and at most time)
                */

                //Search for ever file
                foreach (string currentFile in txtFiles)
                {
                    MatchCollection matches = MatchRegex.MatchRegexFromFile(currentFile, regex);

                    // Use foreach-loop to match.
                    foreach (Match match in matches)
                    {
                        foreach (Capture capture in match.Captures)
                        {
                            Console.WriteLine("File={0}, Index={1}, Value={2}", currentFile, capture.Index, capture.Value);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
