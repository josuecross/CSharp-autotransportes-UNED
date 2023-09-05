using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPDatos;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace Servidor
{   
    class Servidor
    {
            


        static Socket listenerSocket;
        static List<ClientData> clients;
        static void Main(String[] args)
        {

            Console.WriteLine("Starting server at ip " + Packets.getIPAddress());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clients = new List<ClientData>();

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packets.getIPAddress()), 4242);

            listenerSocket.Bind(ip);

            Thread listeningThread = new Thread(listenThread);
            listeningThread.Start();
        }

        static void listenThread()
        {

            for(; ; )
            {
                listenerSocket.Listen(0);
                clients.Add(new ClientData(listenerSocket.Accept()));

            }
   
        }

        public static void dataIN(Object cSocket)
        {
            Socket clientSocket = (Socket)cSocket;

            byte[] buffer;
            int readBytes;

            for(; ; )
            {

                try
                {
                    buffer = new byte[clientSocket.SendBufferSize];
                    readBytes = clientSocket.Receive(buffer);
                    if (readBytes > 0)
                    {
                        //Whatever I want here
                        Packets packet = new Packets(buffer);
                        dataManager(packet);
                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("A client disconnected ");
                    Console.ReadLine();
                    Environment.Exit(0);

                }


            }

        } 
        public static void dataManager(Packets p)
        {
            switch (p.packetType)
            {
                case PacketType.Chat:
                    foreach(ClientData c in clients)
                    {
                        c.clientSocket.Send(p.toBytes());

                    }
                    break;

            }
        }
    }
    class ClientData
    {
        public Socket clientSocket;
        public Thread clientThreat;
        public string id;

        public ClientData()
        {
            this.id = Guid.NewGuid().ToString();
            clientThreat = new Thread(Servidor.dataIN);
            clientThreat.Start(clientSocket);
            sendRegistrationPacket();
        }
        public ClientData(Socket _clientSocket)
        {
            this.clientSocket = _clientSocket;
            this.id = Guid.NewGuid().ToString();
            clientThreat = new Thread(Servidor.dataIN);
            clientThreat.Start(clientSocket);
            sendRegistrationPacket();

        }
        public void sendRegistrationPacket()
        {
            Packets p = new Packets(PacketType.Registration, "server");
            p.genData.Add(id);
            clientSocket.Send(p.toBytes());
        }

    }
}
