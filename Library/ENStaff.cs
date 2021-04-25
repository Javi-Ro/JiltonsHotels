using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENStaff
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

        public string Contact //this is an email that's why we use String
        {
            get { return contacto; }
            private set { contacto = value; }
        }

        public int Telephone
        {
            get { return telefono; }
            private set { telefono = value; }
        }

        public int Wage
        {
            get { return salario; }
            private set { salario = value; }
        }

        public ENStaff(int id, string nombre, string contacto, int telefono, int salario)
        {
            this.id = id;
            this.nombre = nombre;
            this.contacto = contacto;
            this.telefono = telefono;
            this.salario = salario;
        }
        public ENStaff()
        {

        }

        public class Massagist : ENStaff
        {
            CADStaff massagist = new CADStaff();
        }
        public class Teacher : ENStaff
        {
            CADStaff teacher = new CADStaff();
        }
        public class TouristGuide : ENStaff
        {
            CADStaff touristGuide = new CADStaff();
        }
        public class PersonalTrainer : ENStaff
        {
            CADStaff personalTrainer = new CADStaff();
        }

        public bool createStaff()
        {
            CADStaff staff = new CADStaff();
            return staff.createStaff(this);
        }

        public bool deleteStaff()
        {
            CADStaff staff = new CADStaff();
            return staff.deleteStaff(this);
        }

        public bool updateContactStaff(string contacto)
        {
            CADStaff staff = new CADStaff();
            this.contacto = contacto;
            return staff.updateContactStaff(this);
        }

        public bool updateTelephoneStaff(int telefono)
        {
            CADStaff staff = new CADStaff();
            Telephone = telefono;
            this.telefono = telefono;
            return staff.updateTelephoneStaff(this);
        }

        public bool updateWageStaff(int salario)
        {
            CADStaff staff = new CADStaff();
            this.salario = salario;
            return staff.updateWageStaff(this);
        }


    }
}
