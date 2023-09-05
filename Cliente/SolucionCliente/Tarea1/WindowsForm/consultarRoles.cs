using GUI_Cliente.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.src;
using LibreriaCliente;
using TCPDatos;

namespace Tarea1.WindowsForm
{
    public partial class consultarRoles : Form
    {
        Menu menu;
        List<Role> roles;
        Cliente cliente;

        public consultarRoles(Menu _menu, Cliente _cliente)
        {
            InitializeComponent();
            this.menu = _menu;
            this.cliente = _cliente;
            this.roles = obtenerRoles();
            this.menu.Roles = this.roles;
        }

        private List<Role> obtenerRoles()
        {
            List<object> consulta = new List<object>();
            if (cliente.Conductor.DriverSupervisor)
            {
                consulta = new List<object>
                {
                    " Select	[FEC_ROL], [TIM_HORA_SALIDA], [NUM_RUTA], [NUM_IDENTIFICACION_BUS], [NUM_CEDULA_CONDUCTOR] ",
                    " From	    ROL ",
                    ""
                };
            }
            else
            {
                consulta = new List<object>
                {
                    " Select	[FEC_ROL], [TIM_HORA_SALIDA], [NUM_RUTA], [NUM_IDENTIFICACION_BUS], [NUM_CEDULA_CONDUCTOR] ",
                    " From	    ROL ",
                    " WHERE [NUM_CEDULA_CONDUCTOR] = '" + cliente.Conductor.Id + "'"
                };

            }


            List<object> objetosConsulta = cliente.RealizarConsulta(consulta, cliente.Id, PacketType.Roles);
            List<Role> resultado = new List<Role>();

            if (objetosConsulta.Count > 0)
            {

                object lastItem = objetosConsulta.Last();



                foreach (object o in objetosConsulta)
                {
                    if (o != lastItem)
                        resultado.Add((Role)o);
                }
            }
            return resultado;
        }



        //Funciones con polimorfismo para validar que los distintos objetos de conductor,ruta y autobus existan, envia una solicitud al servidor y recibe el dato solicitado
        private bool validarObjetoPorId(int id, ref Route _asignarObjeto)
        {
            List<object> consulta = new List<object>{
                " Select	[NUM_RUTA], [COD_TERMINAL_SALIDA], [COD_TERMINAL_LLEGADA], [NUM_TARIFA], [DSC_RUTA], [NUM_TIPO_RUTA], [BOL_ESTADO] ",
                 " From	    [RUTA] ",
                 " Where [NUM_RUTA] = " + id,
            };

            List<object> objetosConsulta = cliente.RealizarConsulta(consulta, cliente.Id, PacketType.Rutas);

            if (objetosConsulta.Count > 0)
            {
                string lastItem = (string)objetosConsulta.Last();
                MessageBox.Show((string)lastItem, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _asignarObjeto = (Route)objetosConsulta[0];
                return true;
            }


            return false;
        }

        private bool validarObjetoPorId(int id, ref Autobus _asignarObjeto)
        {
            List<object> consulta = new List<object>{
                " Select	[NUM_IDENTIFICACION], [NUM_PLACA], [DSC_MARCA], [NUM_MODELO], [NUM_CAPACIDAD], [BOL_ESTADO] ",
                 "  From       [AUTOBUS] ",
                 " Where [NUM_IDENTIFICACION] = " + id,
            };


            List<object> objetosConsulta = cliente.RealizarConsulta(consulta, cliente.Id, PacketType.Autobus);

            if (objetosConsulta.Count > 0)
            {
                string lastItem = (string)objetosConsulta.Last();
                MessageBox.Show((string)lastItem, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _asignarObjeto = (Autobus)objetosConsulta[0];
                return true;
            }


            return false;
        }

        //Cada vez que se selecciona una fila se obtienen los valores y se cambian los label para la informacion de rutas y autobuses
        private void consultarRolesdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Se obtiene el index de la fila actualmente seleccionada y se pasa como argumento
            int index = consultarRolesdataGridView.CurrentCell.RowIndex;
            setInformacionRuta(index);
            setInformacionAutobus(index);
            
        }

        //Muestra la informacion del id de la ruta en la respectiva etiquete y la informacion requerida
        private void setInformacionRuta(int index)
        {
            Route ruta = new Route();
            int idAValidar = System.Int32.Parse(consultarRolesdataGridView.Rows[index].Cells[2].Value.ToString());

            //Se obtiene el objeto a partir del id
            validarObjetoPorId(idAValidar, ref ruta);

            rutalabel.Text = "Ruta: " +idAValidar;
            terminalOrigenlabel.Text = "Origen: " + ruta.DepartureTerminal.TerminalName;
            terminalDestinolabel.Text = "Destino: " + ruta.ArriveTerminal.TerminalName;
            tarifalabel.Text = "Tarifa: " + ruta.Rate;
            tipolabel.Text = "Tipo: " + ruta.Type;
        }

        //Muestra la informacion del id del autobus el la respectiva etiqueta junto y la informacion requerida
        private void setInformacionAutobus(int index)
        {
            Autobus autobus = new Autobus();
            int idAValidar = System.Int32.Parse(consultarRolesdataGridView.Rows[index].Cells[3].Value.ToString());

            //Se obtiene el objeto a partir del id
            validarObjetoPorId(idAValidar, ref autobus);

            autobuslabel.Text = "Autobus: " + idAValidar + " (encontrado)";
            placalabel.Text = "Placa: " + autobus.PlateNumber;
            marcalabel.Text = "Marca: " + autobus.Brand;
            capacidadlabel.Text = "Capacidad: " + autobus.Capacidad;
        }

        private void consultarRoles_Load(object sender, EventArgs e)
        {
            foreach(Role r in roles) { 
                    consultarRolesdataGridView.Rows.Add(
                        r.Date,
                        r.DepartureHour.ToString("HH:mm"),
                        r.Ruta.Id,
                        r.Autobus.Id,
                        r.Conductor.Name + r.Conductor.Surname
                    );

                
            }
        }


    }
}
