using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Circular_Buffer
{
    public class Consumer
    {
        private Buffer sharedLocation;
        private Random randomSleepTime;

        public Consumer(Buffer shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void consume()
        {
            int sum = 0;
            for (int count = 1; count <= 5; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3001));
                sum += sharedLocation.Buffer;
            }
            Console.WriteLine("{0} reads values totaling: {1}.\nTerminating {0}", Thread.CurrentThread.Name, sum);
        }
    }
}
