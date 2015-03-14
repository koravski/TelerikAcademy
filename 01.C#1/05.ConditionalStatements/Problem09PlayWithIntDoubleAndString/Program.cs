/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
Example 1:

program	user
Please choose a type:	
1 --> int	
2 --> double	
3 --> string	3
Please enter a string:	hello
hello*	
Example 2:

program	user
Please choose a type:	
1 --> int	
2 --> double	2
3 --> string	
Please enter a double:	1.5
2.5*/
using System;

namespace Problem09PlayWithIntDoubleAndString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("1 --> int");
			Console.WriteLine ("2 --> double");
			Console.WriteLine ("3 --> string");
			Console.Write ("Please choose a type:");
			int n = int.Parse(Console.ReadLine());

			switch (n) {

			case 1:
				Console.Write ("Please enter an int: ");	
				int n1 = int.Parse(Console.ReadLine ());
				Console.WriteLine(n1 + 1);

				break;

			case 2:
				Console.Write ("Please enter a double: ");	
				string n2 = Console.ReadLine ();
				Console.WriteLine (n2 + 1);
				break;


			case 3:
				Console.Write ("Please enter a string: ");	
				string n3 = Console.ReadLine ();
				Console.WriteLine (n3 + "*");
				break;


			default:
				Console.WriteLine ("enter a number between 1 and 3");
				break;
			}



		}
	}
}
