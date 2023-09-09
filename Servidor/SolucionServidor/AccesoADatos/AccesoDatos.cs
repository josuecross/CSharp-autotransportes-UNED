using Entidades.src;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace AccesoBD
{
    public enum tipoDato //Categoria de datos que se manejan en la base de datos
    {
        Conductores,
        Roles,
        Autobus,
        Ruta,
        Terminal
    }

    public class AccesoDatos //Clase para el acceso a los datos en la basd de datos
    {
        private string cadenaConexion; // Se le asigna la cadena que configura el establecer la conxion a la base de datos

        public AccesoDatos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        //Registra Terminales en la base de datos
        public bool AgregarTerminales(Terminal pTerminal)
        {
            bool resultado = false;
            SqlConnection connection = new SqlConnection(cadenaConexion); ;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "   INSERT INTO TERMINAL ([COD_TERMINAL], [NOM_TERMINAL],[DIR_TERMINAL],[NUM_TELEFONO],[TIM_HORA_APERTURA],[TIM_HORA_CIERRE],[BOL_ESTADO]) " +
                        "   VALUES (@idTerminal, @nombreTerminal, @direccion, @telefono, @horaApertura, @horaCierre, @estado) ";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;

            comando.Parameters.AddWithValue("@idTerminal", (Decimal)pTerminal.IdTerminal);
            comando.Parameters.AddWithValue("@nombreTerminal", pTerminal.TerminalName);
            comando.Parameters.AddWithValue("@direccion", pTerminal.TerminalAddress);
            comando.Parameters.AddWithValue("@telefono", pTerminal.TerminalPhone.ToString());
            comando.Parameters.AddWithValue("@horaApertura", pTerminal.OpenHour);
            comando.Parameters.AddWithValue("@horaCierre", pTerminal.CloseHour);
            comando.Parameters.AddWithValue("@estado", pTerminal.State ? 1 : 0);

            connection.Open();
            try
            {
                if (comando.ExecuteNonQuery() > 0) resultado = true;
            }
            catch
            {
                //Se crea una ventana indicando el error
            }

            connection.Close();

            return resultado;
        }

        public List<Terminal> ObtenerTerminales()
        {

            List<Terminal> terminales = new List<Terminal>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	[COD_TERMINAL], [NOM_TERMINAL],[DIR_TERMINAL],[NUM_TELEFONO],[TIM_HORA_APERTURA],[TIM_HORA_CIERRE],[BOL_ESTADO] " +
                        " From	    TERMINAL";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    terminales.Add(new Terminal
                    {
                        IdTerminal = (int)reader.GetSqlDecimal(0),
                        TerminalName = reader.GetString(1),
                        TerminalAddress = reader.GetString(2),
                        TerminalPhone = int.Parse((string)reader.GetSqlString(3)),
                        OpenHour = DateTime.Parse(reader.GetTimeSpan(4).ToString()),
                        CloseHour = DateTime.Parse(reader.GetTimeSpan(5).ToString()),
                        State = reader.GetBoolean(6)
                    }); ;
                }
            }

            conexion.Close();

            return terminales;
        }


        //Metodo para realizar consultas a la base de datos
        public List<Object> ObtenerDatos(string clausulaSelect, string clausulaFrom, string clausulaWhere, tipoDato _tipoDato)
        {
            List<object> objetos = new List<object>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);

            sentencia = clausulaSelect +
                        clausulaFrom +
                        clausulaWhere;

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();


            switch (_tipoDato)
            {
                case tipoDato.Conductores:
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            objetos.Add(new Driver
                            {
                                Id = reader.GetString(0),
                                Name = reader.GetString(1),
                                Surname = reader.GetString(2),
                                SecondSurname = reader.GetString(3),
                                BirthDate = reader.GetDateTime(4),
                                Gender = reader.GetString(5)[0],
                                DriverSupervisor = reader.GetBoolean(6)
                            });
                        }
                    }
                    break;

                case tipoDato.Roles:
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateTime fecha1 = reader.GetDateTime(0);
                            DateTime fecha2 = DateTime.Parse(reader.GetTimeSpan(1).ToString());

                            List<object> temporal = ObtenerDatos(" Select	[NUM_RUTA], [COD_TERMINAL_SALIDA], [COD_TERMINAL_LLEGADA], [NUM_TARIFA], [DSC_RUTA], [NUM_TIPO_RUTA], [BOL_ESTADO] ",
                                                                        " From	    [RUTA] ",
                                                                        " WHERE [NUM_RUTA] = " + reader.GetDecimal(2),
                                                                        tipoDato.Ruta);
                            Route addRuta = (Route)temporal[0];

                            temporal = ObtenerDatos(" Select	[NUM_IDENTIFICACION], [NUM_PLACA], [DSC_MARCA], [NUM_MODELO], [NUM_CAPACIDAD], [BOL_ESTADO] ",
                                                            " From	    [AUTOBUS] ",
                                                            " WHERE [NUM_IDENTIFICACION] = " + reader.GetDecimal(3),
                                                            tipoDato.Autobus);

                            Autobus addAutobus = (Autobus)temporal[0];

                            temporal = ObtenerDatos(" Select	[NUM_CEDULA], [NOM_NOMBRE], [NOM_APELLIDO_1], [NOM_APELLIDO_2], [FEC_NACIMIENTO], [TIP_GENERO], [BIT_SUPERVISOR] ",
                                                            " From	    CONDUCTOR ",
                                                            " WHERE [NUM_CEDULA] = '" + reader.GetString(4) + "'",
                                                            tipoDato.Conductores);

                            Driver addConductor = (Driver)temporal[0];



                            objetos.Add(new Role(
                                fecha1,
                                fecha2,
                                addRuta,
                                addAutobus,
                                addConductor
                                ));
                        }
                    }
                    break;
                case tipoDato.Autobus:
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            objetos.Add(new Autobus
                            {
                                Id = (int)reader.GetDecimal(0),
                                PlateNumber = reader.GetString(1),
                                Brand = reader.GetString(2),
                                Model = (int)reader.GetDecimal(3),
                                Capacidad = (int)reader.GetDecimal(4),
                                State = reader.GetBoolean(5)
                            });

                        }
                    }
                    break;
                case tipoDato.Ruta:
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int terminalsalida = (int)reader.GetDecimal(1);
                            List<object> temporal = ObtenerDatos(" Select	[COD_TERMINAL], [NOM_TERMINAL],[DIR_TERMINAL],[NUM_TELEFONO],[TIM_HORA_APERTURA],[TIM_HORA_CIERRE],[BOL_ESTADO] ",
                                                                    " From	    TERMINAL",
                                                                    " WHERE [COD_TERMINAL] = " + terminalsalida,
                                                                    tipoDato.Terminal);

                            Terminal addTerminal1 = (Terminal)temporal[0];


                            int terminalLLegada = (int)reader.GetDecimal(2);

                            temporal = ObtenerDatos(" Select	[COD_TERMINAL], [NOM_TERMINAL],[DIR_TERMINAL],[NUM_TELEFONO],[TIM_HORA_APERTURA],[TIM_HORA_CIERRE],[BOL_ESTADO] ",
                                                        " From	    TERMINAL",
                                                        " WHERE [COD_TERMINAL] = " + terminalLLegada,
                                                        tipoDato.Terminal);

                            Terminal addTerminal2 = (Terminal)temporal[0];



                            objetos.Add(new Route
                                (
                                    (int)reader.GetDecimal(0),
                                    addTerminal1, addTerminal2,
                                    (double)reader.GetDecimal(3),
                                    reader.GetString(4),
                                    (int)reader.GetDecimal(5),
                                    reader.GetBoolean(6)
                                )
                            );
                        }
                    }

                    break;
                case tipoDato.Terminal:
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            objetos.Add(new Terminal
                            {
                                IdTerminal = (int)reader.GetSqlDecimal(0),
                                TerminalName = reader.GetString(1),
                                TerminalAddress = reader.GetString(2),
                                TerminalPhone = int.Parse((string)reader.GetSqlString(3)),
                                OpenHour = DateTime.Parse(reader.GetTimeSpan(4).ToString()),
                                CloseHour = DateTime.Parse(reader.GetTimeSpan(5).ToString()),
                                State = reader.GetBoolean(6)
                            });
                        }
                    }
                    break;
            }
            conexion.Close();

            return objetos;

        }



        //Registra conductores en la base de datos
        public bool AgregarConductor(Driver pDriver)
        {
            bool resultado = false;
            SqlConnection connection = new SqlConnection(cadenaConexion); ;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "   INSERT INTO [CONDUCTOR] ([NUM_CEDULA], [NOM_NOMBRE], [NOM_APELLIDO_1], [NOM_APELLIDO_2], [FEC_NACIMIENTO], [TIP_GENERO], [BIT_SUPERVISOR] ) " +
                        "   VALUES (@numCed, @nombre, @apellido1, @apellido2, @fNac, @genero, @bitSupervisor) ";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;

            comando.Parameters.AddWithValue("@numCed", pDriver.Id);
            comando.Parameters.AddWithValue("@nombre", pDriver.Name);
            comando.Parameters.AddWithValue("@apellido1", pDriver.Surname);
            comando.Parameters.AddWithValue("@apellido2", pDriver.SecondSurname);
            comando.Parameters.AddWithValue("@fNac", pDriver.BirthDate);
            comando.Parameters.AddWithValue("@genero", pDriver.Gender);
            comando.Parameters.AddWithValue("@bitSupervisor", pDriver.DriverSupervisor ? 1 : 0);

            connection.Open();
            try
            {
                if (comando.ExecuteNonQuery() > 0) resultado = true;
            }
            catch
            {
                //Se crea una ventana indicando el error
            }

            connection.Close();

            return resultado;
        }


        //Registra Autobuses en la base de datos
        public bool AgregarAutobus(Autobus pAutobus)
        {
            bool resultado = false;
            SqlConnection connection = new SqlConnection(cadenaConexion); ;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "   INSERT INTO [AUTOBUS] ([NUM_IDENTIFICACION], [NUM_PLACA], [DSC_MARCA], [NUM_MODELO], [NUM_CAPACIDAD], [BOL_ESTADO] ) " +
                        "   VALUES (@id, @placa, @marca, @modelo, @capacidad, @estado) ";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;

            comando.Parameters.AddWithValue("@id", pAutobus.Id);
            comando.Parameters.AddWithValue("@placa", pAutobus.PlateNumber);
            comando.Parameters.AddWithValue("@marca", pAutobus.Brand);
            comando.Parameters.AddWithValue("@modelo", pAutobus.Model);
            comando.Parameters.AddWithValue("@capacidad", pAutobus.Capacidad);
            comando.Parameters.AddWithValue("@estado", pAutobus.State ? 1 : 0);

            connection.Open();
            try
            {
                if (comando.ExecuteNonQuery() > 0) resultado = true;
            }
            catch
            {
                //Se crea una ventana indicando el error
            }

            connection.Close();

            return resultado;
        }

        public bool AgregarRuta(Route pRuta)
        {
            bool resultado = false;
            SqlConnection connection = new SqlConnection(cadenaConexion); ;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "   INSERT INTO RUTA ([NUM_RUTA], [COD_TERMINAL_SALIDA], [COD_TERMINAL_LLEGADA], [NUM_TARIFA], [DSC_RUTA], [NUM_TIPO_RUTA], [BOL_ESTADO] ) " +
                        "   VALUES (@numRuta, @terSal, @terLleg, @tarifa, @descRuta, @tipo, @estado) ";



            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;

            comando.Parameters.AddWithValue("@numRuta", pRuta.Id);
            comando.Parameters.AddWithValue("@terSal", pRuta.DepartureTerminal.IdTerminal);
            comando.Parameters.AddWithValue("@terLleg", pRuta.ArriveTerminal.IdTerminal);
            comando.Parameters.AddWithValue("@descRuta", pRuta.Description);
            comando.Parameters.AddWithValue("@tarifa", pRuta.Rate);
            comando.Parameters.AddWithValue("@tipo", pRuta.Type);
            comando.Parameters.AddWithValue("@estado", pRuta.State ? 1 : 0);

            connection.Open();
            try
            {
                if (comando.ExecuteNonQuery() > 0) resultado = true;
            }
            catch
            {
                //Se crea una ventana indicando el error
            }


            connection.Close();

            return resultado;
        }

        public bool AgregarRol(Role pRole)
        {
            bool resultado = false;
            SqlConnection connection = new SqlConnection(cadenaConexion); ;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "   INSERT INTO ROL ([FEC_ROL], [TIM_HORA_SALIDA], [NUM_RUTA], [NUM_IDENTIFICACION_BUS], [NUM_CEDULA_CONDUCTOR] ) " +
                        "   VALUES ( @fechRol, @HSalida, @NumRuta, @IDBus, @IDConductor ) ";



            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;

            comando.Parameters.AddWithValue("@fechRol", pRole.Date);
            comando.Parameters.AddWithValue("@HSalida", pRole.DepartureHour);
            comando.Parameters.AddWithValue("@NumRuta", pRole.Ruta.Id);
            comando.Parameters.AddWithValue("@IDBus", pRole.Autobus.Id);
            comando.Parameters.AddWithValue("@IDConductor", pRole.Conductor.Id);

            connection.Open();
            try
            {
                if (comando.ExecuteNonQuery() > 0) resultado = true;
            }

            catch
            {
                //Se crea una ventana indicando el error
            }


            connection.Close();

            return resultado;
        }

    }
}