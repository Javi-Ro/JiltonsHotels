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
    class CADDiscount
    {
        string constring;

        public CADDiscount()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createDiscount(ENDiscount discount)
        {
            bool create = false;
            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "Insert INTO [dbo].[discount] (code, percentage) VALUES ('" + discount.code + "','" + discount.percentage + ")";

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

            return create;
        }

        public bool deleteDiscount(ENDiscount discount)
        {
            bool delete = false;

            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "DELETE FROM [dbo].[discount] WHERE code = '" + discount.code + "'";

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

            return delete;
        }

        public bool updatePercentage(ENDiscount discount)
        {
            bool update = true;
            try
            {

                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                string msg = "UPDATE [dbo].[package] WHERE code= '" + discount.code + "' SET percentage= '" + discount.percentage + "'";

                SqlCommand busqueda = new SqlCommand(msg, conection);

                busqueda.ExecuteNonQuery();
                conection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                update = false;
            }

            return update;
        }
        /*
        public ENBooking[] getBookings(ENDiscount discount)
        {

        }*/


    }
}