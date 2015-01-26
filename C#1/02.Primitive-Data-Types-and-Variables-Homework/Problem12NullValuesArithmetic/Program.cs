using System;

namespace Problem12NullValuesArithmetic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int? NullValueInt = null;
			decimal? NullValueM = null;

		

			Console.WriteLine ("Null  Integer: " + NullValueInt);
			Console.WriteLine ("Null Decimal: " + NullValueM);
			Console.WriteLine (NullValueM + 1);
		}
	}
}
