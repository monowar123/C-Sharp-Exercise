using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_Synchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnsynchronizedBuffer shared = new UnsynchronizedBuffer();
            SynchronizedBuffer shared = new SynchronizedBuffer();
            Random random = new Random();

            Console.WriteLine("{0,-35}{1,-9}{2}\n", "Operation", "Bufer", "Occupied Count"); //only for synchronized buffer
            shared.DisplayState("Initial State");   //only for synchronized buffer

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
