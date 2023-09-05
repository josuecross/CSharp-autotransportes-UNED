using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.src
{
    [Serializable]
    public class Route
    {
        private int id;
        private Terminal departureTerminal;
        private Terminal arriveTerminal;
        private double rate;
        private string description;
        private int type;
        private bool state;

        public Route()
        {
            id = -1;
        }

        public Route(int id, Terminal departureTerminal, Terminal arriveTerminal, double rate, string description, int type, bool state)
        {
            this.id = id;
            this.departureTerminal = departureTerminal;
            this.arriveTerminal = arriveTerminal;
            this.rate = rate;
            this.description = description;
            this.type = type;
            this.state = state;
        }

        public int Id { get => id; set => id = value; }
        public Terminal DepartureTerminal { get => departureTerminal; set => departureTerminal = value; }
        public Terminal ArriveTerminal { get => arriveTerminal; set => arriveTerminal = value; }
        public double Rate { get => rate; set => rate = value; }
        public string Description { get => description; set => description = value; }
        public int Type { get => type; set => type = value; }
        public bool State { get => state; set => state = value; }
    }
}
