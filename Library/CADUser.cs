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
            constring = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
        }

        public bool createUser(ENUser user)
        {
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand command = new SqlCommand("select count(*) from [dbo].uuser where id = @ID", c);
                command.Parameters.AddWithValue("@ID", user.ID);

                SqlDataReader result = command.ExecuteReader();

                result.Read();

                int count = result.GetInt32(0);

                result.Close();

                if (count == 0)
                {
                    SqlCommand insert = new SqlCommand("insert into [dbo].uuser values(@ID, @PASSWORD, @NAME, @BIRTHDAY, @EMAIL, @ADDRESS)", c);
                    insert.Parameters.AddWithValue("@ID", user.ID);
                    insert.Parameters.AddWithValue("@PASSWORD", user.Password);
                    insert.Parameters.AddWithValue("@NAME", user.Name);
                    //if (user.Birthday == "")
                    //    insert.Parameters.AddWithValue("@BIRTHDAY", "NULL");
                    //else
                    //    insert.Parameters.AddWithValue("@BIRTHDAY", user.Birthday);

                    insert.Parameters.AddWithValue("@BIRTHDAY", user.Birthday);
                    insert.Parameters.AddWithValue("@EMAIL", user.Email);
                    insert.Parameters.AddWithValue("@ADDRESS", user.Address);

                    insert.ExecuteNonQuery();

                    c.Close();
                    return true;
                }
                else
                    c.Close();
                return false; // Already exists
            }
            catch(Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
        }

        public bool updateUser(ENUser user)
        {
            // Code to update the information of the user
            // Returns true if user was updated succesfully. False in other case

            return true;
        }

        public bool deleteUser(ENUser user)
        {
            // Code to delete the user
            // Returns true if user was deleted succesfully. False in other case

            return true;
        }
    }
}
