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
    public partial class ConsultarConductores : Form
    {
        Menu menu;
        List<Driver> conductores;

        public ConsultarConductores(Menu _menu)
        {
            InitializeComponent();
            this.menu = _menu;
            this.conductores = _menu.obtenerConductores();
            _menu.Conductores = this.conductores;
        }


        //Actualiza el gridview con los datos disponibles de las conductores.
        private void ConsultarConductores_Load(object sender, EventArgs e)
        {

            foreach(Driver d in conductores) 
            {
                conductoresdataGridView.Rows.Add(
                    d.Id,
                    d.Name,
                    d.Surname,
                    d.SecondSurname,
                    d.BirthDate.ToString("YYYY-MM-dd"),
                    d.Gender,
                    d.DriverSupervisor ? "Si" : "No"
                    );
            }

        }

        

    }
}
