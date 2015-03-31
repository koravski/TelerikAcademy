/*Problem 1. StringBuilder.Substring

    Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
*/
using System;
using System.Text;

namespace Problem01StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        static void Main()
        {
            var sb1 = new StringBuilder();
            sb1.Append("This is test text and some other text.");
            Console.WriteLine(sb1);

            //Test substring method
            var sb2 = sb1.Substring(8, 4);
            Console.WriteLine("{0}  ---->  this is the substring",sb2);
        }

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (index > sb.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length");
            }
            if (index > sb.Length - length)
            {
                throw new ArgumentOutOfRangeException("length");
            }
            if (length == 0)
            {
                return sb.Clear();
            }
            if (index == 0 && length == sb.Length)
            {
                return sb;
            }

            return new StringBuilder(sb.ToString().Substring(index, length));

        }

        public static StringBuilder Substring(this StringBuilder sb, int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("index");
            }
            if (index > sb.Length)
            {
                throw new ArgumentException("index");
            }

            return new StringBuilder(sb.ToString().Substring(index));
        
        }
    }


}
