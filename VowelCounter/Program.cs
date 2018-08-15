using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigns Vowels in English (UK)
            var vowelList = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            // Asks user for Input
            Console.WriteLine("Enter something");
            // Assigns user input to string and converts string to lowerCase
            string userInput = Console.ReadLine().ToLower();
            // Counts amount of vowels from userInput
            int total = userInput.Count(c => vowelList.Contains(c));
            // Informs user of how many vowels in input
            Console.WriteLine("The number of vowels in your sentence is : {0}", total);
            // Displays Text
            Console.ReadLine();

        }
    }
}
