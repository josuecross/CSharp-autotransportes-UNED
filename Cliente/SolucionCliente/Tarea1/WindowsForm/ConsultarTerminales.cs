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

namespace Tarea1.WindowsForm
{
    public partial class ConsultarTerminales : Form
    {
        Menu menu;
        Terminal[] terminales;
        public ConsultarTerminales(Menu _menu, Terminal[] _terminales)
        {
            InitializeComponent();
            menu = _menu;
            terminales = _terminales;
        }

        //Actualiza el gridview con los datos disponibles de las terminales
        private void ConsultarTerminales_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                //si el id corresponde a 0 no se muestra en el gridview
                if (terminales[i] != null)
                {
                    terminalesdataGridView.Rows.Add(
                        terminales[i].IdTerminal,
                        terminales[i].TerminalName,
                        terminales[i].TerminalAddress,
                        terminales[i].TerminalPhone,
                        terminales[i].OpenHour.ToString("HH:mm"),
                        terminales[i].CloseHour.ToString("HH:mm"),
                        terminales[i].State?"Activo":"Inactivo"
                    );

                }

            }

        }
    }
}
