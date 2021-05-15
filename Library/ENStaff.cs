using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENStaff
    {

        private string email;
        private string nombre;
        private string tipo;
        private string descripcion;

        public string Email //PK
        {
            get { return email; }
            private set { email = value; }
        }

        public string Name
        {
            get { return nombre; }
            private set { nombre = value; }
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

        public ENStaff(string email, string nombre, string tipo, string descripcion)
        {
            this.email = email;
            this.nombre = nombre;
            this.tipo = tipo;
            this.descripcion = descripcion;
        }
 
        public DataSet createStaff()
        {
            CADStaff staff = new CADStaff();
            return staff.createStaff(this);
        }

        public DataSet deleteStaff()
        {
            CADStaff staff = new CADStaff();
            return staff.deleteStaff(this);
        }
        public DataSet updateDescriptionStaff(string descripcion)
        {
            CADStaff staff = new CADStaff();
            this.descripcion = descripcion;
            return staff.updateDescriptionStaff(this);
        }
        public DataSet listAllStaff()
        {
            CADStaff staff = new CADStaff();
            return staff.listAllStaff();
        }

    }
}
