using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 1 ,12,12,2,12};
            int[] index_array;
            int count=0;
            int maxvalue = func(array, out index_array, ref count);
            Console.WriteLine("The maximum value of the array is {0}", maxvalue);
            Console.WriteLine("The maximum value exit(s) {0} time(s)", count);
            Console.WriteLine("Their index_array number is:");            
            foreach (int ind in index_array)
            {
                Console.WriteLine(ind);
            }
            Console.ReadKey();
        }
        static int func(int[] array, out int[] index_array, ref int count)
        {
            int i, j=0;
            index_array = new int[array.Length];
            int maxvalue = array[0];
            for (i = 1; i < array.Length; i++)
            {
                if (maxvalue < array[i])
                {
                    maxvalue = array[i];
                }                
            }
            for (i = 0; i < array.Length; i++)
            {
                if (maxvalue == array[i])
                {           
                    index_array[j] = i;
                    count++;
                    j++;
                }
            }
            return maxvalue;
        }
    }
}
