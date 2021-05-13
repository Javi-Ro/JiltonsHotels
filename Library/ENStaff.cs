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
        private string tipo;
        private string descripcion;

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

        public string Type //It can be massagist, trainer... we suppose they can not change work, obviusly but...
        {
            get { return tipo; }
            private set { tipo = value; }
        }
        public string Description
        {
            get { return descripcion; }
            private set { descripcion = value; }
        }

        public ENStaff(int id, string nombre, string contacto, string tipo, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.contacto = contacto;
            this.tipo = tipo;
            this.descripcion = descripcion;
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

        public bool updateDescriptionStaff(string descripcion)
        {
            CADStaff staff = new CADStaff();
            this.descripcion = descripcion;
            return staff.updateDescriptionStaff(this);
        }


    }
}
