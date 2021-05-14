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
            bool create = false;
            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();
                
                //nombres pendientes de ser verificados y creados en la db, son orientativos
                string msg = "Insert INTO [dbo].[Staff] (id, name, contact, type, description) VALUES ('" + en.ID + "','" + en.Name + "'," + en.Contact + "','" + en.Type + "','" + en.Description + ")";

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

        public bool deleteStaff(ENStaff en)
        {
            bool delete = false;

            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                //Nombre de SQL por ver :)
                string msg = "DELETE FROM [dbo].[Cars] WHERE licenseplate = '" + en.ID + "'";

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

        public bool updateContactStaff(ENStaff en)
        {
            bool update = true;
            try
            {

                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                //inventao free hd esta mal 80% seguro
                string msg = "UPDATE [dbo].[Staff] SET contact= '" + en.Contact + "'";

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

        public bool updateDescriptionStaff(ENStaff en)
        {
            bool update = true;
            try
            {

                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                //inventao free hd esta mal 80% seguro
                string msg = "UPDATE [dbo].[Cars] SET description= '" + en.Description + "'";

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


    }
}
