using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ENPackage
    {

        
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            private set { _name = value; }
        }

        private string _desc;
        public string description
        {
            get { return _desc; }
            private set { _desc = value; }
        }

        private int _price;
        public int price
        {
            get { return _price; }
            set { _price = value; }
        }

        public ENPackage(int id,ENService services, string name, string desc, int price)
        {

        }

        public bool createPackage()
        {
            CADPackage p = new CADPackage();
            return p.createPackage(this);
        }

        public bool deletePackage()
        {
            CADPackage p = new CADPackage();
            return p.deletePackage(this);
        }

        public bool searchPackage()
        {
            CADPackage p = new CADPackage();
            return p.searchPackage(this);
        }

        //SERVICES IN THE PACKAGE
        public ENService[] getServices() const
        {

        }

        public bool addService(ENService serv)
        {
            CADPackage p = new CADPackage();
            return p.addService(this,serv);
        }

        public bool deleteService(ENService serv)
        {
            CADPackage p = new CADPackage();
            return p.deleteService(this, serv);
        }

        public bool includes(ENService serv)
        {
            CADPackage p = new CADPackage();
            return p.includes(this, serv);

        }


    }
}

