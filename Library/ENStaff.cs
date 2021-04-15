using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ENStaff
    {
        private int id;
        private string nombre;
        private string contacto;
        private int telefono;
        private int salario;

        public int ID
        {
            get { return id; }
            private set { id = value; }
        }

        public string Name
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public string Contact
        {
            get { return contacto; }
            private set { contacto = value; }
        }

        public string Telephone
        {
            get { return telefono; }
            private set { telefono = value; }
        }

        public string Wage
        {
            get { return salario; }
            private set { salario = value; }
        }

        public ENStaff(string id, string nombre, string contacto, int telefono, int wage)
        {

        }

        public class Massagist : ENStaff()
        {

        }
        public class Teacher : ENStaff()
        {

        }
        public class TouristGuide : ENStaff()
        {

        }
        public class PersonalTrainer : ENStaff()
        {

        }

        public bool createStaff()
        {

        }

        public bool deleteStaff()
        {

        }

        public bool updateContactStaff(string contacto)
        {

        }

        public bool updateTelephoneStaff(string telefono)
        {

        }

        public bool updateWageStaff(int salario)
        {

        }


    }
}
