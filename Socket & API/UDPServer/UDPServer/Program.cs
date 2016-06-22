using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            UdpClient newSock = new UdpClient(ipep);

            Console.WriteLine("Waiting for a client.........");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            data = newSock.Receive(ref sender);

            Console.WriteLine("Message received from :{0}", sender.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));

            string welcome = "Welcome to my test server.";
            data = Encoding.ASCII.GetBytes(welcome);
            newSock.Send(data, data.Length, sender);

            while (true)
            {
                data = newSock.Receive(ref sender);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
                newSock.Send(data, data.Length, sender);
            }
        }
    }
}
