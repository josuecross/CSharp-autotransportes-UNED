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
    public partial class ConsultarRutas : Form
    {
        Menu menu;
        Route[] rutas;
        public ConsultarRutas(Menu _menu, Route[] _rutas)
        {
            InitializeComponent();
            this.menu = _menu;
            this.rutas = _rutas;
        }


        private void ConsultarRutas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                //si el id corresponde a 0 no se muestra en el gridview
                if (rutas[i].Id != -1)
                {
                    consultarRutasdataGridView.Rows.Add(
                        rutas[i].Id,
                        rutas[i].DepartureTerminal.TerminalName,
                        rutas[i].ArriveTerminal.TerminalName,
                        rutas[i].Rate,
                        rutas[i].Description,
                        rutas[i].Type,
                        rutas[i].State?"Activo":"Inactivo"
                    );

                }
            }
        }


    }


}
