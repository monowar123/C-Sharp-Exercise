using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializationBinary
{
    [Serializable]
    class Car
    {
        public string Make;
        public string Model;
 
        //if u don't want to save some of the field then use this attribute
        //[NonSerialized]
        public string Color;
        public int Year;
    }
}
