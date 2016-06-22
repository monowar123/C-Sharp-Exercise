using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class DerivedClass : BaseClass
    {
        public void derivedFunc()
        {
            Console.WriteLine("calling derived class function");
        }
        public void common()
        {
            Console.WriteLine("common calling from derived class");
        }
    }
}
