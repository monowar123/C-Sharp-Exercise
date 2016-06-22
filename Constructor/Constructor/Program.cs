using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birth = new Date(1, 1, 1992);
            Date hire = new Date(1, 26, 2012);
            Employee employee = new Employee("Monowarul", "Islam", birth, hire);
            Console.WriteLine(employee);
            Console.ReadKey();
        }
    }
}
