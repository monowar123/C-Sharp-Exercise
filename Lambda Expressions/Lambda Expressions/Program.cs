using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Expressions
{
    class Program
    {
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            NumberPredicate evenPredicate = number => (number % 2 == 0);  // lambda expressions
            List<int> evenNumbers = FilterArray(numbers, evenPredicate);
            Display("Even Numbers: ", evenNumbers);

            List<int> oddNumbers = FilterArray(numbers, (int number) => (number % 2 == 1));  // lambda expression
            Display("Odd Numbers: ", oddNumbers);

            List<int> numberOver5 = FilterArray(numbers, number => (number > 5));   //Lambda_Expressions
            Display("Numbers over 5: ", numberOver5);
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
        private static void Display(string message, List<int> list)
        {
            Console.Write(message);
            foreach (int item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }
    }
}
