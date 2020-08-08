using System;
using System.Configuration;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KeywordFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = ConfigurationManager.AppSettings["FolderPath"];

            Console.Write("Please enter word to search: ");
            var word = Console.ReadLine();

            Console.WriteLine($"Total number of occurence(s) for {word} is {KeywordFinder.GetOccurences(path, word)}");
  
            Console.ReadLine();
        }

    }
}
