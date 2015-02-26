/*Problem 12. Parse URL

    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

Example:
URL 	Information
http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
[server] = telerikacademy.com
[resource] = /Courses/Courses/Details/212*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12ParseURL
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter URL: ");
            string text = Console.ReadLine();

            string[] url = text.Split(new[]{':', '/'}, StringSplitOptions.RemoveEmptyEntries);

           

            Console.WriteLine("[protocol] = {0}", url[0]);
            Console.WriteLine("[server] = {0}", url[1]);
            Console.Write("[resource] = /");

            for (int i = 2; i < url.Length; i++)
            {
                if (i==url.Length-1)
                {
                     Console.Write("{0}", url[i]);
                }
                else
                {
                    Console.Write("{0}/", url[i]);
                }
            }
            Console.WriteLine();
        }


    }
}
