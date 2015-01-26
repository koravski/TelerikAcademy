using System;

namespace Problem03Divideby7and5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			Console.Write ("Write a number: ");
			int number;
			number = int.Parse(Console.ReadLine());

			bool IsDevided = true;

			IsDevided = (number % 5 == 0 && number % 7 == 0 && number != 0);

			if (IsDevided) {

				Console.WriteLine ("true");
			} else {
				Console.WriteLine ("false");
			}


			goto Start;
		}
	}
}
