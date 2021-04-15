using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CADPackage
    {
        string constring;

        public CADPackage(int id, ENService services, string name, string desc, int price)
        {

        }

        public bool createPackage(ENPackage pack)
        {

        }

        public bool deletePackage(ENPackage pack)
        {

        }

        public bool searchPackage(ENPackage pack)
        {

        }

        //SERVICES IN THE PACKAGE
        public ENService[] getServices()
        {

        }

        public bool addService(ENPackage pack, ENService serv)
        {

        }

        public bool deleteService(ENPackage pack, ENService serv)
        {

        }

        public bool includes(ENPackage pack, ENService serv)
        {

        }


    }
}