﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOfWords = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> solution = new List<string>();

            foreach (string word in lineOfWords)
            {
                if (word.SequenceEqual(word.Reverse()) && !solution.Contains(word))
                {
                    solution.Add(word);
                }
            }
            solution.Sort();

            Console.WriteLine(string.Join(", ", solution));

        }
    }
}
