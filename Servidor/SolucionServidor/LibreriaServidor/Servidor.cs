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
using AccesoBD;
using Entidades.src;
using TCPDatos;

namespace LibreriaServidor
{
    public class Servidor
    {
        static Socket listenerSocket; //Socket del servidor
        public static List<ClientData> clients; //Lista de clientes conectados al servidor
        public static string bitacoraServer = " "; //String que registra los cambios en el server
        public static bool detenerThread = false; // Mientras true, el thread se mantiene ejecutando.
        public static void EjecutarServidor()
        {
            bitacoraServer = "";
            bitacoraServer = ("Iniciando server en " + Packets.getIPAddress() + "\n");
            // Configura el socket para ipv4, de tipo stream de bytes, protocolo TCP
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Inicializa la lista de clientes
            clients = new List<ClientData>();

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packets.getIPAddress()), 4242); //IP y host a utilizar como server

            listenerSocket.Bind(ip); //Asociar la ip a utlizar al socket

            Thread listeningThread = new Thread(listenThread); // Crea un nuevo thread para escuchar los clientes que se desean conectar
            listeningThread.Start();
        }

        public static void detenerServidor()
        {
            detenerThread = true;

        }

        //Escucha si un cliente se quiere conectar y lo agrega a la lista de clientes como una entidad nueva
        static void listenThread()
        {

            while (!detenerThread)
            {
                listenerSocket.Listen(0); // Coloca el socket en estado de escucha
                clients.Add(new ClientData(listenerSocket.Accept())); //Acepta el cliente si se crea una nueva conexion, creando una instancia de clientData
            }

        }

        //Escucha los datos que se reciben como bytes
        //Cada instancia de clientData ejecuta este metodo como un nuevo thread
        public static void dataIN(Object cSocket)
        {
            Socket clientSocket = (Socket)cSocket; // el objeto recibido en cSocket es instanciado como un socket

            byte[] buffer; // buffer de bytes que se recibiran en un paquete
            int readBytes; // cantidad de bytes recibidos en el paquete

            while (!detenerThread)
            {
                try
                {
                    buffer = new byte[clientSocket.SendBufferSize]; // Inicializa el array de bytes para el buffer con el tamaño de bytes que recibe del socket
                    readBytes = clientSocket.Receive(buffer);  // el metodo receive guarda los datos dentro del buffer y devuelve el numerod de datos leidos

                    if (readBytes > 0) // si se leyeron bytes
                    {
                        Packets packet = new Packets(buffer); //Instancia un paquete con el buffer recibido
                        dataManager(packet); //Llama a administrar los datos recibidos 
                    }
                }
                catch (SocketException)
                {
                    bitacoraServer = "Un cliente se ha desconectado inesperadamente";
                }
            }

        }


        //Realiza la confirmacion de un cliente a travez de su id - No utilizado
        public static bool ConfirmarCliente(List<object> _genData, string senderId, string packetID)
        {
            Packets p = new Packets(PacketType.Registration, "server");
            p.genData = _genData;
            p.idPaquete = packetID;
            foreach (ClientData client in clients)
            {
                if (client.Id == senderId)
                {
                    if (client.ClientSocket.Send(p.toBytes()) > 0)
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            return false;
        }


        //Envia datos _genData a un cliente a travez del socket al que esta conectado
        public static bool EnviarDatos(List<object> _genData, PacketType _packetType, string senderId, string packetID)
        {

            Packets p = new Packets(_packetType, "server"); //Crea uha instancia del paquete que se enviara

            p.genData = _genData; // los datos que se enviaran se pasan por medio de parametro
            p.idPaquete = packetID; // el id del paquete se pasa por parametro 

            foreach (ClientData client in clients)
            {
                if (client.Id == senderId) // Busca el id del clienteData al que se desea enviar datos
                {
                    if (client.ClientSocket.Send(p.toBytes()) > 0) // El clientData tiene el metodo de envio de datos.
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            return false;
        }

        //Administra los datos recibidos segun el tipo proporcionado por el paquete
        public static void dataManager(Packets p)
        {
            
            AccesoDatos ACdatos = new AccesoDatos();
            switch (p.packetType)
            {
                //Si el paquete es de tipo registro de cliente. El cliente obtiene un id temporal hasta que se verifica que existe en la base de datos
                case PacketType.Registration:
                    string clausulaSelect  = " Select	[NUM_CEDULA], [NOM_NOMBRE], [NOM_APELLIDO_1], [NOM_APELLIDO_2], [FEC_NACIMIENTO], [TIP_GENERO], [BIT_SUPERVISOR] ";
                    string clausulaFrom    = " From	    CONDUCTOR ";
                    string clausulaWhere   = " where NUM_CEDULA = '" + (string)p.genData[0] + "'";

                    //Crea la consulta para verificar que el cliente que es un conductor exista en la base de datos
                    List<object> _conductor = ACdatos.ObtenerDatos(clausulaSelect, clausulaFrom, clausulaWhere, tipoDato.Conductores);

                    if (_conductor.Count() > 0) //Si se obtiene el id del cliente se obtendra una cuenta de 1 en la lista _conductor
                    {
                        clients.Last().Id = p.senderID; // Al id temporal del ultimo cliente se le asigna el id del conductor para reconocerlo como aceptado
                        EnviarDatos(_conductor, PacketType.Registration, p.senderID, Guid.NewGuid().ToString()); // Se envia una respuesta de tipo registration para que la aplicacion cliente pueda logear in
                        bitacoraServer = "Acceso Concedido - ID: " + p.senderID;
                    }
                    else
                    {
                        clients.Remove(clients.Last()); //Si no se encuentra un conductor se elimina de la lista de clientes
                        bitacoraServer = "Acceso denegado (NO SE ENCONTRO CONDUCTOR) - ID: " + p.senderID;
                    }

                    break;
                case PacketType.Chat:

                    break;

                case PacketType.Rutas:
                    break;
                case PacketType.Terminales: // nabeha las consultas de tipo terminal

                    Terminal _terminal = (Terminal)p.genData[0];
                    ACdatos.AgregarTerminales(_terminal);
                    bitacoraServer = "Se agrego una terminal del cliente id" + p.senderID;
                    break;
                case PacketType.Consulta: // maneja el resto de consultas, se reciben clausula de sql en la propiedad genData del paquete y se ejecutan en la base de datos

                    string clausulaSelectC = (string)p.genData[0];
                    string clausulaFromC = (string)p.genData[1];
                    string clausulaWhereC = (string)p.genData[2];
                    bitacoraServer = "Consulta realizada a a la base de datos: " + clausulaSelectC + clausulaFromC + clausulaWhereC;
                    List<object> consulta = new List<object>() ; // Lista de objetos para guardar los datos de la consulta
                    switch (p.dataType) // Dependiendo del tipo de dato que se desee consultar se ejecuta el metodo de la base de datos
                    {
                        case PacketType.Roles:
                            consulta = ACdatos.ObtenerDatos(clausulaSelectC, clausulaFromC, clausulaWhereC, tipoDato.Roles);
                            break;
                        case PacketType.Rutas:
                            consulta = ACdatos.ObtenerDatos(clausulaSelectC, clausulaFromC, clausulaWhereC, tipoDato.Ruta);
                            break;
                        case PacketType.Autobus:
                            consulta = ACdatos.ObtenerDatos(clausulaSelectC, clausulaFromC, clausulaWhereC, tipoDato.Autobus);
                            break;
                        case PacketType.Conductor:
                            consulta = ACdatos.ObtenerDatos(clausulaSelectC, clausulaFromC, clausulaWhereC, tipoDato.Conductores);
                            break;
                        case PacketType.Terminales:
                            consulta = ACdatos.ObtenerDatos(clausulaSelectC, clausulaFromC, clausulaWhereC, tipoDato.Terminal);
                            break;
                        case PacketType.Registration:
                            consulta = ACdatos.ObtenerDatos(clausulaSelectC, clausulaFromC, clausulaWhereC, tipoDato.Conductores);

                            if (consulta.Count() > 0)
                            {
                                clients.Last().Id = p.senderID;
                                bitacoraServer = "Acceso Concedido - ID: " + p.senderID;
                            }
                            else
                            {
                                clients.Remove(clients.Last());
                                bitacoraServer = "Acceso denegado (NO SE ENCONTRO CONDUCTOR) - ID: " + p.senderID;
                            }

                            break;


                    }

                    //Se envian datos al cliente, a travez del metodo enviarDatos. El id del paquete nuevo es el mismo del id recibido para que sea reconocido como respuesta del servidor
                    
                    
                    if (EnviarDatos(consulta, p.dataType, p.senderID, p.idPaquete))
                        bitacoraServer = "Se enviaron datos al cliente";
                    else
                        bitacoraServer = "No se enviaron datos";
                    

                    break;
                case PacketType.CargarRol:
                    try
                    {
                        if (ACdatos.AgregarRol((Role)p.genData[0]))
                        {
                            if (EnviarDatos(new List<object> { "OK" }, p.dataType, p.senderID, p.idPaquete))
                            {
                                bitacoraServer = "El clienet id " + p.senderID + " registro un rol";
                            }
                            else
                            {
                                bitacoraServer = "Huvo un error al realizar la operacion del cliente" + p.senderID;
                            }
                            break;
                        }
                    }
                    catch
                    {
                        bitacoraServer = "No se pudo realizar la carga del rol";
                    }

                    break;



            }
        }
    }
}
