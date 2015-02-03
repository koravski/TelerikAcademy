using System;

namespace gaeden
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			double TomatoAmount = double.Parse (Console.ReadLine ());
			byte TomatoArea = byte.Parse (Console.ReadLine ());
			double CucumberAmount = double.Parse (Console.ReadLine ());
			byte CucumberArea = byte.Parse (Console.ReadLine ());
			double PotatoAmount = double.Parse (Console.ReadLine ());
			byte PotatoArea = byte.Parse (Console.ReadLine ());
			double CarrotAmount = double.Parse (Console.ReadLine ());
			byte CarrotArea = byte.Parse (Console.ReadLine ());
			double CabbageAmount = double.Parse (Console.ReadLine ());
			byte CabbageArea = byte.Parse (Console.ReadLine ());
			double BeansAmount = double.Parse (Console.ReadLine ());



		

			double TotalCost = (TomatoAmount * 0.5) + (CucumberAmount * 0.4) + (PotatoAmount * 0.25) + (CarrotAmount * 0.6) + (CabbageAmount * 0.3);

			double TotalArea = TomatoArea + CucumberArea + PotatoArea + CarrotArea + CabbageArea; 





			if (250 - TotalArea > 0) {
				Console.WriteLine ("Total costs: {0:F2}", TotalCost + (BeansAmount * 0.4));

				Console.WriteLine ("Beans area: " + (250 - TotalArea));

			}

			else if (TotalArea > 250) {
				Console.WriteLine ("Total costs: {0:F2}", TotalCost + (BeansAmount * 0.4));
				Console.WriteLine ("Insufficient area");
			}

			else if (TotalArea == 250) {
				Console.WriteLine ("Total costs: {0:F2}", TotalCost + (BeansAmount * 0.4));
				Console.WriteLine ("No area for beans");
			}



		}
	}
}
