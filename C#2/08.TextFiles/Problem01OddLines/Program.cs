/*Problem 1. Odd lines

    Write a program that reads a text file and prints on the console its odd lines.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem01OddLines
{
    class Program
    {
        static void Main()
        {
            const string Text = "../../OddLines.txt";
            Console.WriteLine("> Prints odd lines of text file...\n");
            using (StreamReader reader = new StreamReader(Text))
            {
                int lineCount = 1;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (lineCount++ % 2 != 0) Console.WriteLine(line);
                }
            }
        }
    }
}
