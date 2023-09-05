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

namespace GUI_Servidor.WindowsForm
{
    public partial class ConsultarRutas : Form
    {
        Menu menu;
        public ConsultarRutas(Menu _menu)
        {
            InitializeComponent();
            this.menu = _menu;
        }


        private void ConsultarRutas_Load(object sender, EventArgs e)
        {
            foreach (Route r in this.menu.Rutas)
                {
                    consultarRutasdataGridView.Rows.Add(
                        r.Id,
                        r.DepartureTerminal.TerminalName,
                        r.ArriveTerminal.TerminalName,
                        r.Rate,
                        r.Description,
                        r.Type,
                        r.State?"Activo":"Inactivo"
                    );
            }
        }


    }


}
