using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Class
{
    class personIndexer
    {
        public person[] individuals = new person[4];

        public person this[int i]
        {
            get
            {
                return individuals[i];
            }
            set
            {
                individuals[i] = value;
            }
        }

        public void Resize()
        {
            Array.Resize<person>(ref individuals, 6);
        }
    }
}
