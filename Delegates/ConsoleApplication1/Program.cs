using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        delegate int prosessdelegate(int param1, int param2);
        static int addition(int param1, int param2)
        {
            return param1 + param2;
        }
        static int multiply(int param1, int param2)
        {
            return param1 * param2;
        }
        static void Main(string[] args)
        {
            prosessdelegate process;
            Console.WriteLine("Enter two number separated by a comma");
            string input = Console.ReadLine();
            int compos = input.IndexOf(',');
            int param1 = Convert.ToInt32(input.Substring(0,compos));
            int param2 = Convert.ToInt32(input.Substring(compos + 1, input.Length - compos - 1));
            Console.WriteLine("Enter a to add and m to multiply");
            input = Console.ReadLine();
            if (input == "a")
                process = new prosessdelegate(addition);         
            else
                process = new prosessdelegate(multiply);  
          
            Console.WriteLine("Result= {0}",process(param1,param2));
            Console.ReadKey();
        }
    }
}
