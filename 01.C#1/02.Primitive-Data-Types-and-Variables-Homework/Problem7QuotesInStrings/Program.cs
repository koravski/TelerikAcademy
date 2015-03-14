using System;

namespace Problem7QuotesInStrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string WithQuots = "The \"use\" of quotations causes difficulties.";
			string WithoutQuots = "The use of quotations causes difficulties.";


			Console.WriteLine (WithQuots);
			Console.WriteLine (WithoutQuots);
		}
	}
}
