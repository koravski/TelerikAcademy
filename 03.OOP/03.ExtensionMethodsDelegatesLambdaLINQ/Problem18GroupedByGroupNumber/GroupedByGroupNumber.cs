﻿/*Problem 18. Grouped by GroupNumber

    Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
    Use LINQ.
*/

/*Problem 19. Grouped by GroupName extensions

    Rewrite the previous using extension methods.
*/
using System;
using System.Linq;

namespace Problem18_19GroupedByGroupNumber
{
    class GroupedByGroupNumber
    {
        public static void Main()
        {
            Student[] students = GenerateStudentArray();

            // Solution with LINQ query
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("Linq : ");
            Console.WriteLine(new string('=', 70));

            var orderedStudents = from st in students
                                  orderby st.GroupName
                                  select st;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            // Solution with extension methods
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("Extension Methods : ");
            Console.WriteLine(new string('=', 70));

            orderedStudents = students.OrderBy(st => st.GroupName);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('=', 70));
        }

        public static Student[] GenerateStudentArray()
        {
            string[] names = { "Ivan", "Ivanka", "Maria", "Gosho", "Bai Kostadin", "Radi", "Mitko", "Joro" };

            string[] groups = { "Maths", "Biology", "Law", "ComputerScience", "RoketScience" };

            Random rnd = new Random();

            Student[] students = new Student[rnd.Next(20, 31)];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(names[rnd.Next(0, names.Length)], groups[rnd.Next(0, groups.Length)]);
            }

            return students;
        }
    }
}
