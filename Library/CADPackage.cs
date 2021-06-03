using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;

namespace Library
{
    class CADPackage
    {
        private string constring;

        public CADPackage()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }

        public DataSet createPackage(ENPackage pack)
        {
           

            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("Insert INTO package (id, name, description, price) VALUES (" + 
                                                                pack.id + ",'" + pack.name + "','" + pack.description + "'," + pack.price + ")", c);
                adapter.Fill(virtualSet, "pack");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Pack creation has failed.Error: {0}", e.Message);
                return null;
            }
        }

        public DataSet deletePackage(ENPackage pack)
        {

           

            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM [dbo].[package] WHERE id = " + pack.id , c);
                adapter.Fill(virtualSet, "pack");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Car delete has failed.Error: {0}", e.Message);
                return null;
            }

        }

        public DataSet searchPackage(ENPackage pack)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT FROM [dbo].[package] WHERE id = " + pack.id , c);
                adapter.Fill(virtualSet, "package");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                return null;
            }


            /*
            bool found = false;

            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "SELECT FROM [dbo].[package] WHERE id = '" + pack.id + "'";

                SqlCommand busqueda = new SqlCommand(msg, conection);
                busqueda.ExecuteNonQuery();

                found = true;
                conection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                found = false;
            }

            return found;*/
        }
        public DataSet updatePricePackage(ENPackage pack)
        {
            

            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[package] SET price= " + pack.price + " WHERE id= " + pack.id, c);
                adapter.Fill(virtualSet, "pack");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Pack delete has failed.Error: {0}", e.Message);
                return null;
            }

        }

        public DataSet updateDescPackage(ENPackage pack)
        {
            

            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[package] SET description= '" + pack.description + "'WHERE id = " + pack.id, c);
                adapter.Fill(virtualSet, "pack");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Pack delete has failed.Error: {0}", e.Message);
                return null;
            }

        }

        public DataSet listAllPackages(ENPackage pack)
        {
            DataSet aux = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM package", con);
                adapter.Fill(aux, "package");
                return aux;
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return aux;
        }
        /*
        public string getServices()
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id,name,description,imgURL FROM package", c);
                adapter.Fill(virtualSet, "package");

                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                return null;
            }
        }

        SERVICES IN THE PACKAGE


        public bool addService(ENPackage pack, ENService serv)
        {

        }

        public bool deleteService(ENPackage pack, ENService serv)
        {

        }

        public bool includes(ENPackage pack, ENService serv)
        {

        }*/


    }
}