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
using Entidades;
using Entidades;
using Entidades.src;

namespace Tarea1.WindowsForm
{
    public partial class ConsultarAutobuses : Form
    {
        Menu menu;
        Autobus[] autobuses;

        public ConsultarAutobuses(Menu _menu, Autobus[] _autobuses)
        {
            InitializeComponent();
            menu = _menu;
            autobuses = _autobuses;
        }

        private void ConsultarAutobuses_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                //si el id corresponde a 0 no se muestra en el gridview
                if (autobuses[i] != null)
                {
                    consultarAutobusesdataGridView.Rows.Add(
                        autobuses[i].Id,
                        autobuses[i].PlateNumber,
                        autobuses[i].Brand,
                        autobuses[i].Model,
                        autobuses[i].Capacidad,
                        autobuses[i].State?"Activo":"Inactivo"
                    );

                }
            }
        }
    }
}
