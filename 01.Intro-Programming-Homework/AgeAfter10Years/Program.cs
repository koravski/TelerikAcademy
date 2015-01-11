using System;

namespace AgeAfter10Years
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Enter your birthday in format mm.dd.yyyy: ");
			DateTime userBirthday = DateTime.Parse(Console.ReadLine());
			long resulut = DateTime.Today.Subtract(userBirthday).Ticks;
			Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
			Console.WriteLine("After 10 years you will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
		}
	}
}
