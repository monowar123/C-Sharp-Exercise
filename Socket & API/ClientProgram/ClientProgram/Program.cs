using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClientProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            string input, stringData;
            string user = "Client->";
            TcpClient server;
            try
            {
                server = new TcpClient("127.0.0.1", 9050);
            }
            catch (SocketException)
            {
                Console.WriteLine("Unable to connect to the server.");
                Console.ReadKey();
                return;
            }
            NetworkStream ns = server.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            int recv = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);

            //stringData = sr.ReadLine();
            Console.WriteLine(stringData);

            while (true)
            {
               
                input = Console.ReadLine();
                if (input == "exit")
                    break;

                ns.Write(Encoding.ASCII.GetBytes(input), 0, input.Length);
                ns.Flush();

                //sw.WriteLine(input);
                //sw.Flush();

                //data = new byte[1024];
                //recv = ns.Read(data, 0, data.Length);
                //stringData = Encoding.ASCII.GetString(data, 0, recv);
                //Console.WriteLine(stringData);
            }
            Console.WriteLine("Disconnecting from server.....");
            ns.Close();
            server.Close();

            Console.ReadKey();
        }
    }
}
