using System;
class FourDigitNumber
{
	static void Main()
	{
		Console.Write("Enter four-digit number: ");
		int number = int.Parse(Console.ReadLine());
		while (number > 9999 || number < 1000) {
			Console.WriteLine("The number must be exactly 4 digits and cannot start with 0. Please, try again!");
			number = int.Parse(Console.ReadLine());
		}

		int num1 = number / 1000;
		int num2 = (number / 100) % 10;
		int num3 = (number / 10) % 10;
		int num4 = number % 10;
		int sum = num1 + num2 + num3 + num4;

		Console.WriteLine("sum of digits: " + sum);
		Console.WriteLine("reversed: {0}{1}{2}{3}", num4, num3, num2, num1);
		Console.WriteLine("last digit in front: {0}{1}{2}{3}", num4, num1, num2, num3);
		Console.WriteLine("second and third digits exchanged: {0}{1}{2}{3}", num1, num3, num2, num4);
	}
}