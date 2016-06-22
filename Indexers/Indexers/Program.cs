using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(30, 30, 30);
            Console.WriteLine("Created a box with the dimensions:");
            Console.WriteLine("box[0]={0}", box[0]);
            Console.WriteLine("box[1]={0}", box[1]);
            Console.WriteLine("box[2]={0}", box[2]);

            box[0] = 10;
            box["width"] = 20;

            Console.WriteLine("\nNow the box has the dimensions:");
            Console.WriteLine("box[\"length\"]={0}", box["length"]);
            Console.WriteLine("box[\"width\"]={0}", box["width"]);
            Console.WriteLine("box[\"height\"]={0}", box["height"]);

            Console.ReadKey();
        }
    }
}
