using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace Library
{
	public class CADUser
	{
        // Connection string for the database

        private string constring;

        public CADUser()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }

        public bool createUser(ENUser user)
        {
            // Code to check if that ID or email already exists on the database or not
            // Returns true if user was created succesfully. False in other case
        }

        public bool updateUser(ENUser user)
        {
            // Code to update the information of the user
            // Returns true if user was updated succesfully. False in other case
        }

        public bool deleteUser(ENUser user)
        {
            // Code to delete the user
            // Returns true if user was deleted succesfully. False in other case
        }
    }
}
