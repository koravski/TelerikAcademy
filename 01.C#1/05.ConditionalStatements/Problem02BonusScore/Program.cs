/* Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
Examples:

score	result
2	20
4	400
9	9000
-1	invalid score
10	invalid score
*/

using System;

namespace Problem02BonusScore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			int a = int.Parse(Console.ReadLine());

			if (a > 9 || a < 1) {
				Console.WriteLine ("Invalid score");
			}

			else if (a>=1 && a<=3) {

				Console.WriteLine (a*10);

			}

			else if (a>=4 && a<=6) {

				Console.WriteLine (a*100);

			}

			else if (a>=7 && a<=9) {

				Console.WriteLine (a*1000);

			}
			goto Start;
		}
	}
}
