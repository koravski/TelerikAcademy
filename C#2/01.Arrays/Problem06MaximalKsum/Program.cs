/*Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06MaximalKsum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write N: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            

            for (int i = 0; i < N; i++)
            {
                Console.Write("Index {0}--->",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Write K: ");
            int K = int.Parse(Console.ReadLine());
            

            Array.Sort(arr);
            int sum = 0;

            for (int i = 0; i < K; i++)
            {
                sum += arr[N-i-1];

            }

            Console.WriteLine("The sum of the {0} largest numbers is {1}",K, sum);

            
        }
    }
}
