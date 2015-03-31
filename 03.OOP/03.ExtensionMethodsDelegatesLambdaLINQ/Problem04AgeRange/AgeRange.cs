/*Problem 4. Age range

    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
*/
using System;
using System.Linq;

namespace Problem04AgeRange
{
    class AgeRange
    {
        static void Main()
        {
            var students = new[]
            {
                new { FirstName = "Filip", LastName = "Georgiev", Age = 19 },
				new { FirstName = "Dimityr", LastName = "Cvetkov", Age = 18 },
				new { FirstName = "Cvetelina", LastName = "Dimitrova", Age = 25 },
				new { FirstName = "Boris", LastName = "Angelov", Age = 22 },
				new { FirstName = "Angel", LastName = "Borisov", Age = 17 } 
            
            };
            Console.WriteLine("Student between 18 and 24:");

            var result = students.Where(st => st.Age >= 18 && st.Age <= 24).ToList();

            foreach (var student in result)
	        {
		        Console.WriteLine("{0} {1} - {2} years", student.FirstName, student.LastName, student.Age);
	        }


        }
    }
}
