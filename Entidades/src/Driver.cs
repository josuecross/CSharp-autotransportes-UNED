using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.src
{
    [Serializable]
    public class Driver
    {
        private string id;
        private string name;
        private string surname;
        private string secondSurname;
        private DateTime birthDate;
        private char gender;
        private bool driverSupervisor;

        public Driver()
        {
            Id = " ";
        }

        public Driver(string id, string name, string surname, string secondSurname, DateTime birthDate, char gender, bool driverSupervisor)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.secondSurname = secondSurname;
            this.birthDate = birthDate;
            this.gender = gender;
            this.driverSupervisor = driverSupervisor;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string SecondSurname { get => secondSurname; set => secondSurname = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public char Gender { get => gender; set => gender = value; }
        public bool DriverSupervisor { get => driverSupervisor; set => driverSupervisor = value; }


    }
}
