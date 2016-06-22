using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_example
{
    public class Employee
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        private decimal monthlySalaryValue;
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalaryValue;
            }
            set
            {
                if (value >= 0M)
                    monthlySalaryValue = value;
            }
        }
        public Employee(string first, string last, decimal salary)
        {
            FirstName = first;
            LastName = last;
            MonthlySalary = salary;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10:C}", FirstName, LastName, MonthlySalary);
        }
    }
}
