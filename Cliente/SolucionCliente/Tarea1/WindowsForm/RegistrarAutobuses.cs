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

namespace Tarea1
{
    public partial class Registrar_Autobuses : Form
    {
        Menu menu;
        Autobus[] autobuses;
        public Registrar_Autobuses(Menu _menu, Autobus[] _autobuses)
        {
            InitializeComponent();
            menu = _menu;
            autobuses = _autobuses;
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
                for (int i = 0; i < 20; i++)
                {   
                    if(this.autobuses[i] != null)
                    {
                        //Si se encuentra el id de la placa que se quiere ingresar se detiene con error
                        if (this.autobuses[i].PlateNumber.Equals(idPlaca))
                        {
                            MessageBox.Show("La placa ingresado ya esta asignado a otra autobus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //Si hay un espacio vacio en el array
                    else
                    {
                        autobuses[i] = new Autobus(i + 1, idPlaca, marca, modelo, capacidad, estado);
                        MessageBox.Show("Autobus agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        return;
                    }
                }
                MessageBox.Show("Solo se pueden agregar hasta 20 autobuses ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La capacidad debe ser un dato numerico mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
