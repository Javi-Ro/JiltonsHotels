using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Library
{
    public class CADService
    {
        private string constring;

        public CADService()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createService(ENService en)
        {
            bool ok = false;
            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena;
                cadena = "Insert INTO [].[] ()";
                SqlCommand com = new SqlCommand(cadena, con);
                com.ExecuteNonQuery();
                ok = true;
            }
            catch(SqlException e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch(Exception e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return ok;
        }

        public bool deleteService(ENService en)
        {
            bool ok = true;
            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena = "DELETE FROM";
                SqlCommand com = new SqlCommand(cadena, con);
                com.ExecuteNonQuery();
                ok = true;
                con.Close();
            }
            catch(SqlException e) 
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch(Exception e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return ok;
        }

        public bool updateService(ENService en)
        {
            bool ok = true;
            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena = "UPDATE";
                SqlCommand com = new SqlCommand(cadena, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return ok;
        }

        public List<ENService> listAllServices()
        {

        }

        public ENService searchService()
        {

        }

    }
}