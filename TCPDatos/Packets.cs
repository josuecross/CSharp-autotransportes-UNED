using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace TCPDatos
{
    [Serializable]
    public class Packets
    {

        public List<object> genData; //Los datos que se envian
        public int packetInt; 
        public bool packetBool;
        public string idPaquete; // Cada paquete cuenta con su id
        public string senderID; // El id del que envia los datos
        public PacketType packetType; // Tipo de paquete
        public PacketType dataType; // tipo de dato que se lleva en genData, ya que es una lista de objetos


        //Constructor para envio
        public Packets(PacketType type, string senderID)
        {
            genData = new List<object>();
            this.senderID = senderID;
            packetType = type;
        }

        //Constructor para recibo de datos, convierte un buffer de bytes en un paquete
        public Packets(byte[] packetBytes)
        {
            //Clases que serviran para convertir bytes en objetos
            BinaryFormatter bf = new BinaryFormatter(); 
            MemoryStream ms = new MemoryStream(packetBytes);

            //Crea una instancia del paquete recibido en bytes gracias al stream de memoria
            Packets p = (Packets)bf.Deserialize(ms);
            ms.Close();

            this.genData = p.genData;
            this.idPaquete = p.idPaquete;
            this.senderID = p.senderID;
            this.packetType = p.packetType;
            this.dataType = p.dataType;
        }

        public Packets(PacketType packetType)
        {
            this.packetType = packetType;
        }

        //Convierte objetos en un stream de bytes para ser enviado por la red
        public byte[] toBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            // Se convierte la memoria ms en bytes y se pasa a un array de bytes para retornarlo
            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Close();
            return bytes;

        }

        public static string getIPAddress()
        {
            /*
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress i in ips)
            {
                if(i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return i.ToString();
            }
            */
            return "127.0.0.1";

        }
    }

    //Enum con el tipo de datos que manejan los paquetas
    public enum PacketType
    {
        Registration,
        Chat,
        Rutas,
        Roles,
        Terminales,
        Autobus,
        Consulta,
        Conductor,
        Desconexion,
        CargarRol
    }
}
