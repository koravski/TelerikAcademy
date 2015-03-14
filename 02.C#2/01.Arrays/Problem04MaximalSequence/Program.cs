/*Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.

Example:
input 	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04MaximalSequence
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int counter = 0;
            int maxCounter = 0;
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int next = i + 1;

                if (i<arr.Length-1)
                {
                    if (arr[i] == arr[next])
                    {
                        counter += 1;
                       
                    }else
	                    {
                            counter = 0;

	                    }

                    if (counter>maxCounter)
                    {
                        maxCounter = counter;

                        number = arr[i];
                        
                    }
                
                }
            }
                for (int i = 0; i < maxCounter + 1; i++)
                {
                     Console.Write(number);
                }

                Console.WriteLine();
        }
    }
}
