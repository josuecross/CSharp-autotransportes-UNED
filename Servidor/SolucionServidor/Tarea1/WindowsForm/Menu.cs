using GUI_Servidor.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_Servidor.WindowsForm;
using Entidades.src;
using LibreriaServidor;
using System.Threading;
using AccesoBD;

namespace GUI_Servidor
{
    public partial class Menu : Form
    {
        private List<Terminal> terminales;
        private List<Driver> conductores;
        private List<Autobus> autobuses;
        private List<Route> rutas;

        
        private Role[] roles;
        private Thread threadEstado;
        EscribirEnTextboxDelegado modificarTextotxtBitacora;
        ModoficarListBoxDelegado modificarListBoxClientes;
        private Thread actualizarBitacoraThread;
        private Thread actualizarListaClientesThread;
        private Thread iniciarservidorThread;
        private bool stopThreads;
        AccesoDatos ACdatos;

        public Role[] Roles { get => roles; set => roles = value; }
        public List<Driver> Conductores { get => conductores; set => conductores = value; }
        public List<Terminal> Terminales { get => terminales; set => terminales = value; }
        public List<Autobus> Autobuses { get => autobuses; set => autobuses = value; }
        public List<Route> Rutas { get => rutas; set => rutas = value; }

        public Menu()
        {
            

            InitializeComponent();

            //Metodos delgados para ralizar modificacions a elemnto del ormulario desde un  subproceso
            this.modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            this.modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);
            this.ACdatos = new AccesoDatos();


            this.conductores = obtenerConductores();

            this.terminales = ACdatos.ObtenerTerminales();

            this.autobuses = obtenerAutobuses();

            this.rutas = obtenerRutas();

            this.roles = new Role[20];

            this.stopThreads = false;

            initializeAllArray();
            CustumizeDesign();


            this.iniciarservidorThread = new Thread(Servidor.EjecutarServidor);
            iniciarservidorThread.Start();


            //Thread que actualiza bitacora en la pantalla principal
            this.actualizarBitacoraThread = new Thread(actualizarBitacora);
            actualizarBitacoraThread.Start();

            //Thread que actualiza lista de clientes en la pantalla principal
            this.actualizarListaClientesThread = new Thread(actualizarListaClientes);
            actualizarListaClientesThread.Start();
            
        }


        public List<Driver> obtenerConductores()
        {
            List <Driver> resultado = new List<Driver>();
            List <object> temporal = ACdatos.ObtenerDatos(  " Select	[NUM_CEDULA], [NOM_NOMBRE], [NOM_APELLIDO_1], [NOM_APELLIDO_2], [FEC_NACIMIENTO], [TIP_GENERO], [BIT_SUPERVISOR] ",
                                                            " From	    CONDUCTOR ",
                                                            " ",
                                                            tipoDato.Conductores);
            foreach (object objeto in temporal)
            {
                resultado.Add((Driver)objeto);
            }

            return resultado;
        }

        public List<Autobus> obtenerAutobuses()
        {
            List<Autobus> resultado = new List<Autobus>();
            List<object> temporal = ACdatos.ObtenerDatos(" Select	[NUM_IDENTIFICACION], [NUM_PLACA], [DSC_MARCA], [NUM_MODELO], [NUM_CAPACIDAD], [BOL_ESTADO] ",
                                                            " From	    [AUTOBUS] ",
                                                            " ",
                                                            tipoDato.Autobus);
            foreach (object objeto in temporal)
            {
                resultado.Add((Autobus)objeto);
            }

            return resultado;
        }

        public List<Route> obtenerRutas()
        {
            List<Route> resultado = new List<Route>();
            List<object> temporal = ACdatos.ObtenerDatos(" Select	[NUM_RUTA], [COD_TERMINAL_SALIDA], [COD_TERMINAL_LLEGADA], [NUM_TARIFA], [DSC_RUTA], [NUM_TIPO_RUTA], [BOL_ESTADO] ",
                                                            " From	    [RUTA] ",
                                                            " ",
                                                            tipoDato.Ruta);
            foreach (object objeto in temporal)
            {
                resultado.Add((Route)objeto);
            }

            return resultado;
        }



        //Delegado, necesario para modificar controles de la interfaz gráfica desde un subproceso
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModoficarListBoxDelegado();

        //Evento de click para el boton que muestra el formulario de registrar terminales
        private void registrarTerminalesButton_Click(object sender, EventArgs e)
        {
            //Crea el objeto con el windows form para la ventana de registrar terminales y la muestra
            Registrar_terminales registrarTerminalesForm = new Registrar_terminales(this);
            openChildForm(registrarTerminalesForm);
            hideSubmenu();
        }

        private void registrarConductoresbutton_Click(object sender, EventArgs e)
        {
            var myForm = new Registrar_conductores(this);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void registrarAutobusesbutton_Click(object sender, EventArgs e)
        {
            var myForm = new Registrar_Autobuses(this);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void registrarRutasbutton_Click(object sender, EventArgs e)
        {
            var myForm = new RegistrarRutas(this);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void registrarRolesbutton_Click(object sender, EventArgs e)
        {
            var myForm = new RegistrarRoles(this, this.roles);
            openChildForm(myForm);
            hideSubmenu();
        }

        private void consultarTerminalesbutton_Click(object sender, EventArgs e)
        {
            
            ConsultarTerminales terminalesForm = new ConsultarTerminales(this);
            openChildForm(terminalesForm);
            hideSubmenu();
        }

        private void initializeAllArray()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarConductores conductoresForm = new ConsultarConductores(this);
            openChildForm(conductoresForm);
            hideSubmenu();
        }

        private void consultarAutobusesbutton_Click(object sender, EventArgs e)
        {
            ConsultarAutobuses consultarAutobusesForm = new ConsultarAutobuses(this);
            openChildForm(consultarAutobusesForm);
            hideSubmenu();
        }

        private void consultarRutasbutton_Click(object sender, EventArgs e)
        {
            ConsultarRutas consultarRutasForm = new ConsultarRutas(this);
            openChildForm(consultarRutasForm);
            hideSubmenu();
        }

        private void consultarRolesbutton_Click(object sender, EventArgs e)
        {
            consultarRoles consultarRolesForm = new consultarRoles(this, this.roles);
            openChildForm(consultarRolesForm);
            hideSubmenu();
        }

        //Incia los componentes del formulario con propiedades custom
        private void CustumizeDesign()
        {
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelChildForm.BackColor = Color.FromArgb(23, 21, 32);
            panelTerminalesSubMenu.BackColor = Color.FromArgb(32, 32, 39);
  

            //Ocultar los paneles de los submenu
            panelTerminalesSubMenu.Visible = false;
            panelConductoresSubmenu.Visible = false;
            panelAutobusesSubMenu.Visible = false;
            panelRutasSubMenu.Visible = false;
            panelRolesSubMenu.Visible = false;

        }


        //Esconde los todos los elementos del submenu
        private void hideSubmenu()
        {
            if(panelTerminalesSubMenu.Visible == true)
            {
                panelTerminalesSubMenu.Visible = false;
            }
            if(panelConductoresSubmenu.Visible == true)
            {
                panelConductoresSubmenu.Visible = false;
            }
            if(panelAutobusesSubMenu.Visible == true)
            {
                panelAutobusesSubMenu.Visible = false;
            }
            if(panelRutasSubMenu.Visible == true)
            {
                panelRutasSubMenu.Visible = false;
            }
            if(panelRolesSubMenu.Visible == true)
            {
                panelRolesSubMenu.Visible = false;
            }
        }

        //Muestra un subpanel del menu
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

        //Botones del submenu que muestran las opciones
        private void buttonDDTerminales_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTerminalesSubMenu);
        }

        private void buttonDDConductores_Click(object sender, EventArgs e)
        {
            showSubmenu(panelConductoresSubmenu);
        }

        private void buttonDDAutobuses_Click(object sender, EventArgs e)
        {
            showSubmenu(panelAutobusesSubMenu);
        }

        private void buttonDDRutas_Click(object sender, EventArgs e)
        {
            showSubmenu(panelRutasSubMenu);
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
            if(activeForm != null)
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

        private void mostrarOcultarBitacorabutton_Click(object sender, EventArgs e)
        {
            if (panelserverInfo.Visible == false)
            {
                panelserverInfo.Visible = true;
            }
            else
                panelserverInfo.Visible = false;
        }


        //Metodo que verifica los cambios recibidos por el servidor e invoca escribirlos en la bitacora
        private void actualizarBitacora()
        {
            string lastReaded = "";
            textBoxBitacora.Text = "Iniciando Aplicacion";
            while (!stopThreads)
            {
                if (!Servidor.bitacoraServer.Equals(lastReaded))
                {
                    try
                    {
                        textBoxBitacora.Invoke(modificarTextotxtBitacora, new object[] { Servidor.bitacoraServer });
                        lastReaded = Servidor.bitacoraServer;

                    }
                    catch (System.InvalidOperationException) {  }
                    
                }
               
            }
        }

        //Metodo que llama a actualizar la lista de clientes cada segundo
        private void actualizarListaClientes()
        {
            while (!stopThreads)
            {
                Thread.Sleep(1000);
                try
                {
                    lstClientesConectados.Invoke(modificarListBoxClientes);
                }
                catch
                {
               
                }
                
            }
        }


        //Escribir en la bitacora de la aplicacion
        private void EscribirEnTextbox(string texto)
        {
            textBoxBitacora.AppendText(DateTime.Now.ToString() + " - " + texto + "\n");
            textBoxBitacora.AppendText(Environment.NewLine);
        }

        //Escribir en la lista de clientes del menu
        private void ModificarListBox()
        {
            lstClientesConectados.Items.Clear();
            foreach(ClientData client in Servidor.clients)
            {
                lstClientesConectados.Items.Add(client.Id + "\n");
            }

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopThreads = true;
            Servidor.detenerServidor();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
