using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPDatos;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using GUI_Cliente.src;

namespace Cliente
{
    class Cliente
    {
        public static Socket master;
        public static string name;
        public static string id; 

        static void Main(String[] args)
        {
            Console.Write("Enter ypur name: ");
            name = Console.ReadLine();
               

        A:  Console.Clear();
            Console.WriteLine("Enter host IP Address: ");
            string ip = Console.ReadLine();

            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), 4242);

            try
            {
                master.Connect(ipe);
            }
            catch
            {
                Console.WriteLine("Couldn´t connect to host!");
                Thread.Sleep(1000);
                goto A;
            }

            Thread t = new Thread(dataIN);
            t.Start();

            for(; ; )
            {
                Console.Write("::>");
                string input = Console.ReadLine();

                Packets p = new Packets(PacketType.Chat, ip);
                p.genData.Add(name);
                p.genData.Add(input);
                master.Send(p.toBytes());
                Console.Write("sended");
            }

        }

        static void dataIN()
        {
            byte[] buffer;
            int readBytes;

            for(; ; )
            {
                try
                {
                    buffer = new byte[master.SendBufferSize];
                    readBytes = master.Receive(buffer);

                    if (readBytes > 0)
                    {
                        dataManager(new Packets(buffer));
                    }

                }
                catch(SocketException ex)
                {
                    Console.WriteLine("The server has disconnected");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                

            }

        }

        static void dataManager(Packets p)
        {
            switch (p.packetType)
            {
                case PacketType.Registration:
                    id = p.genData[0];
                    break;
                case PacketType.Chat:
                    Console.WriteLine("=> " + p.genData[0] + ": " + p.genData[1]);
                    break;

            }
        }

    }
}
