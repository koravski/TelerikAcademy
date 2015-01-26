/* Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;

namespace Problem1Sum3Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("a: ");
			double a = double.Parse (Console.ReadLine ());
			Console.Write ("b: ");
			double b = double.Parse (Console.ReadLine ());
			Console.Write ("c: ");
			double c = double.Parse (Console.ReadLine ());

			Console.WriteLine ("a+b+c = " + (a+b+c));
		}
	}
}
