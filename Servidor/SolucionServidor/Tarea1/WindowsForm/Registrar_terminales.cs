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
using Entidades.src;
using AccesoBD;

namespace GUI_Servidor
{
    public partial class Registrar_terminales : Form
    {
        private Menu menu;
        private List<Terminal> terminales;
        AccesoDatos ACdatos;

        public Registrar_terminales(Menu _menu)
        {
            InitializeComponent();
            ACdatos = new AccesoDatos();

            this.terminales = new List<Terminal>();
            foreach(object o in ACdatos.ObtenerTerminales())
            {
                terminales.Add((Terminal)o);

            }
            
            this.menu = _menu;
        }

        public Menu Menu { get => menu; set => menu = value; }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            Terminal terminal;
            int terminalPhone = new int();
            string terminalName = nombretextBox.Text;
            string terminalAddress = direcciontextBox.Text;
            DateTime openHour = new DateTime();
            DateTime closeHour = new DateTime();
            bool state = new bool();
            bool idExiste = false;

            // Obtener las horas de apertura y cierre o arrojar una excepcion si no fueron ingresadas correctamente
            try
            {
                horaAperturacomboBox.BackColor = Color.White;
                horaCierracomboBox.BackColor = Color.White;
                openHour = DateTime.ParseExact(horaAperturacomboBox.Text, "H:m", null);
                closeHour = DateTime.ParseExact(horaCierracomboBox.Text, "H:m", null);
            }
            catch (System.FormatException ex)
            {
                horaAperturacomboBox.BackColor = Color.LightSalmon;
                horaCierracomboBox.BackColor = Color.LightSalmon;
                MessageBox.Show("Debe seleccionar correctamente la hora de apertura y cierre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Obtener el estado de la terminal
            estadocomboBox.BackColor = Color.White;
            if (estadocomboBox.Text.Equals("Activo"))
            {
                state = true;
            }
            else if (estadocomboBox.Text.Equals("Inactivo"))
            {
                state = false;
            }
            else if (estadocomboBox.Text.Equals("-Seleccione-"))
            {
                MessageBox.Show("Debe seleccionar el estado de la terminal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estadocomboBox.BackColor = Color.LightSalmon;
                return;
            }

            //Si los datos numericos son correctamente ingresados se procede
            if (Herramientas.validarDatoNumerico(ref terminalPhone, telefonotextBox4))
            {
                terminal = new Terminal(terminales.Count + 1, terminalName, terminalAddress, terminalPhone, openHour, closeHour, state);
                if (ACdatos.AgregarTerminales(terminal))
                {
                    menu.Terminales.Add(terminal);
                    MessageBox.Show("Terminal agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    return;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar la terminal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("El valor que intenta agregar no es valido, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Limpia los datos del formulario para ingresar nuevos
        private void clearFields()
        {
            nombretextBox.Clear();
            direcciontextBox.Clear();
            telefonotextBox4.Clear();
            horaAperturacomboBox.ResetText();
            horaAperturacomboBox.Text = "-Seleccione-";
            horaCierracomboBox.ResetText();
            horaCierracomboBox.Text = "-Seleccione-";
            estadocomboBox.ResetText();
            estadocomboBox.Text = "-Seleccione-";
        }

        private void limpiarDatosbutton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

    }
}
