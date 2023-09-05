using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace LibreriaServidor
{
    public class ClientData
    {

        private Socket clientSocket;
        private Thread clientThreat;
        private string id;


        //Cada ves que se crea un nuevo cliente en el servidor se le asocian sus datos y un thread individual para escuchar datos de entrada
        public ClientData()
        {
            this.id = Guid.NewGuid().ToString();
            clientThreat = new Thread(Servidor.dataIN);
            clientThreat.Start(ClientSocket);
            //sendRegistrationPacket();
        }
        public ClientData(Socket _clientSocket)
        {
            this.ClientSocket = _clientSocket;
            this.id = Guid.NewGuid().ToString();
            clientThreat = new Thread(Servidor.dataIN);
            clientThreat.Start(ClientSocket);
            Servidor.bitacoraServer = ("Cliente esperando autentificacion - ID Temporal" + Id + "\n");
            //sendRegistrationPacket();

        }

        public string Id { get => id; set => id = value; }
        public Socket ClientSocket { get => clientSocket; set => clientSocket = value; }

        /*
        public void sendRegistrationPacket()
        {
            Packets p = new Packets(PacketType.Registration, "server");
            p.genData.Add(Id);
            ClientSocket.Send(p.toBytes());
        }*/

    }
}
