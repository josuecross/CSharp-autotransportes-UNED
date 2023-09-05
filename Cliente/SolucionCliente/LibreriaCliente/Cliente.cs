using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Entidades.src;
using TCPDatos;



/// <summary>
/// Codugo adaptado de https://www.youtube.com/watch?v=X66hFZG5p3A
/// Implementa la clase cliente para conectarse a un servidor, puede enviar y recibir paquetes a travez del protocolo TCP a un servidor
/// </summary>
namespace LibreriaCliente
{
    public class Cliente
    {
        private bool stopThreads; //Mantiene ejecutandose los ciclos que deben escuchar al server
        private Socket master; // Implementa el socket que utilizara el cliente para conectarse al servidor
        private string id; // Id del cliente - sera igual a la identificacion del conductor una vez iniciada sesion
        private bool clienteAceptado; // Pasa a true cuando el cliente ha sido logeado por el servidor
        private Driver _conductor; // Contiene la informacion del conductor conectado como cliente
        private ComunicacionCliente comunicacionCliente; // Se utiliza para manejar la comunicacion con el cliente
        private List<Packets> packetResponse; // Guarda los paquetes que recibe el cliente en respuesta a sus solicitudes


        //Getters y Setters
        public bool StopThreads { get => stopThreads; set => stopThreads = value; }
        public Socket Master { get => master; set => master = value; }
        public string Id { get => id; set => id = value; }
        public bool ClienteAceptado { get => clienteAceptado; set => clienteAceptado = value; }
        public Driver Conductor { get => _conductor; set => _conductor = value; }
        internal ComunicacionCliente ComunicacionCliente { get => comunicacionCliente; set => comunicacionCliente = value; }

        //Constructor
        public Cliente()
        {
            this.stopThreads = false;
            this.clienteAceptado = false;
            this._conductor = new Driver();
            this.comunicacionCliente = new ComunicacionCliente(this);
            this.packetResponse = new List<Packets>();
        }


        //Pone en funcionamiento el socket para que el cliente pueda conectarse y escuchar al servidor
        public void iniciarCliente()
        {

        A:  string ip = "127.0.0.1"; // ip que utilizara el socket

            // Instancia del socket a utilizar, configurado para usar ipv4, enviar stram de datos, y protocolo TCP
            Master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  

            // Instancia de la ip a la que se conectara el socket
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), 4242);

            try
            {
                //Establece la conexion con la ip especificada
                Master.Connect(ipe);
            }
            catch
            {
                //Si no se logra conectar al host especificado lo reintenta cada segundo
                Thread.Sleep(1000);
                goto A;
            }

            // Inicia un thread que queda escuchando al host conectado
            Thread t = new Thread(DataIN);
            t.Start();
        }


        // Usado para enviar datos al servidor sin esperar respuesta en forma de una lista de objetos, _packetType especifica el tipo de dato enviado, y senderID el id del cliente que lo envia
        public string EnviarDatos(List<object> _genData, PacketType _packetType, string _senderID)
        {
            try
            {
                Packets p = new Packets(_packetType, _senderID); // Instancia del paquete que se enviara
                p.genData = _genData; // datos que se enviaran
                if (Master.Send(p.toBytes()) > 0) { // intenta enviar el paquete, retorna un string con el resultado para tomar acciones correspondientes
                    return "ok";
                }
                else
                    return "NO";
            }
            catch (SocketException)
            {
                return "socket";
            }
            catch (NullReferenceException)
            {
                return "null";
            }

        }

        // Envia consultas al servidor en este caso, las consultas deben obtener una respuesta con datos.
        // La consulta en este caso se envia como un string con las clausulas que se deseen
        // y el tipo de consulta especifica por que dato preguntar al servidor
        // Se retorna una lista de objetos, si es exitosa contiene los objetos consultados,
        // sino un unico objeto string con la informacion de lo que sucedio
        public List<object> RealizarConsulta(List<object> stringConsulta, string _senderID, PacketType tipoConsulta)
        {
            // Lista que guarda la respuesta del servidor una vez ejecutada la consulta
            List<object> listResponse = new List<object>();

            try
            {
                string mensaje; //Mensaje para manejo de errores
                int intentos = 0; //se espera una respuesta dentro de 10 intentos, separados por un intervalo de tiempo
                Packets p = new Packets(PacketType.Consulta, _senderID); // instancia del paquete a enviar

                p.genData = stringConsulta; // asigna los datos a enviar al paquete

                // asigna un id al paquete para reconocer luega la respuesta, ya que llegara con el mismo id
                p.idPaquete = Guid.NewGuid().ToString(); 

                p.dataType = tipoConsulta; // Tipo de dato por el que se esta consultando

                if (Master.Send(p.toBytes()) > 0) // Intenta enviar los datos dependiendo de si es exitoso o no se hace un manejo adecuado
                {
                    mensaje = "ok";
                }
                else
                {
                    listResponse.Add("ne");
                    return listResponse;
                }

                if (mensaje.Equals("ok")) // si se logro enviar la consulta se espera un respuesta
                {
                    while (intentos < 20) //intenta 20 veces ver si se recibio la respuesta
                    {
                        intentos++;
                        foreach(Packets packet in packetResponse)
                        {
                            //Por medio del id se verifica que se haya recibido un paquete en packetResponse con el mismo id enviado, esa sera la respuesta del servidor
                            if (packet.genData.Count > 0 && packet.idPaquete == p.idPaquete) 
                            {
                                listResponse = packet.genData;
                                listResponse.Add(mensaje);
                                return listResponse; // se retorna la lista de objetos enviada por el servidor como respuesta a la consulta
                            }

                        }
                        
                        Thread.Sleep(100); // reintenta cada lapso de tiempo
                    }
                }

                
            }
            catch (SocketException)
            {
                listResponse.Add("es");
                return listResponse;
            }
            catch (NullReferenceException)
            {
                listResponse.Add("nr");
                return listResponse;
            }
            return listResponse;

        }

        public List<object> RealizarQuerry(List<object> stringQuerry, string _senderID, PacketType modo, PacketType tipoDato)
        {
            List<object> listResponse = new List<object>();
            try
            {
                string mensaje; //Mensaje para manejo de errores
                int intentos = 0; //se espera una respuesta dentro de 10 intentos
                Packets p = new Packets(modo, _senderID);

                p.genData = stringQuerry;

                p.idPaquete = Guid.NewGuid().ToString();

                p.dataType = tipoDato;

                if (Master.Send(p.toBytes()) > 0)
                {
                    mensaje = "Exito";
                }
                else
                {
                    listResponse.Add("No enviado");
                    return listResponse;
                }

                if (mensaje.Equals("Exito"))
                {

                    //Trata de encontrar el paquete de respuesta del servidor en 20 intentos
                    while (intentos < 20)
                    {
                        intentos++;
                        foreach (Packets packet in packetResponse)
                        {
                            if (packet.genData.Count > 0 && packet.idPaquete == p.idPaquete)
                            {
                                listResponse = packet.genData;
                                listResponse.Add(mensaje);
                                packetResponse.Remove(packet); //elimina el paquete para liberar espacio en memoria
                                return listResponse;
                            }

                        }

                        Thread.Sleep(100);
                    }
                }


            }
            catch (SocketException)
            {
                listResponse.Add("SocketException");
                return listResponse;
            }
            catch (NullReferenceException)
            {
                listResponse.Add("NullReferenceException");
                return listResponse;
            }
            listResponse.Add("Sin respuesta");
            return listResponse;

        }


        public string EnviarDirectiva(List<object> _genData, PacketType _packetType, string _senderID)
        {
            try
            {
                Packets p = new Packets(_packetType, _senderID);
                p.genData = _genData;
                if (Master.Send(p.toBytes()) > 0)
                {
                    return "Exito";
                }
                else
                    return "No enviado";
            }
            catch (SocketException)
            {
                return "SocketException";
            }
            catch (NullReferenceException)
            {
                return "NullReferenceException";
            }

        }

        //Antes de disponer del objeto se cierra la conexion y se terminan los threads sin forzarlos
        public bool DetenerCliente()
        {
            
            try
            {
                StopThreads = true;
                Master.Disconnect(false);
                Master.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        //Mantiene activo la escucha de datos mientras se ejecuta la aplicacion
        private void DataIN()
        {
            byte[] buffer; //Array con el stream de bits que se reciben del servidor
            int readBytes; // cantidad de bytes leidos por el socket

            while(!StopThreads)
            {
                try
                {
                    buffer = new byte[Master.SendBufferSize]; // inicia el array con la cantidad del socket

                    // el metodo Recieve recibe datos del socket en un array de tipo bytes, retorna el numero de datos leidos
                    readBytes = Master.Receive(buffer); 

                    if (readBytes > 0)
                    {
                         DataManager(new Packets(buffer)); // crea un nuevo paquete a partir del buffer recibido y lo pasa para administra el paquete recibido
                    }

                }
                catch (SocketException)
                {
                    Console.WriteLine("The server has disconnected");
                }


            }

        }

        //Administra los paquetes recibidos por el socket
        private void DataManager(Packets p)
        {
            //Toma acciones dependiendo del tipo de paquete recibido
            switch (p.packetType)
            {
                case PacketType.Registration:
                    this.packetResponse.Add(p);
                    break;
                case PacketType.Chat:
                    break;
                case PacketType.Roles:
                    this.packetResponse.Add(p);
                    break;
                case PacketType.Rutas:
                    this.packetResponse.Add(p);
                    break;
                case PacketType.Autobus:
                    this.packetResponse.Add(p);
                    break;
                case PacketType.Terminales:
                    this.packetResponse.Add(p);
                    break;
                case PacketType.Conductor:
                    this.packetResponse.Add(p);
                    break;

            }
        }

    }
}
