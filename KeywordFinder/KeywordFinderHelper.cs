using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KeywordFinder
{
    public static class KeywordFinderHelper
    {
        /// <summary>
        /// Return number of occurences base on the inputed word
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int GetOccurences(string folderPath, string word)
        {
            int occurence = 0;

            try
            {
                foreach (var line in File.ReadLines(folderPath))
                {
                    occurence += Regex.Matches(line, word).Count;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid path: {folderPath}");
                return -1;
            }

            return occurence;
        }
    }
}
