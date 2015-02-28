﻿/*Problem 11. Prefix "test"

    Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Problem11PrefixTest
{
    class Program
    {
        static void Main()
        {
            const string PATH_TEXT = "../../text.txt";
            const string PATH_OUTPUT = "../../result.txt";
            ExtractTextWithoutTags(PATH_TEXT, PATH_OUTPUT);
        }
        static void ExtractTextWithoutTags(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = Regex.Replace(reader.ReadLine(), @"\btest\S*", String.Empty).Trim();
                        result.Write(line);
                    }
                }
            }
        }
    }
}
