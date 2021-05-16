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
    class CADPackage
    {
        string constring;

        public CADPackage()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public DataSet createPackage(ENPackage pack)
        {
            /*bool create = false;
            try
            {*/

                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("Insert INTO [dbo].[package] (id, name, description, price) VALUES ('" + pack.id + "','" + pack.name + "','" + pack.description + "','" + pack.price + ")", c);
                adapter.Fill(virtualSet, "package");
                return virtualSet;

                /*
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "Insert INTO [dbo].[package] (id, name, description, price) VALUES ('" + pack.id + "','" + pack.name + "','" + pack.description + "','" + pack.price + ")";

                SqlCommand consulta = new SqlCommand(msg, conection);
                consulta.ExecuteNonQuery();

                create = true;
                conection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                create = false;
            }

            return create;*/
            }

        public DataSet deletePackage(ENPackage pack)
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM [dbo].[package] WHERE id = '" + pack.id + "'", c);
            adapter.Fill(virtualSet, "package");
            return virtualSet;

            /*bool delete = false;

            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "DELETE FROM [dbo].[package] WHERE id = '" + pack.id + "'";

                SqlCommand busqueda = new SqlCommand(msg, conection);
                busqueda.ExecuteNonQuery();

                delete = true;
                conection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                delete = false;
            }

            return delete;*/
        }

        public DataSet searchPackage(ENPackage pack)
        {

            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT FROM [dbo].[package] WHERE id = '" + pack.id + "'", c);
            adapter.Fill(virtualSet, "package");
            return virtualSet;

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

            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[package] WHERE id= '" + pack.id + "' SET price= '" + pack.price + "'", c);
            adapter.Fill(virtualSet, "package");
            return virtualSet;

            /*
            bool update = true;
            try
            {

                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "UPDATE [dbo].[package] WHERE id= '" + pack.id + "' SET price= '" + pack.price + "'";

                SqlCommand busqueda = new SqlCommand(msg, conection);

                busqueda.ExecuteNonQuery();
                conection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                update = false;
            }

            return update;*/
        }

        /*SERVICES IN THE PACKAGE
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

        }*/


    }
}