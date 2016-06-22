using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hamming_code
{
    public class Generator
    {
        private StringBuilder HCode;
        private int totalElement;
        ClassData dataObject;
        public Generator(ClassData Object)
        {
            dataObject = Object;
        }
        public void generate()
        {
            totalElement = dataObject.originalData.Length + dataObject.numberOfR;
            HCode = new StringBuilder(dataObject.originalData); //assign the originalData into the HCode
            HCode = HCode.Insert(0, " "); //insert blank space in the first position

            for (int i = 0; i < Math.Sqrt(totalElement); i++)
            {
                HCode = HCode.Insert((int)Math.Pow(2, i), "R");  //assign R in appropiate position
            }

            for (int i = 0; i < Math.Sqrt(totalElement); i++)
            {
                generator((int)Math.Pow(2, i));  //calculate the value of R
            }

            Console.Write("\nHamming code : {0}", HCode.ToString());

            Console.WriteLine("\nSending the code...");
            if (dataObject.errorPosition > 0) //if errorPosition exits then pro
            {
                HCode.Replace(HCode[dataObject.errorPosition], HCode[dataObject.errorPosition] == '0' ? '1' : '0', dataObject.errorPosition, 1);
            }
        }

        private void generator(int value)
        {
            int count = 0;
            for (int i = 1; i <= totalElement; i++)
            {
                if ((i & value) == value)  //compare 1 in binary position
                {
                    if (HCode[i] == '1')
                        count++;      //count the no of 1 in for each R
                }
            }
            if (count % 2 == 0)
                HCode.Replace('R', '0', value, 1);  // replace the value of R in proper index
            else
                HCode.Replace('R', '1', value, 1);
        }

        public void check()
        {
            int[] errorArray = new int[(int)Math.Sqrt(totalElement) + 1];
            int value = 0;
            for (int i = 0; i < Math.Sqrt(totalElement); i++)
            {
                errorArray[i] = detect((int)Math.Pow(2, i));  //calculate the no of one's
            }

            for (int i = 0; i < errorArray.Length; i++)  //convert from binary to decimal
            {
                value += errorArray[i] * (int)Math.Pow(2, i);  //the data restored in the array in the reverse order
            }

            if (value > 0)
            {
                Console.WriteLine("\nThere is an error in position: {0} => {1}", value, HCode);
                HCode.Replace(HCode[value], HCode[value] == '0' ? '1' : '0', value, 1); //correct the error
            }
            else
            {
                Console.WriteLine("\nThere is no error.");
            }
            Console.WriteLine("\nAfter correcting Hamming Code in the receiving end: {0}", HCode);

            for (int i = (int)Math.Sqrt(totalElement); i >= 0; i--)//retrive original data
            {
                HCode = HCode.Remove((int)Math.Pow(2, i), 1); //delete redundent bit from the code       
            }
            Console.WriteLine("Original data in the receiving end: {0}", HCode);
        }

        private int detect(int value)
        {
            int count = 0;
            for (int i = 1; i <= totalElement; i++)
            {
                if ((i & value) == value)  //compare 1 in binary position
                {
                    if (HCode[i] == '1')
                        count++;      //count the no of 1 in for each R
                }
            }
            if (count % 2 == 0)
                return 0;
            else
                return 1;
        }
    }
}
