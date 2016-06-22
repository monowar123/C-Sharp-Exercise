using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLibrary
{
    public class Record
    {
        public int Account
        {
            get;
            set;
        }
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
        public decimal Balance
        {
            get;
            set;
        }
        //parameterless constructor sets members to default values
        public Record()
            : this(0, string.Empty, string.Empty, 0M)
        {
        }
        public Record(int accountValue,string firstNameValue,string lastNameValue,decimal balanceValue)
        {
            Account=accountValue;
            FirstName=firstNameValue;
            LastName=lastNameValue;
            Balance=balanceValue;
        }
    }
}
