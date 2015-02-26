/*Problem 22. Words count

    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22WordsCount
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] {' ', ',','!','.','?'}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var t in words)
            {
                if (!dict.ContainsKey(t))
                {
                    dict.Add(t, 1);
                }
                else
                {
                    dict[t]++;
                }
            }
            Console.WriteLine("\nLetter occurs:\n{0}\n",
            string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));

        }
    }
}
