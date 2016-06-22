using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hamming_code
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassData dataObject = new ClassData();
            dataObject.CollectData();

            Generator gObject = new Generator(dataObject);
            gObject.generate();
            gObject.check();
            
            Console.ReadKey();
        }

        
    }
}
