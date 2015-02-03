using System;


namespace NextDate
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string day = Console.ReadLine();
			string month = Console.ReadLine();
			string year = Console.ReadLine();

			string today = month + "/" + day + "/" + year;

			DateTime dt = Convert.ToDateTime (today);
			DateTime tomorrow = dt.AddDays(1);
			Console.WriteLine("{0}.{1}.{2}", tomorrow.Day, tomorrow.Month, tomorrow.Year);


		}
	}
}
