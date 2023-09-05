using Entidades.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCPDatos;

namespace LibreriaCliente
{
    internal class ComunicacionCliente
    {
        private bool stopThreads;
        private Socket master;
        private bool clienteAceptado;
        private Driver _conductor = new Driver();
        Cliente cliente;

        public ComunicacionCliente(Cliente _cliente)
        {
            this.cliente = _cliente;
            this.master = cliente.Master;
            this.clienteAceptado = false;
            this._conductor = new Driver();
        }

        public bool StopThreads { get => stopThreads; set => stopThreads = value; }
        public Socket Master { get => master; set => master = value; }
        public bool ClienteAceptado { get => clienteAceptado; set => clienteAceptado = value; }
        public Driver Conductor { get => _conductor; set => _conductor = value; }


        public bool EnviarDatos(List<object> _genData, PacketType _packetType, string _senderID)
        {
            Packets p = new Packets(_packetType, _senderID);
            p.genData = _genData;
            if (Master.Send(p.toBytes()) > 0)
            {
                return true;
            }
            else
                return false;

        }

        public void DataManager(Packets p)
        {
            switch (p.packetType)
            {
                case PacketType.Registration:
                    if (p.genData.Count > 0)
                    {
                        ClienteAceptado = true;
                        Conductor = (Driver)p.genData[0];
                    }
                    else
                        ClienteAceptado = false;
                    break;
                case PacketType.Chat:
                    break;

            }
        }

    }
}
