using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private Date birthDate;
        private Date hireDate;
        public Employee(string first, string last, Date birth, Date hire)
        {
            firstName = first;
            lastName = last;
            birthDate = birth;
            hireDate = hire;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} Hired:{2}, Birthday:{3}", firstName, lastName, hireDate, birthDate);
        }
    }
}
