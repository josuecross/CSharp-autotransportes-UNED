using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.src
{
    [Serializable]
    public class Autobus
    {
        private int id;
        private string plateNumber;
        private string brand;
        private int model;
        private int capacidad;
        private bool state;

        public Autobus()
        {
            id = 0;
        }

        public Autobus(int id, string plateNumber, string brand, int model, int capacidad, bool state)
        {
            Id = id;
            PlateNumber = plateNumber;
            Brand = brand;
            Model = model;
            Capacidad = capacidad;
            State = state;
        }

        public int Id { get => id; set => id = value; }
        public string PlateNumber { get => plateNumber; set => plateNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Model { get => model; set => model = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public bool State { get => state; set => state = value; }

    }
}
