using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Circular_Buffer
{
    public class Producer
    {
        private Buffer sharedLocation;
        private Random randomSleepTime;

        public Producer(Buffer shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void produce()
        {
            for (int count = 1; count <= 5; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3001));
                sharedLocation.Buffer = count;
            }
            Console.WriteLine("{0} done producing.\nTerminating {0}", Thread.CurrentThread.Name);
        }
    }
}
