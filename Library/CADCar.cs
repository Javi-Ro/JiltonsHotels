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
    public class CADCar
    {

        private String constring;

        public CADCar()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createCar(ENCar en)
        {
            bool create = false;
            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();
                
                //nombres pendientes de ser verificados y creados en la db, son orientativos
                string msg = "Insert INTO [dbo].[car] (licensePlate, brand, model, description, price) VALUES ('" + en.LicensePlate + "','" + en.Brand + "'," + en.Model + "','" + en.Description + "','" + en.Price + ")";

                SqlCommand consulta = new SqlCommand(msg, conection);
                consulta.ExecuteNonQuery();

                create = true;
                conection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                create = false;
            }

            return create;
        }

        public bool deleteCar(ENCar en)
        {
            bool delete = false;

            try
            {
                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                //Nombre de SQL por ver :)
                string msg = "DELETE FROM [dbo].[Cars] WHERE licenseplate = '" + en.LicensePlate + "'";

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

        public bool updatePriceCar(ENCar en)
        {
            bool update = true;
            try
            {

                SqlConnection conection = new SqlConnection(constring);
                conection.Open();

                //inventao free hd esta mal 80% seguro
                string msg = "UPDATE [dbo].[Cars] SET price= '" + en.Price + "'";

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
        public bool updateDescriptionCar(ENCar en)
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

        public List<ENCar> listAllCars()
        {
            ENCar car = new ENCar("5342GRM","Audi","Q5",65000,"Dale paa");
            List < ENCar > a = new List<ENCar>();
            return a;
        }


    }
}
