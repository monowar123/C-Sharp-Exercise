using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void sumval(ref int sum)
        {
            sum *= 2;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(num);
            sumval(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
