
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

    /// <summary>
    /// function to show the menu
    /// </summary>
    /// <param name="menu"></param>
    /// <returns> if the menu was properly shown </returns>
    public bool showMenu(ENMenu menu)
    {
        bool leer = false;
        SqlConnection conn = null;
        string comando = "SELECT * FROM restaurant WHERE dailyMenu = CONVERT(varchar, '" + menu.fecha + "', 101)";
        
        try
        {
            string[] aux = new string[3];
            aux = menu.fecha.Split('/');
            string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            SqlDataReader buscador = cmd.ExecuteReader();
            buscador.Read();
            if (buscador["dailyMenu"].ToString().Substring(0,10) == fechaFormateada)     //lo encuentra
            {
                menu.main = buscador["mains"].ToString();
                menu.appetizers = buscador["appetizers"].ToString();
                menu.dessert = buscador["desserts"].ToString();
                menu.price = float.Parse(buscador["price"].ToString());
                leer = true;
            }
            else
                leer = false;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error showing the menu of the day " + menu.fecha, ex2.Message);
        }
        finally
        {
            if (conn != null) 
                conn.Close();
            
        }
        return leer;
    }

    /// <summary>
    /// functon to create menu
    /// </summary>
    /// <param name="menu"></param>
    /// <returns>wether the menu was created or not </returns>
    public bool create(ENMenu menu)
    {
        SqlConnection conn = null;
        String comando = "INSERT INTO [dbo].[Restaurant]([dailyMenu],[appetizers],[mains], [desserts],[price]) VALUES ('" + menu.fecha + "', '" + menu.appetizers + "', '" + menu.main + "', '" + menu.dessert + "', " + menu.price + ")";
        bool crear = false;
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.ExecuteNonQuery();      //devuelve la cantidad de registros afectados
            conn.Close();
            crear = true;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error creating the menu of the day " + menu.fecha, ex2.Message);
        }
        finally
        {
            if (conn != null)
                conn.Close();

        }
        return crear;

    }

    /// <summary>
    /// functon to update menu
    /// </summary>
    /// <param name="menu"></param>
    /// <returns>wether the menu was updated or not </returns>
    public bool update(ENMenu menu)
    {
        DateTime aux = Convert.ToDateTime(menu.fecha);
        SqlConnection conn = null;

        bool update = false;
        String comando = "Update [dbo].[Restaurant] SET appetizers = '" + menu.appetizers + "', " +
            "mains='" + menu.main + "', desserts='" + menu.dessert + "', " + " price=" + menu.price.ToString() + " WHERE dailyMenu = @aux";

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@aux", aux);
            cmd.ExecuteNonQuery();      //devuelve la cantidad de registros afectados
            update = true;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error updating the menu of the day " + menu.fecha, ex2.Message);
        }
        finally
        {
            if (conn != null)
                conn.Close();

        }
        return update;

    }


    /// <summary>
    /// functon to delete menu
    /// </summary>
    /// <param name="menu"></param>
    /// <returns>wether the menu was deleted or not </returns>
    public bool delete(ENMenu menu)
    {
        
        SqlConnection conn = null;
        DateTime aux = Convert.ToDateTime(menu.fecha);
        bool deleted = false;
        String comando = "Delete from [dbo].[Restaurant] where dailyMenu = @aux";
        
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@aux", aux);
            cmd.ExecuteNonQuery();
            deleted = true;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error deleting the menu of the day " + menu.fecha, ex2.Message);
        }
        finally
        {
            if (conn != null)
                conn.Close();

        }
        return deleted;
    }
}
