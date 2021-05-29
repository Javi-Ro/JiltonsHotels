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

        public DataSet createStaff(ENStaff en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("Insert INTO [dbo].[staff] (email, name, type, description, imgURL) VALUES "
                                                            + "('" + en.Email + "','" + en.Name + "','" + en.Type + "','" + en.Description +"','"+ en.imgURL + "')", c);
                adapter.Fill(virtualSet, "staff");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Staff creation has failed.Error: {0}", e.Message);
                return null;
            }
        }

        public DataSet deleteStaff(ENStaff en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM [dbo].[staff] WHERE email = '" + en.Email + "'", c);
                adapter.Fill(virtualSet, "staff");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Staff delete has failed.Error: {0}", e.Message);
                return null;
            }
        }

        public DataSet updateDescriptionStaff(ENStaff en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[staff] SET description= '" + en.Description + "' WHERE email = '" + en.Email + "'", c);
                adapter.Fill(virtualSet, "staff");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Staff update has failed.Error: {0}", e.Message);
                return null;
            }
        }

        public DataSet listAllStaff()
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT email,name,type,description,imgURL FROM staff", c);
                adapter.Fill(virtualSet, "staff");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Staff listing has failed.Error: {0}", e.Message);
                return null;
            }

        }
        public List<string> FilterByType(ENStaff en)
        {
            try
            {
                List<string> staff = new List<string>();
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter;
                if (en.Type == "extra")
                {
                    adapter = new SqlDataAdapter("SELECT email FROM staff WHERE type = 'teacher' or type = 'guide'", c);
                }
                else
                {
                    adapter = new SqlDataAdapter("SELECT email FROM staff WHERE type = '" + en.Type + "'", c);
                }
                adapter.Fill(virtualSet, "staff");
                DataTable t = new DataTable();
                t = virtualSet.Tables["staff"];
                foreach (DataRow dr in t.Rows)
                {
                    staff.Add(dr[0].ToString());
                }
                return staff;
            }
            catch (Exception e)
            {
                Console.WriteLine("Staff filter has failed.Error: {0}", e.Message);
                return null;
            }
        }

    }
}
