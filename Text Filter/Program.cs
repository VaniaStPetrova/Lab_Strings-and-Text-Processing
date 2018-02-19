using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                inputText = inputText.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(inputText);
        }
    }
}
