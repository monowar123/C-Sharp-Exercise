using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees ={ new Employee("Monowarul","Islam",10000),
                                 new Employee("Nasir","Uddin",12000),
                                 new Employee("Shamim","Reza",8000)};
            //Console.WriteLine(employees[0]);
            Display(employees, "Original arry:");

            //LINQ query....
            var between = from e in employees where e.MonthlySalary > 8000 && e.MonthlySalary < 12000 select e;
            Display(between, "After Query:");

            // query for sorting........
            var nameSorted = from e in employees orderby e.LastName, e.FirstName select e;
            Display(nameSorted, "After Sorting by name:");
            Console.WriteLine("\nThe first element of sorted name:\n");
            if (nameSorted.Any())
                Console.WriteLine(nameSorted.First().ToString());
            else
                Console.WriteLine("No data found");

            //query for last name.....
            var lastNames = from e in employees select e.LastName;
            Display(lastNames.Distinct(), "Only last names:");   // Distinct() is used for avoid dublicacy.

            // use LINQ to select first and last names........
            var names = from e in employees select new { e.FirstName, Last = e.LastName };
            Display(names, "Select two attributes from object:");
            // when we want to select multiple attributes insted of single then we declare anoymous type
            //like above. This actually create a new object "names" and automatically copy the attribute 
            // as the attribute of "names". It also generates a ToString() method that returns a string 
            // representation of the object.
            Console.ReadKey();
        }

        public static void Display<T>(IEnumerable<T> result, string header)
        {
            Console.WriteLine();
            Console.WriteLine(header);
            foreach (T element in result)
                Console.WriteLine(element);
        }
    }
}
