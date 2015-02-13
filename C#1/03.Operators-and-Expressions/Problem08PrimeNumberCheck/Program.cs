using System;

namespace Problem8PrimeNumberCheck
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			int N = int.Parse (Console.ReadLine ());

			while (N >= 100) {

				Console.WriteLine ("Write a number smaller or equal 100");
				N = int.Parse (Console.ReadLine ());

			}

			bool isPime = N < 0 || N == 1 || (N % 2 == 0 && N != 2) || (N % 3 == 0 && N != 3) || (N % 5 == 0 && N != 5) || (N % 7 == 0 && N != 7);

			
			Console.WriteLine (!isPime);



			goto Start;
		}
	}
}
