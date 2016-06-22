using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string mm = "Hello";

            int workerThread;
            int completionPortThread;

            ThreadPool.GetMaxThreads(out workerThread, out completionPortThread);
            Console.WriteLine("Worker thread: {0}, I/O complession thread: {1}", workerThread, completionPortThread);

            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(jobForAThread);
                //ThreadPool.QueueUserWorkItem(ThreadMain);
            }
            
                //Thread t1 = new Thread(jobForAThread);
                //t1.Name = "MyThread";
                //t1.Start();
                //t1.Priority = ThreadPriority.Lowest;
                //t1.IsBackground = true;

         
                Console.ReadKey();
        }

        static void ThreadMain(object message)
        {
            Console.WriteLine("Inside the thread, line 1.");
            Console.WriteLine("Inside the thread, line 2.");
            //Thread.Sleep(3000);
            Console.WriteLine("Thread name : {0},  Thread id : {1}", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Get the message: {0}", (string)message);
        }

        static void jobForAThread(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Loop {0}, running inside pooled thread {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(50);
            }
        }
    }
}
