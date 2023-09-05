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
using Tarea1.WindowsForm;
using Entidades.src;
using LibreriaCliente;
using GUI_Cliente;
using TCPDatos;

namespace Tarea1
{
    public partial class Menu : Form
    {
        private Route[] rutas;
        private Terminal[] terminales;
        private Driver[] conductores;
        private Autobus[] autobuses;

        private List<Role> roles;
        Cliente cliente;

        public Terminal[] Terminales { get => terminales; set => terminales = value; }
        public Driver[] Conductores { get => conductores; set => conductores = value; }
        public Autobus[] Autobuses { get => autobuses; set => autobuses = value; }
        public List<Role> Roles { get => roles; set => roles = value; }

        public Menu(Cliente cliente)
        {
            InitializeComponent();
            this.terminales = new Terminal[20];
            this.conductores = new Driver[20];
            this.autobuses = new Autobus[20];
            this.rutas = new Route[20];

            this.cliente = cliente;
            this.roles = obtenerRoles();
            initializeAllArray();
            CustumizeForm();


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


            List<object> objetosConsulta = cliente.RealizarQuerry(consulta, cliente.Id, PacketType.Consulta, PacketType.Roles);
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


        //Evento de click para el boton que muestra el formulario de registrar terminales
        private void registrarTerminalesButton_Click(object sender, EventArgs e)
        {
            //Crea el objeto con el windows form para la ventana de registrar terminales y la muestra
            Registrar_terminales registrarTerminalesForm = new Registrar_terminales(this, this.Terminales, cliente);
            openChildForm(registrarTerminalesForm);
            hideSubmenu();
        }

        private void registrarConductoresbutton_Click(object sender, EventArgs e)
        {
            var myForm = new Registrar_conductores(this, this.Conductores);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void registrarAutobusesbutton_Click(object sender, EventArgs e)
        {
            var myForm = new Registrar_Autobuses(this, this.autobuses);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void registrarRutasbutton_Click(object sender, EventArgs e)
        {
            var myForm = new RegistrarRutas(this, this.rutas, cliente);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void registrarRolesbutton_Click(object sender, EventArgs e)
        {
            var myForm = new RegistrarRoles(this, cliente);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void consultarTerminalesbutton_Click(object sender, EventArgs e)
        {

            ConsultarTerminales terminalesForm = new ConsultarTerminales(this, this.terminales);
            openChildForm(terminalesForm);
            hideSubmenu();
        }

        private void initializeAllArray()
        {
            for (int i = 0; i < 20; i++)
            {
                rutas[i] = new Route();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarConductores conductoresForm = new ConsultarConductores(this, this.conductores);
            openChildForm(conductoresForm);
            hideSubmenu();
        }

        private void consultarAutobusesbutton_Click(object sender, EventArgs e)
        {
            ConsultarAutobuses consultarAutobusesForm = new ConsultarAutobuses(this, this.autobuses);
            openChildForm(consultarAutobusesForm);
            hideSubmenu();
        }

        private void consultarRutasbutton_Click(object sender, EventArgs e)
        {
            ConsultarRutas consultarRutasForm = new ConsultarRutas(this, this.rutas);
            openChildForm(consultarRutasForm);
            hideSubmenu();
        }

        private void consultarRolesbutton_Click(object sender, EventArgs e)
        {
            consultarRoles consultarRolesForm = new consultarRoles(this, cliente);
            openChildForm(consultarRolesForm);
            hideSubmenu();
        }

        //Incia los componentes del formulario con propiedades custom
        private void CustumizeForm()
        {
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelChildForm.BackColor = Color.FromArgb(23, 21, 32);
            panelRolesSubMenu.Visible = false;
            if (cliente.Conductor.DriverSupervisor)
            {
                registrarRolesbutton.Visible = true;
                consultarRolesbutton.Visible = true;
            }
            else
            {
                registrarRolesbutton.Visible = false;
                consultarRolesbutton.Visible = true;
            }

        }

        private void hideSubmenu()
        {
            if (panelRolesSubMenu.Visible == true)
            {
                panelRolesSubMenu.Visible = false;
            }

        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }




        private void buttonDDRoles_Click(object sender, EventArgs e)
        {
            showSubmenu(panelRolesSubMenu);

        }

        //Variable que guarda el formulario que esta activo actualmente
        private Form activeForm = null;

        //Abrir formularios en el panel del menu
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void buttonClienteConexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarConexion()
        {
            cliente.EnviarDirectiva(new List<object>(), PacketType.Desconexion, this.cliente.Id);
            cliente.DetenerCliente();
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            labelInfoClient.Text = cliente.Conductor.Name + " " + cliente.Conductor.Surname + " " + cliente.Conductor.SecondSurname;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            labelInfoClient.Text = cliente.Conductor.Name + " " + cliente.Conductor.Surname + " " + cliente.Conductor.SecondSurname;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarConexion();
        }
    }
}
