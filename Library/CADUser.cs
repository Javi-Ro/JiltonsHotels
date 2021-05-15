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

        public bool CreateUser(ENUser user)
        {
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand command = new SqlCommand("select count(*) from [dbo].uuser where id = @ID or email = @EMAIL", c);
                command.Parameters.AddWithValue("@ID", user.ID);
                command.Parameters.AddWithValue("@EMAIL", user.Email);

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

        public bool UpdateUser(ENUser user)
        {
            // Code to update the information of the user
            // Returns true if user was updated succesfully. False in other case

            return true;
        }

        public bool DeleteUser(ENUser user)
        {
            // Code to delete the user
            // Returns true if user was deleted succesfully. False in other case

            return true;
        }

        public int LoginUser(ENUser user)
        {
            // Code to login the user
            // Returns 0 if user was logged in, 1 if that data doesn't exist, and 2 if the password is incorrect

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand command = new SqlCommand("select count(*) from [dbo].uuser where email = @DATA", c);
                command.Parameters.AddWithValue("@DATA", user.LoginData);

                SqlDataReader result = command.ExecuteReader();

                result.Read();

                int count = result.GetInt32(0);

                result.Close();

                if (count != 0)
                {
                    SqlCommand command2 = new SqlCommand("select count(*) from [dbo].uuser where email = @DATA and password = @PASSWORD", c);
                    command2.Parameters.AddWithValue("@DATA", user.LoginData);
                    command2.Parameters.AddWithValue("@PASSWORD", user.Password);
                    user.Email = user.LoginData;

                    SqlDataReader result2 = command2.ExecuteReader();

                    result2.Read();

                    int count2 = result2.GetInt32(0);

                    c.Close();
                    
                    if (count2 != 0)
                    {
                        return 0; // All correct
                    }
                    else
                    {
                        return 2; // Incorrect password
                    }
                }
                else
                    c.Close();
                return 1; // Doesn't exist
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return -1;
            }
        }
    }
}
