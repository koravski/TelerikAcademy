/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:

numbers	sum
1 2 3 4 5	15
10 10 10 10 10	50
1.5 3.14 8.2 -1 0	11.84
*/
using System;

class SumOf5Numbers
{
	static void Main()
	{
		Console.WriteLine("Enter five numbers in a position separated by a space:");
		string [] numbers = new string[5];
		double sum = 0;
		numbers =Console.ReadLine().Split();
		for (int i = 0; i < numbers.Length; i++)
		{
			sum += Convert.ToDouble(numbers[i]); 
		}
		Console.WriteLine(sum);
	}
}