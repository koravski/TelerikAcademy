﻿/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.

Examples:

input	output
3	1
2
3
5	1
2
3
4
5
1	1*/
using System;

namespace Problem08NumbersFrom1toN
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = int.Parse (Console.ReadLine ());



			for (int i = 1; i <= number; i++) {


				Console.WriteLine (i);

			}




		}
	}
}
