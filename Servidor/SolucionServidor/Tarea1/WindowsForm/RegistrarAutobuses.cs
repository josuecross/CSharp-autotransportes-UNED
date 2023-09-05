using GUI_Servidor.src;
using Entidades.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoBD;

namespace GUI_Servidor
{
    public partial class Registrar_Autobuses : Form
    {
        Menu menu;
        List<Autobus> autobuses;
        AccesoDatos ACDatos;
        public Registrar_Autobuses(Menu _menu)
        {
            InitializeComponent();
            ACDatos = new AccesoDatos();
            this.menu = _menu;
            this.autobuses = _menu.obtenerAutobuses();
            this.menu.Autobuses = this.autobuses;
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            //Se obtienen todos los datos del formulario RegistrarAutobus
            int capacidad = new int();
            bool estado = new bool();
            string idPlaca = idPlacatextBox.Text;
            string marca = marcatextBox.Text;
            int modelo = new int();

            //Obtiene el valor del combobox de estado para asignarselo al autobus
            estadocomboBox.BackColor = Color.White;
            if (estadocomboBox.Text.Equals("Activo"))
            {
                estado = true;
            }
            else if (estadocomboBox.Text.Equals("Inactivo"))
            {
                estado = false;
            }
            else if (estadocomboBox.Text.Equals("-Seleccionar-"))
            {
                MessageBox.Show("Debe seleccionar el estado del conductor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estadocomboBox.BackColor = Color.LightSalmon;
                return;
            }

            //Si la placa se deja vacio o con espacios se detiene
            if (idPlaca.Equals("") || idPlaca.Contains(" "))
            {
                MessageBox.Show("No se permite dejar la placa vacia o con espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si los datos numericos son correctos
            if (Herramientas.validarDatoNumerico(ref capacidad, capacidadtextBox) && Herramientas.validarDatoNumerico(ref modelo, modelotextBox))
            {
                foreach (Autobus a in autobuses)
                {

                    //Si se encuentra el id de la placa que se quiere ingresar se detiene con error
                    if (a.PlateNumber.Equals(idPlaca))
                    {
                        MessageBox.Show("La placa ingresado ya esta asignado a otrp autobus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

  
                Autobus addAutobus = new Autobus(autobuses.Count + 1, idPlaca, marca, modelo, capacidad, estado);
                if (ACDatos.AgregarAutobus(addAutobus))
                {
                    MessageBox.Show("Autobus agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudieron agregar los datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("La capacidad y modelo debe ser un dato numerico mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void clearFields()
        {
            capacidadtextBox.Clear();
            estadocomboBox.ResetText();
            estadocomboBox.Text = "-Seleccionar-";
            idPlacatextBox.Clear();
            marcatextBox.Clear();
            modelotextBox.Clear();

        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

    }
}
