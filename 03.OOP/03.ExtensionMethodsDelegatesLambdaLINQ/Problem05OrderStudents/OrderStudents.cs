﻿/*Problem 5. Order students

    Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    Rewrite the same with LINQ.
*/
using System;
using System.Linq;

namespace Problem05OrderStudents
{
    class OrderStudents
    {
        static void Main()
        {
            var students = new[] 
            {
                new { FirstName = "Pesho", LastName = "Peshev" },
                new { FirstName = "Gosho", LastName = "Goshev" },
                new { FirstName = "Ivan", LastName = "Ivanov" },
                new { FirstName = "Dobromir", LastName = "Enchev" },
                new { FirstName = "Svetozar", LastName = "Penov" }
            };

            var firstSort = students.OrderByDescending(st => st.FirstName)
                                .ThenByDescending(st => st.LastName);

            Console.WriteLine("1. Using LINQ extension method:");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(string.Join(Environment.NewLine, firstSort));
            Console.WriteLine();

            var secondSort =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("2. Using LINQ query:");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(string.Join(Environment.NewLine, secondSort));

        }
    }
}
