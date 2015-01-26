/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:

program	user
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	2
Web site:	http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	25
Manager phone:	+359 2 981 981

Example output:

Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  

*/
using System;

namespace Problem2PrintCompanyInformation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Company name: ");
			string CompanyName = Console.ReadLine();

			Console.Write("Company address: ");
			string CompanyAddress = Console.ReadLine();

			Console.Write("Phone number: ");
			string PhoneNumber = Console.ReadLine();

			Console.Write("Fax number: ");
			string FaxNumber = Console.ReadLine();
			if (FaxNumber == string.Empty )
			{
				FaxNumber = "(no fax)";
			}

			Console.Write("Web site: ");
			string WebSite = Console.ReadLine();

			Console.Write("Manager first name: ");
			string ManagerFirstName = Console.ReadLine();

			Console.Write("Manager last name: ");
			string ManagerLastName = Console.ReadLine();

			Console.Write("Manager age: ");
			int ManagerAge = int.Parse(Console.ReadLine());

			Console.Write("Manager phone: ");
			string ManagerPhone = Console.ReadLine();

			Console.WriteLine ("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} (age: {6}, tel. {7})", CompanyName, CompanyAddress, PhoneNumber, FaxNumber, WebSite, ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone  );

		}
	}
}
