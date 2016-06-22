using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class Program
    {
        // A delegate is a function that holds a reference of a method. The real power of delegates is the ability to pass a 
        // method reference as an argument to another method..........like (FilterArray)
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            NumberPredicate evenPredicate = IsEven;
            Console.WriteLine("Call IsEven using a delegate variable: {0}", evenPredicate(4));

            List<int> evenNumbers = FilterArray(numbers, evenPredicate);
            DisplayList("Use IsEven to filter even numbers: ", evenNumbers);

            List<int> oddNumbers = FilterArray(numbers, IsOdd);
            DisplayList("Use IsOdd to filter odd numbers: ", oddNumbers);

            List<int> numberOver5 = FilterArray(numbers, IsOver5);
            DisplayList("Use IsOver5 to filter numbers over 5: ", numberOver5);
            Console.ReadKey();
        }
        private static List<int> FilterArray(int[] array, NumberPredicate predicate)
        {
            List<int> result = new List<int>();
            foreach (int item in array)
                if (predicate(item))
                    result.Add(item);
            return result;
        }
        private static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }
        private static bool IsOdd(int number)
        {
            return (number % 2 == 1);
        }
        private static bool IsOver5(int number)
        {
            return (number > 5);
        }
        private static void DisplayList(string message, List<int> list)
        {
            Console.Write(message);
            foreach (int item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }
    }
}
