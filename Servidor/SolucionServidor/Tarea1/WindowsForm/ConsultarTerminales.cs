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

namespace GUI_Servidor.WindowsForm
{
    public partial class ConsultarTerminales : Form
    {
        Menu menu;
        List<Terminal> terminales;
        AccesoDatos ACdatos;

        public ConsultarTerminales(Menu _menu)
        {
            InitializeComponent();
            this.menu = _menu;
            this.ACdatos = new AccesoDatos();
            this.terminales = ACdatos.ObtenerTerminales();
            this.menu.Terminales = this.terminales;
        }

        //Actualiza el gridview con los datos disponibles de las terminales
        private void ConsultarTerminales_Load(object sender, EventArgs e)
        {

            foreach (Terminal t in this.terminales) 
            {
                terminalesdataGridView.Rows.Add(
                    t.IdTerminal,
                    t.TerminalName,
                    t.TerminalAddress,
                    t.TerminalPhone,
                    t.OpenHour.ToString("HH:mm"),
                    t.CloseHour.ToString("HH:mm"),
                    t.State?"Activo":"Inactivo"
                );

            }

        }
    }
}
