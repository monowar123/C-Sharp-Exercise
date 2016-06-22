using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method3();
            }
            catch (Exception exParameter)
            {
                Console.WriteLine(exParameter);
                Console.WriteLine();
                Console.WriteLine(exParameter.Message);
                Console.WriteLine();
                Console.WriteLine(exParameter.StackTrace);
                Console.WriteLine();
                Console.WriteLine(exParameter.InnerException);
            }
            Console.ReadKey();
        }
        static void Method1()
        {
            Method2();
        }
        static void Method2()
        {
            Method3();
        }
        static void Method3()
        {
            try
            {
                Convert.ToInt32("Not an integer.");
            }
            catch (FormatException exParameter)
            {
                throw new Exception("Exception occurred in Method3()", exParameter);
            }
        }
    }
}
