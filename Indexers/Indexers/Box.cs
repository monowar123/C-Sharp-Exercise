using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    public class Box
    {
        private string[] names = { "length", "width", "height" };
        private double[] dimensions = new double[3];
        public Box(double length, double width, double hight)
        {
            dimensions[0] = length;
            dimensions[1] = width;
            dimensions[2] = hight;
        }
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= dimensions.Length)
                    return -1;
                else
                    return dimensions[index];
            }
            set
            {
                if (index >= 0 && index < dimensions.Length)
                    dimensions[index] = value;
            }
        }
        public double this[string name]
        {
            get
            {
                int i = 0;
                while (i < names.Length && name.ToLower() != names[i])
                    i++;
                return (i == names.Length) ? -1 : dimensions[i];
            }
            set
            {
                int i = 0;
                while (i < names.Length && name.ToLower() != names[i])
                    i++;
                if (i != names.Length)
                    dimensions[i] = value;
            }
        }
    }
}
