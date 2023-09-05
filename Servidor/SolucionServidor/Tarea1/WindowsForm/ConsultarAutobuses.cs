using Entidades.src;
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


namespace GUI_Servidor.WindowsForm
{
    public partial class ConsultarAutobuses : Form
    {
        Menu menu;
        List<Autobus> autobuses;

        public ConsultarAutobuses(Menu _menu)
        {
            InitializeComponent();
            this.menu = _menu;
            this.autobuses = _menu.obtenerAutobuses();
            this.menu.Autobuses = this.autobuses;
        }

        private void ConsultarAutobuses_Load(object sender, EventArgs e)
        {
            foreach(Autobus a in this.autobuses) { 
                consultarAutobusesdataGridView.Rows.Add(
                    a.Id,
                    a.PlateNumber,
                    a.Brand,
                    a.Model,
                    a.Capacidad,
                    a.State?"Activo":"Inactivo"
                );
            }
        }
    }
}
