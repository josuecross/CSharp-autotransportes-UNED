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

namespace GUI_Cliente.WindowsForm
{
    public partial class SolicitarCedula : Form
    {
        Cliente cliente;
        public SolicitarCedula(Cliente _cliente)
        {

            InitializeComponent();
            this.DialogResult = DialogResult.No;
            this.cliente = _cliente;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            cliente.Id = id;

            List<object> consulta = new List<object>{
                " Select	[NUM_CEDULA], [NOM_NOMBRE], [NOM_APELLIDO_1], [NOM_APELLIDO_2], [FEC_NACIMIENTO], [TIP_GENERO], [BIT_SUPERVISOR] ",
                 "  From	    CONDUCTOR  ",
                 " Where [NUM_CEDULA] = '" + id + "'",
            };


            List<object> objetosConsulta = cliente.RealizarQuerry(consulta, cliente.Id, PacketType.Consulta, PacketType.Registration);

            string lastItem = (string)objetosConsulta.Last();

            switch (lastItem)
            {
                case "Exito":
                    if (objetosConsulta.Count > 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.cliente.ClienteAceptado = true;
                        this.cliente.Conductor = (Driver)objetosConsulta[0];
                        return;
                    }
                    else
                        MessageBox.Show("No se encontro su numero de cedula, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "No enviado":
                    MessageBox.Show("Hubo un problema al enviar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "SocketException":
                    MessageBox.Show("Hubo un problema con la conexion al servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "NullReferenceException":
                    MessageBox.Show("Hubo un problema al leer la respuesta del servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Sin respuesta":
                    MessageBox.Show("No se recibieron datos del servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void SolicitarCedula_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
