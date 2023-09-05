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
    internal partial class Registrar_conductores : Form
    {
        Menu menu;
        Driver[] conductores;
        public Registrar_conductores(Menu _menu, Driver[] _conductores)
        {
            InitializeComponent();
            menu = _menu;
            conductores = _conductores;
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            //Obtener los datos de los diferentes campos del formulario RegistrarConductor
            string identificacion = idtextBox.Text;
            string name = nombretextBox.Text;
            string apellido = primerApellidotextBox.Text;
            string segundoApellido = segundoApellidotextBox.Text;
            bool supervisor = new bool();
            DateTime fechaNacimiento = DateTime.Parse(fechaNacimientodateTimePicker.Text);
            char genero = ' ';

            //Obtener el genero del conductor
            generocomboBox.BackColor = Color.White;
            if (generocomboBox.Text.Equals("Masculino"))
            {
                genero = 'M';
            }
            else if(generocomboBox.Text.Equals("Femenino"))
            {
                genero = 'F';
            }
            else if (generocomboBox.Text.Equals("-Seleccionar-"))
            {
                MessageBox.Show("Debe seleccionar el gener del conductor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generocomboBox.BackColor = Color.LightSalmon;
                return;
            }

            //Obtener el conductor es supervisor o no
            supervisorcomboBox.BackColor = Color.White;
            if (supervisorcomboBox.Text.Equals("Si"))
            {
                supervisor = true;
            }
            else if (supervisorcomboBox.Text.Equals("No"))
            {
                supervisor = false;
            }
            else if (supervisorcomboBox.Text.Equals("-Seleccionar-"))
            {
                MessageBox.Show("Debe seleccionar si es conductor supervisor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                supervisorcomboBox.BackColor = Color.LightSalmon;
                return;
            }

            //Si el id se deja vacio o con espacios se detiene
            if (identificacion.Equals("") || identificacion.Contains(" "))
            {
                MessageBox.Show("No se permite dejar el id vacio o con espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Crear el objeto driver y agregarlo al indice correcto del array conductores
                for (int i = 0; i < 20; i++)
                {
                    //Si el indice tiene un conductor
                    if (this.conductores[i] != null)
                    {
                        //Si se encuentra el id del conductor que se quiere ingresar se detiene con error
                        if (this.conductores[i].Id.Equals(identificacion))
                        {
                            MessageBox.Show("El id ingresado ya esta asignado a otra persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //Si el indice i esta vacio se procede a agregar al conductor
                    else
                    {
                        conductores[i] = new Driver(identificacion, name, apellido, segundoApellido, fechaNacimiento, genero, supervisor);
                        MessageBox.Show("Conductor agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        return;
                    }
                }
                MessageBox.Show("Solo se pueden agregar hasta 20 terminales ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void clearFields()
        {
            generocomboBox.ResetText();
            generocomboBox.Text = "-Seleccionar-";
            idtextBox.ResetText();
            nombretextBox.ResetText();
            primerApellidotextBox.ResetText();
            segundoApellidotextBox.ResetText();
            supervisorcomboBox.ResetText();
            supervisorcomboBox.Text = "-Seleccionar-";
            fechaNacimientodateTimePicker.ResetText();
        }

        private void limpiarDatosbutton_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }

}
