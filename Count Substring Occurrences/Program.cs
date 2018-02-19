using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string searchedString = Console.ReadLine().ToLower();

            int count = input.Select((c, i) => input.Substring(i)).Count(sub => sub.StartsWith(searchedString));

            Console.WriteLine(count);
        }
    }
}
