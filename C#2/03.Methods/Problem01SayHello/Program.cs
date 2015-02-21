/*Problem 1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.

Example:
input 	output
Peter 	Hello, Peter!*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01SayHello
{
    class Program
    {
        static void Main()
        {
            AskName();

        }

        static void AskName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name); ;
        }
    }
}
