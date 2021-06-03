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

        public DataSet createCar(ENCar en)
        {
    
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter ("Insert INTO [dbo].[car] (licensePlate, brand, model, description, imgURL,price) VALUES "
                                                            + "('" + en.LicensePlate + "','" + en.Brand + "','" + en.Model + "','" + en.Description  + "','" + en.imgURL +"'," +en.Price + ")", c);
                adapter.Fill(virtualSet, "car");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Car creation has failed.Error: {0}", e.Message);
                return null;
            }

        }

        public DataSet deleteCar(ENCar en)
        {

            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM[dbo].[car] WHERE licenseplate = '" + en.LicensePlate + "'", c);
                adapter.Fill(virtualSet, "car");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Car delete has failed.Error: {0}", e.Message);
                return null;
            }


        }

        public DataSet updatePriceCar(ENCar en)
        {

            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[car] SET price= " + en.Price + " WHERE licenseplate = '" + en.LicensePlate + "'", c);
                adapter.Fill(virtualSet, "car");
                return virtualSet;
            }
            catch(Exception e)
            {
                Console.WriteLine("Car delete has failed.Error: {0}", e.Message);
                return null;
            }

        }

        public DataSet updateDescriptionCar(ENCar en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[car] SET description= '" + en.Description + "' WHERE licenseplate = '" + en.LicensePlate + "'", c);
                adapter.Fill(virtualSet, "car");
                return virtualSet;
            }
            catch(Exception e)
            {
                Console.WriteLine("Car delete has failed.Error: {0}", e.Message);
                return null;
            }

        }

        public DataSet listAllCars()
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT licenseplate,brand,model,price,description,imgURL FROM car", c);
                adapter.Fill(virtualSet, "car");
                return virtualSet;
            }
            catch(Exception e)
            {
                Console.WriteLine("Car listing has failed.Error: {0}", e.Message);
                return null;
            }

        }

    }
}
