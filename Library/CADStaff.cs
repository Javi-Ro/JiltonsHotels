using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Library
{
    public class CADStaff
    {

        private String constring;

        public CADStaff()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createStaff(ENStaff en)
        {
            return true;
        }

        public bool deleteStaff(ENStaff en)
        {
            return true;

        }

        public bool updateContactStaff(ENStaff en)
        {
            return true;

        }

        public bool updateTelephoneStaff(ENStaff en)
        {
            return true;

        }
        public bool updateWageStaff(ENStaff en)
        {
            return true;

        }

    }
}
