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

namespace Tarea1
{
    public partial class Registrar_terminales : Form
    {
        private Menu menu;
        private Terminal[] terminales;
        Cliente cliente;
        

        public Registrar_terminales(Menu _menu, Terminal[] _terminales, Cliente _cliente)
        {
            InitializeComponent();
            terminales = _terminales;
            menu = _menu;
            this.cliente = _cliente;
        }

        public Menu Menu { get => menu; set => menu = value; }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
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
                for (int i = 0; i < 20; i++)
                {   
                    //Si el indice i esta vacio se procede
                    if(this.terminales[i] == null)
                    {
                        terminales[i] = new Terminal(i + 1, terminalName, terminalAddress, terminalPhone, openHour, closeHour, state);
                        
                        clearFields();

                        List<Object> _terminales = new List<Object>();

                        _terminales.Add(new Terminal(8899889, terminalName, terminalAddress, terminalPhone, openHour, closeHour, state));
                        cliente.EnviarDatos(_terminales, PacketType.Terminales, "admin");
                        MessageBox.Show("Terminal agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                //Si no se logro encontrar un espacio vacio se detiene con error
                MessageBox.Show("Se alcanzo el numero maximo de terminales", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
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
