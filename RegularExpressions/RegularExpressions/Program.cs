using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Regular expressions are sometimes called regex or regexp.";

            Console.Write("Match 'e' in the test string: ");
            Regex expression = new Regex("e");
            Console.WriteLine(expression.Match(testString));

            Console.WriteLine();
            Console.Write("Match every 'e' in the test string : ");
            foreach (var myMatch in expression.Matches(testString))
                Console.Write("{0} ", myMatch);

            Console.WriteLine("\n");
            Console.Write("Matches 'regex' in the test string: ");
            foreach (var myMatch in Regex.Matches(testString, "regex"))
                Console.Write("{0} ", myMatch);

            Console.WriteLine("\n");
            Console.Write("Matches 'regex' or 'regexp' using an optional p: ");
            foreach (var myMatch in Regex.Matches(testString, "regexp?"))
                Console.Write("{0} ", myMatch);

            //use alternation to match either 'cat' or 'hat'
            Console.WriteLine("\n");
            expression = new Regex("(c|h)at");
            Console.WriteLine("hat cat matches {0}, but cat hat matches {1}", expression.Match("hat cat"), expression.Match("cat hat"));

            testString = "abc, DEF, 123";

            Console.WriteLine();
            Console.Write("Match any digit: ");
            Display(testString, @"\d");

            Console.Write("Match any non digit: ");
            Display(testString, @"\D");

            Console.Write("Match any word charecter: ");
            Display(testString, @"\w");

            Console.Write("Match a group of at least one word charecter: ");
            Display(testString, @"\w+");

            Console.Write("Match a group of at least one word charecter(lazy): ");
            Display(testString, @"\w+?");

            Console.Write("Match anything from a to f : ");
            Display(testString, "[a-f]");

            Console.Write("Match anything not from a to f : ");
            Display(testString, "[^a-f]");

            Console.Write("Match a group of at least one letter: ");
            Display(testString, "[a-zA-Z]+");

            Console.Write("Match a group of any characters: ");
            Display(testString, ".*");
            
            Console.ReadKey();
        }
        private static void Display(string input, string expression)
        {
            foreach (var myMatch in Regex.Matches(input, expression))
                Console.Write(myMatch);
            Console.WriteLine("\n");
        }
    }
}
