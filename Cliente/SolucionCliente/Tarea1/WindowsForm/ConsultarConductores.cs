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
    public partial class ConsultarConductores : Form
    {
        Menu menu;
        Driver[] conductores;

        public ConsultarConductores(Menu _menu, Driver[] _conductores)
        {
            InitializeComponent();
            menu = _menu;
            conductores = _conductores;
        }
        //Actualiza el gridview con los datos disponibles de las conductores.
        private void ConsultarConductores_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                //si el id corresponde a 0 no se muestra en el gridview
                if (conductores[i] != null)
                {
                    conductoresdataGridView.Rows.Add(
                        conductores[i].Id,
                        conductores[i].Name,
                        conductores[i].Surname,
                        conductores[i].SecondSurname,
                        conductores[i].BirthDate.ToString("YYYY-MM-dd"),
                        conductores[i].Gender,
                        conductores[i].DriverSupervisor?"Si":"No"
                    );
                }

            }
        }

        

    }
}
