using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Hamming_code
{
    public class ClassData
    {
        private string OriginalData;
        private int NumberOfR;
        private int ErrorPosition;

        public string originalData
        {
            get
            {
                return OriginalData;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] != '0' && value[i] != '1')
                    {
                        throw new Exception("Original Data only contains 0 or 1.");
                    }
                }
                if (value.Length != 0)
                    OriginalData = value;
                else
                    throw new Exception("Original data must not be empty.");
            }
        }

        public int numberOfR
        {
            get
            {
                return NumberOfR;
            }
            private set
            {
                NumberOfR = value;
            }
        }

        public int errorPosition
        {
            get
            {
                return ErrorPosition;
            }
            set
            {
                if ((value <= originalData.Length + numberOfR) && (value >= 0))
                    ErrorPosition = value;
                else
                    throw new Exception("Error position is out of range.");
            }
        }

        public void CollectData()
        {
            label1:   //original data
            try
            {
                Console.WriteLine("\nEnter original data:");
                originalData = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto label1;
            }

            int r = 0;   // number of R
            while (true)
            {
                r++;
                if (Math.Pow(2, r) >= (originalData.Length + r + 1))
                    break;
            }
            numberOfR = r;

            label2:    //error position
            try
            {
                Console.WriteLine("\nEnter error position, Otherwise enter zero:");
                errorPosition = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto label2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto label2;
            }       
        }
    }
}
