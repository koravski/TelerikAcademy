/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
Examples:

a	b	c	result
254	11.6	0.5	FE |0011111110| 11.60|0.500 |
499	-0.5559	10000	1F3 |0111110011| -0.56|10000.000 |
0	3	-0.1234	0 |0000000000| 3.00|-0.123 |*/

using System;

class FormattingNumbers
{
	static void Main()
	{
		Console.Write("First number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Second number: ");
		double num2 = double.Parse(Console.ReadLine());
		Console.Write("Third number: ");
		double num3 = double.Parse(Console.ReadLine());
		string binary = Convert.ToString(num1, 2);
		if (num1 <= 500 & num1 >= 0) {
			Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:0.000}|", num1, binary.PadLeft(10, '0'), num2, num3);
		} else {
			Console.WriteLine("First number has to be 0 <= #NUMBER# >= 500.");
		}
	}
}