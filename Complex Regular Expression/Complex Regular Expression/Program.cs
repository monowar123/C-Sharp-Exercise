using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Complex_Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sub-string that contains name with first letter J and birthday does not
            // in april with regular expression.
            string testString =
                "Jane's Birthday is 05-12-75\n" +
                "Dave's Birthday is 11-04-68\n" +
                "John's Birthday is 04-28-73\n" +
                "Joe's Birthday is 12-17-77\n";
            Regex expression=new Regex(@"J.*\d[\d-[4]]-\d\d-\d\d");

            foreach (var myMatch in expression.Matches(testString))
                Console.WriteLine(myMatch);
            Console.ReadKey();
        }
    }
}
