﻿/*Problem 1. Allocate array

    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01AllocateArray
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;

            }

            for (int elemnts = 0; elemnts < array.Length; elemnts++)
            {
                if (elemnts < array.Length-1)
                {
                    Console.Write("{0}, ", array[elemnts]);
                }
                else
                {
                    Console.Write("{0}", array[elemnts]);
                }
                
            }
            Console.WriteLine();

           
        }
    }
}
