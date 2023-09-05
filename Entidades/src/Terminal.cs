using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.src
{
    [Serializable]
    public class Terminal
    {
        private int idTerminal; //ID de la terminal
        private string terminalName;//Nombre de la terminal
        private string terminalAddress;//Direccion de la terminal
        private int terminalPhone;//Telefono
        private DateTime openHour;//Hora en que abre
        private DateTime closeHour;//Hora en que cierra
        private bool state;//True= Activo o False=inactivo

        public Terminal()
        {
        }

        public Terminal(int idTerminal, string terminalName, string terminalAddress, int terminalPhone, DateTime openHour, DateTime closeHour, bool state)
        {
            IdTerminal = idTerminal;
            TerminalName = terminalName;
            TerminalAddress = terminalAddress;
            TerminalPhone = terminalPhone;
            OpenHour = openHour;
            CloseHour = closeHour;
            State = state;
        }


        public int IdTerminal { get => idTerminal; set => idTerminal = value; }
        public string TerminalName { get => terminalName; set => terminalName = value; }
        public string TerminalAddress { get => terminalAddress; set => terminalAddress = value; }
        public int TerminalPhone { get => terminalPhone; set => terminalPhone = value; }
        public DateTime OpenHour { get => openHour; set => openHour = value; }
        public DateTime CloseHour { get => closeHour; set => closeHour = value; }
        public bool State { get => state; set => state = value; }
    }
}
