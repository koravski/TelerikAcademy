using System;

namespace CoffeeMachine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double N1 = double.Parse (Console.ReadLine ());
			double N2 = double.Parse (Console.ReadLine ());
			double N3 = double.Parse (Console.ReadLine ());
			double N4 = double.Parse (Console.ReadLine ());
			double N5 = double.Parse (Console.ReadLine ());
			double A = double.Parse (Console.ReadLine ());
			double P = double.Parse (Console.ReadLine ());


			double TotalMachine = (N1 * 0.05) + (N2 * 0.1) + (N3 * 0.2) + (N4 * 0.5) + (N5 * 1);


			double Change = A - P;



			if (P > A  ) {
				Console.WriteLine ("More {0:F2}", P -A );

			}


			else if (Change <= TotalMachine ) {
				Console.WriteLine ("Yes {0:F2}", TotalMachine - Change );

			}


			 else if (Change > TotalMachine ) {
				Console.WriteLine ("No {0:F2}", Change - TotalMachine );

			}

			 

		}
	}
}
