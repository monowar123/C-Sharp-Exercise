using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Circular_Buffer
{
    public class CircularBuffer : Buffer
    {
        private int[] buffer = { -1, -1, -1 };
        private int occupiedBufferCount = 0;
        private int readLocation = 0;
        private int writeLocation = 0;

        public int Buffer
        {
            get
            {
                lock (this)
                {
                    if (occupiedBufferCount == 0)
                    {
                        Console.WriteLine("All buffers empty. {0} waits.", Thread.CurrentThread.Name);
                        Monitor.Wait(this);
                    }
                }
                int readValue = buffer[readLocation];
                Console.WriteLine("{0} reads {1}", Thread.CurrentThread.Name, buffer[readLocation]);
                --occupiedBufferCount;
                readLocation = (readLocation + 1) % buffer.Length;
                Console.Write(CreateStateOutput());
                Monitor.Pulse(this);
                return readValue;
            }

            set
            {
                lock (this)
                {
                    if (occupiedBufferCount == buffer.Length)
                    {
                        Console.WriteLine("All buffers full. {0} waits.", Thread.CurrentThread.Name);
                    }
                    Monitor.Wait(this);
                    buffer[writeLocation] = value;
                    Console.WriteLine("{0} writes {1}", Thread.CurrentThread.Name, buffer[writeLocation]);
                    ++occupiedBufferCount;
                    writeLocation = (writeLocation + 1) % buffer.Length;
                    Console.Write(CreateStateOutput());
                    Monitor.Pulse(this);
                }
            }
        }

        public string CreateStateOutput()
        {
            string output = "(buffers occupied: " + occupiedBufferCount + ")\nbuffers: ";
            for (int i = 0; i < buffer.Length; i++)
            {
                output += " " + string.Format("{0,2}", buffer[i]) + " ";
            }
            output += "\n";
            output += "                ";
            for (int i = 0; i < buffer.Length; i++)
            {
                output += "                ";
            }
            output += "\n";
            output += "                ";
            for (int i = 0; i < buffer.Length; i++)
            {
                if (i == writeLocation && writeLocation == readLocation)
                    output += " WR ";
                else if (i == writeLocation)
                    output += " W ";
                else if (i == readLocation)
                    output += " R ";
                else
                    output += "            ";
            }
            return output;
        }
    }
}
