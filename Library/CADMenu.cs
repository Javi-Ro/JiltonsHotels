using System;
using System.Configuration;
using System.Data.SqlClient;

public class CADMenu
{
    private string constring;

    public CADMenu()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
    }

    public bool showMenu(ENMenu menu)
    {
        bool leer = false;
        SqlConnection conn = null;
        string comando = "SELECT* FROM restaurant WHERE dailyMenu = CONVERT(varchar, '" + menu.fecha + "', 103)";
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            SqlDataReader buscador = cmd.ExecuteReader();
            buscador.Read();

            if (buscador["dailyMenu"].ToString() == menu.fecha)      //lo encuentra
            {
                menu.main = buscador["mains"].ToString();
                menu.appetizers = buscador["appetizers"].ToString();
                menu.dessert = buscador["dessert"].ToString();
                menu.price = float.Parse(buscador["price"].ToString());
                leer = true;
            }
            else
                leer = false;


            buscador.Close();
            return leer;
        }
        catch (SqlException ex)
        {
            Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("User operation has failed.Error: {0}", ex2.Message);
        }
        finally
        {
            if (conn != null) conn.Close();
        }
        return false;
    }

    public bool create(ENMenu menu)
    {
        SqlConnection conn = null;

        String comando = "INSERT INTO[dbo].[Restaurant]([appetizers],[mains], [desserts],[price],[dailyMenu]) VALUES ('" + menu.appetizers + "', '" + menu.main + "', '" + menu.dessert + "', " + menu.price + ", '" + menu.fecha + "')";
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.ExecuteNonQuery();      //devuelve la cantidad de registros afectados
            conn.Close();
            return true;
        }
        catch (SqlException ex)
        {
            Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
        }
        catch (Exception ex2)
        {

            Console.WriteLine("User operation has failed.Error: {0}", ex2.Message);
        }
        finally
        {
            if (conn != null) conn.Close();
        }
        return false;

    }
}
