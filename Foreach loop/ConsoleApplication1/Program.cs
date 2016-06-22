#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace ConsoleApplication1
{    
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("\tHello world.........");
            const int var = 5;
            int[] arr = new int[var] {1,2,3,4,5};
            int[] myIntArray = {5, 9, 10, 2, 99};
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(" {0} {1} ", arr[i], myIntArray[i]);
            }
            Console.WriteLine("\tHello world.........");
            string[] friend ={"Monowar","Nasir","Raju"};
            Console.WriteLine("Array size={0}",friend.Length);
            for (i = 0; i < friend.Length; i++)
            {
                Console.WriteLine(friend[i]);
            }
            foreach (string name in friend)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}