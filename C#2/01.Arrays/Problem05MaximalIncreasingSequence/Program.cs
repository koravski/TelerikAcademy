/*
    Write a program that finds the maximal increasing sequence in an array.

Example:
input 	result
3, 2, 3, 4, 2, 2, 4 	2, 3, 4*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 2, 3, 4, 2, 2, 4};

            int counter = 0;
            int maxCounter = 0;
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int next = i + 1;

                if (i < arr.Length - 1) 
                {
                    if (arr[i] == (arr[next]) - 1)
                    {
                        counter += 1;

                    }
                    else
                    {
                        counter = 0;

                    }

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;

                        number = arr[i-maxCounter+1];

                    }

                }
            }
            for (int i = 0; i <= maxCounter; i++)
            {
                Console.Write(number);
                number++;
            }

            Console.WriteLine();

        }
    }
}
