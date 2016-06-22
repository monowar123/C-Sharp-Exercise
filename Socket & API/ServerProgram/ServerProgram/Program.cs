using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            string input;
            string user = "Server->";

            TcpListener newSocket = new TcpListener(9050);
            newSocket.Start();
            Console.WriteLine("Waiting for a client........");

            TcpClient client = newSocket.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            string welcome = "Welcome to test server.";

            data = Encoding.ASCII.GetBytes(welcome);
            ns.Write(data, 0, data.Length);

            //sw.WriteLine(welcome);

            while (true)
            {
                data = new byte[1024];
                recv = ns.Read(data, 0, data.Length);
                if (recv == 0)
                    break;
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
                ns.Write(data, 0, recv);

                //Console.WriteLine(sr.ReadLine());
            }
            ns.Close();
            client.Close();
            newSocket.Stop();

            Console.ReadKey();
        }
    }
}
