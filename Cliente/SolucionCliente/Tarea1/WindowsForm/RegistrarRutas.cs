using GUI_Cliente.src;
using LibreriaCliente;
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
using TCPDatos;

namespace Tarea1
{
    public partial class RegistrarRutas : Form
    {
        Menu menu;
        Route[] rutas;
        Cliente cliente;
        public RegistrarRutas(Menu _menu, Route[] _rutas, Cliente _cliente)
        {
            InitializeComponent();
            this.menu = _menu;
            this.rutas = _rutas;
            this.cliente = _cliente;
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {            
            double rate = new double();
            int idDepartureTerminal = new int();
            int idArriveTerminal = new int();

            string description = descripciontextBox.Text;

            bool state = new bool();
            int type = new int();

            Terminal terminalSalida = new Terminal();
            Terminal terminalLlegada = new Terminal();

            //Guardar el estado de la ruta
            estadocomboBox.BackColor = Color.White;
            if (estadocomboBox.Text.Equals("Activo"))
            {
                state = true;
            }
            else if (estadocomboBox.Text.Equals("Inactivo"))
            {
                state = false;
            }
            else if (estadocomboBox.Text.Equals("-Seleccionar-")){
                MessageBox.Show("Debe seleccionar el estado de la ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estadocomboBox.BackColor = Color.LightSalmon;
                return;

            }

            //Se obtiene el tipo de ruta
            if(tipoRutacomboBox.Text.Equals("1 = Directo"))
            {
                type = 1;
            }
            else if(tipoRutacomboBox.Text.Equals("2 = Regular"))
            {
                type = 2;
            }
            else if (tipoRutacomboBox.Text.Equals("-Seleccionar-"))
            {
                MessageBox.Show("Debe seleccionar el tipo de la ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tipoRutacomboBox.BackColor = Color.LightSalmon;
                return;

            }

            //Se validan los datos numericos ingresados en los textbox
            if (Herramientas.validarDatoNumerico(ref rate, tarifatextBox) && Herramientas.validarDatoNumerico(ref idDepartureTerminal, idsalidatextBox) && Herramientas.validarDatoNumerico(ref idArriveTerminal, idllegadatextBox))
            {
                //Se valida que existan las terminales con el id indicado
                if(validarTerminales(idDepartureTerminal, idsalidatextBox, ref terminalSalida) && validarTerminales(idArriveTerminal, idllegadatextBox,ref terminalLlegada) && idDepartureTerminal != idArriveTerminal)
                {
                    //Se le indica al usuario las terminales seleccionadas y se le pide confirmar
                    DialogResult dialogResult = MessageBox.Show("Terminal de Salida: " + terminalSalida.TerminalName + " \nTerminal de llegada: " + terminalLlegada.TerminalName, "Terminales seleccionadas", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (rutas[i].Id == -1)
                            {
                                List<Object> rutas = new List<Object>();


                                rutas.Add(new Route(i + 1, terminalSalida, terminalLlegada, rate, description, type, state));
                                cliente.EnviarDatos(rutas, PacketType.Rutas, "Josue");


                                MessageBox.Show("Ruta agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                return;
                            }

                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Descartado" , "No se guardaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }                   

                }
                else
                {
                    MessageBox.Show("Revise el id del terminal ya que no existe o es el mismo el valor de salida y llegada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("El valor que intenta agregar no es un número valido.Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

       

        //Se validan las terminales a partir del id
        private bool  validarTerminales(int id, TextBox _textboxValidar,ref Terminal _asignarTerminal)
        {
            _textboxValidar.BackColor = Color.White;
            for (int i = 0; i < 20; i++)
            {
                if(menu.Terminales[i] != null)
                {
                    if (menu.Terminales[i].IdTerminal == id)
                    {
                        _asignarTerminal = menu.Terminales[i];
                        return true;
                    }
                }
            }
            _textboxValidar.BackColor = Color.LightSalmon;
            return false;
        }

        private void clearFields()
        {
            tarifatextBox.Clear();
            idsalidatextBox.Clear();
            idllegadatextBox.Clear();
            descripciontextBox.Clear();
            estadocomboBox.ResetText();
            estadocomboBox.Text = "-Seleccione-";
            tipoRutacomboBox.ResetText();
            tipoRutacomboBox.Text = "-Seleccione-";
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //Se muestra el nombre de la terminal cuando se cambia el texto en el idSalidaTextBox del formulario
        private void idsalidatextBox_TextChanged(object sender, EventArgs e)
        {
            idsalidatextBox.BackColor = Color.White;
            infoTerminalSalida.ForeColor = Color.White;
            int idSalida = new int();


            //La excepccion se maneja a travez de la clase estatica Herramientas
            if(Herramientas.validarDatoNumerico(ref idSalida, idsalidatextBox))
            {
                for(int i =0; i < 20; i++)
                {
                    //Se verifican solo los espacios no nulos
                    if(menu.Terminales[i] != null)
                    {
                        //Si el id de la terminal es igual al numero ingresado en el idSalidaTextBox
                        if (menu.Terminales[i].IdTerminal == idSalida)
                        {
                            infoTerminalSalida.ForeColor = Color.Green;
                            infoTerminalSalida.Text = menu.Terminales[i].TerminalName;
                            return;
                        }
                    }
                }
                infoTerminalSalida.ForeColor = Color.Red;
                infoTerminalSalida.Text = "La terminal no existe o no se han agregado terminales";
            }
            else
            {
                infoTerminalSalida.ForeColor = Color.Red;
                infoTerminalSalida.Text = "Debe igresar solo datos numericos";
                return;
            }

            
        }

        private void RegistrarRutas_Activated(object sender, EventArgs e)
        {
            
        }

        private void idllegadatextBox_TextChanged(object sender, EventArgs e)
        {
            idllegadatextBox.BackColor = Color.White;
            infoTerminalLlegada.ForeColor = Color.White;
            int idLlegada = new int();


            //La excepccion se maneja a travez de la clase estatica Herramientas
            if (Herramientas.validarDatoNumerico(ref idLlegada, idllegadatextBox))
            {
                for (int i = 0; i < 20; i++)
                {
                    //Se verifican solo los espacios no nulos
                    if (menu.Terminales[i] != null)
                    {
                        //Si el id de la terminal es igual al numero ingresado en el idSalidaTextBox
                        if (menu.Terminales[i].IdTerminal == idLlegada)
                        {
                            infoTerminalLlegada.ForeColor = Color.Green;
                            infoTerminalLlegada.Text = menu.Terminales[i].TerminalName;
                            return;
                        }
                    }
                }
                infoTerminalLlegada.ForeColor = Color.Red;
                infoTerminalLlegada.Text = "La terminal no existe o no se han agregado terminales";
            }
            else
            {
                infoTerminalLlegada.ForeColor = Color.Red;
                infoTerminalLlegada.Text = "Debe igresar solo datos numericos";
                return;
            }
        }

    }
}
