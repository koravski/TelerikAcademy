using System;

namespace Problem1OddOrEvenIntegers
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Start:
			Console.Write ("Is it odd ");
			int number;
			number = Int32.Parse(Console.ReadLine());

			bool IsOdd = true; 



			if (number % 2 != 0)
			{
				Console.WriteLine(IsOdd);
			}
			else
			{
				Console.WriteLine(!IsOdd);
			}

			goto Start;





			/*Start:
			Console.Write ("Write a number: ");
			int number;
			number = Int32.Parse(Console.ReadLine());



			if (number % 2 != 0)
			{
				Console.WriteLine(number + " is odd");
			}
			else
			{
				Console.WriteLine(number + " is even");
			}

			goto Start;*/

		}
	}
}
