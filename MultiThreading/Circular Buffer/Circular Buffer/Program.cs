using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Circular_Buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularBuffer shared = new CircularBuffer();
            Random random = new Random();

            Console.Write(shared.CreateStateOutput());

            Producer producer = new Producer(shared, random);
            Consumer consumer = new Consumer(shared, random);

            Thread producerThread = new Thread(new ThreadStart(producer.produce));
            producerThread.Name = "Producer";
            Thread consumerThread = new Thread(new ThreadStart(consumer.consume));
            consumerThread.Name = "Consumer";

            producerThread.Start();
            consumerThread.Start();

            Console.ReadKey();
        }
    }
}
