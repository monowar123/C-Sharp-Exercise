using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            string input;                               // var1=var2+var3;
            string substring;
            int length = 0, startIndex = 0;

            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/' || input[i] == '=' || input[i] == ';')
                {
                    substring = input.Substring(startIndex, length);
                    substring = substring.Trim();
                    myList.Add(substring);
                    myList.Add(input[i].ToString());
                    startIndex = i + 1;
                    length = -1;
                }
                length++;
            }

            foreach (string item in myList)
            {                
                if (item == "")
                {
                }
                else if (item == "+" || item == "-" || item == "*" || item == "/" || item == "=")
                {
                    Console.WriteLine("{0} is an operator.", item);
                }
                else if (char.IsDigit(item[0]))
                {
                    int flag = 1;
                    for (int i = 1; i < item.Length; i++)
                    {
                        if (char.IsDigit(item[i]))
                        {
                            flag++;
                        }
                    }
                    if (flag == item.Length - 1)
                    {
                        Console.WriteLine("{0} is an Number.", item);
                    }
                    else
                    {
                        Console.WriteLine("{0} invalid token.", item);
                    }
                }
                else if (item[0] == '_' || char.IsLetter(item[0]))
                {
                    int flag = 1;
                    for (int i = 1; i < item.Length; i++)
                    {
                        if (char.IsLetterOrDigit(item[i]))
                        {
                            flag++;
                        }
                    }
                    if (flag == item.Length)
                    {
                        Console.WriteLine("{0} is an Identifier.", item);
                    }
                    else
                    {
                        Console.WriteLine("{0} invalid token.", item);
                    }
                }
                else
                {
                    Console.WriteLine("{0} invalid token.", item);
                }
            }
            Console.ReadKey();
        }
    }
}
