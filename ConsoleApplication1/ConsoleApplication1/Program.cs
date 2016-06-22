using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass* baseObject = new *BaseClass();
            //BaseClass2 base2Object = new BaseClass2();
            //DerivedClass* derivedObject = new DerivedClass();

            //baseObject.baseFunc();
            //baseObject.common();

            //derivedObject.baseFunc();
            //derivedObject.common();
            //derivedObject.derivedFunc();

            Console.ReadKey();
        }
    }
}
