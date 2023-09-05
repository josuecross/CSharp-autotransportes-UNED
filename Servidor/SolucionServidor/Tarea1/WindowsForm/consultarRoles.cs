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

namespace GUI_Servidor.WindowsForm
{
    public partial class consultarRoles : Form
    {
        Menu menu;
        Role[] roles;

        public consultarRoles(Menu _menu, Role[] _roles)
        {
            InitializeComponent();
            this.menu = _menu;
            this.roles = _roles;    
        }


        //Funciones con polimorfismo para validar que los distintos objetos de conductor,ruta y autobus existan
        private bool validarObjetoPorId(int id, ref Route _asignarObjeto)
        {
            for (int i = 0; i < 20; i++)
            {
                if (menu.Rutas[i].Id == id)
                {
                    _asignarObjeto = menu.Rutas[i];
                    return true;
                }
            }
            return false;
        }

        private bool validarObjetoPorId(int id, ref Autobus _asignarObjeto)
        {
            for (int i = 0; i < 20; i++)
            {
                if (menu.Autobuses[i].Id == id)
                {
                    _asignarObjeto = menu.Autobuses[i];
                    return true;
                }
            }
            return false;
        }

        //Cada vez que se selecciona una fila se obtienen los valores y se cambian los label para la informacion de rutas y autobuses
        private void consultarRolesdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Se obtiene el index de la fila actualmente seleccionada y se pasa como argumento
            int index = consultarRolesdataGridView.CurrentCell.RowIndex;
            setInformacionRuta(index);
            setInformacionAutobus(index);
            
        }

        //Muestra la informacion del id de la ruta en la respectiva etiquete y la informacion requerida
        private void setInformacionRuta(int index)
        {
            Route ruta = new Route();
            int idAValidar = System.Int32.Parse(consultarRolesdataGridView.Rows[index].Cells[2].Value.ToString());

            //Se obtiene el objeto a partir del id
            validarObjetoPorId(idAValidar, ref ruta);

            rutalabel.Text = "Ruta: " +idAValidar;
            terminalOrigenlabel.Text = "Origen: " + ruta.DepartureTerminal.TerminalName;
            terminalDestinolabel.Text = "Destino: " + ruta.ArriveTerminal.TerminalName;
            tarifalabel.Text = "Tarifa: " + ruta.Rate;
            tipolabel.Text = "Tipo: " + ruta.Type;
        }

        //Muestra la informacion del id del autobus el la respectiva etiqueta junto y la informacion requerida
        private void setInformacionAutobus(int index)
        {
            Autobus autobus = new Autobus();
            int idAValidar = System.Int32.Parse(consultarRolesdataGridView.Rows[index].Cells[3].Value.ToString());

            //Se obtiene el objeto a partir del id
            validarObjetoPorId(idAValidar, ref autobus);

            autobuslabel.Text = "Autobus: " + idAValidar + " (encontrado)";
            placalabel.Text = "Placa: " + autobus.PlateNumber;
            marcalabel.Text = "Marca: " + autobus.Brand;
            capacidadlabel.Text = "Capacidad: " + autobus.Capacidad;
        }

        private void consultarRoles_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                //si el id corresponde a 0 no se muestra en el gridview
                if (this.roles[i] != null)
                {
                    consultarRolesdataGridView.Rows.Add(
                        roles[i].Date,
                        roles[i].DepartureHour.ToString("HH:mm"),
                        roles[i].Ruta.Id,
                        roles[i].Autobus.Id,
                        roles[i].Conductor.Name + roles[i].Conductor.Surname
                    );

                }
            }
        }


    }
}
