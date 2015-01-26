using System;

namespace Problem11BankAccountData
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string FirstName ="Ivan";
			string MiddleName = "Nikolev";
			string LastName = "Ivanov";
			decimal balance = 1456.54m;
			string BankName = "First Investman Bank";
			string IBAN = "FIN457896544D78";
			ulong CardNumber1 = 1234123412341234;
			ulong CardNumber2 = 4434123412343333;;
			ulong CardNumber3 = 9999123412341234;;



			Console.WriteLine ("Fist Name: " + FirstName);
			Console.WriteLine ("Middle Name: " + MiddleName);
			Console.WriteLine ("Last Name: " + LastName);
			Console.WriteLine ("Balance: " + balance);
			Console.WriteLine ("Bank Name: " + BankName);	
			Console.WriteLine ("IBAN: " + IBAN);
			Console.WriteLine ("Credt Card 1: " + CardNumber1);
			Console.WriteLine ("Credt Card 2 " + CardNumber2);
			Console.WriteLine ("Credt Card 3 " + CardNumber3);
		

		}
	}
}
