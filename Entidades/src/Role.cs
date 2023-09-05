using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.src
{
    [Serializable]
    public class Role
    {
        private DateTime _date;
        private DateTime departureHour;
        private Route ruta;
        private Autobus autobus;
        private Driver conductor;

        public Role(DateTime fecha, DateTime departureHour, Route ruta, Autobus autobus, Driver conductor)
        {
            this.Date = fecha;
            this.departureHour = departureHour;
            this.ruta = ruta;
            this.autobus = autobus;
            this.conductor = conductor;
        }

        public DateTime DepartureHour { get => departureHour; set => departureHour = value; }
        public Route Ruta { get => ruta; set => ruta = value; }
        public Autobus Autobus { get => autobus; set => autobus = value; }
        public Driver Conductor { get => conductor; set => conductor = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
