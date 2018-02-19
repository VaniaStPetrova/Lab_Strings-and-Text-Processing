using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string outputPrint = new string(line.Reverse().ToArray());

            Console.WriteLine(outputPrint);

        }
    }
}
