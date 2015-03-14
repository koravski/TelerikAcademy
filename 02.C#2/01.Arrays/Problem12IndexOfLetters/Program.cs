/*Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] alpha = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            string word = Console.ReadLine();

            
            
                foreach (char symbol in word)
                {

                    for (int i = 0; i < 26; i++) 
                    { 

                        if (symbol == alpha[i])
                        {
                            Console.WriteLine("{0} is index {1}", symbol, i);
                        }
                         
                    }

               

                }

               

           
            


        }
    }
}
