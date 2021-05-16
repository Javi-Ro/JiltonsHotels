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
        string comando = "SELECT * FROM restaurant WHERE dailyMenu = CONVERT(varchar, '" + menu.fecha + "', 111)";
        
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

        String comando = "INSERT INTO [dbo].[Restaurant]([dailyMenu],[appetizers],[mains], [desserts],[price]) VALUES ('" + menu.fecha + "', '" + menu.appetizers + "', '" + menu.main + "', '" + menu.dessert + "', " + menu.price + ")";
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

    public bool update(ENMenu menu)
    {
        SqlConnection conn = null;
        String comando = "Update [dbo].[Restaurant] SET";
        bool coma = false;
        if (!String.IsNullOrEmpty(menu.appetizers))
        {
            comando = comando + " appetizers='" + menu.appetizers +"'";
        }
        if(!String.IsNullOrEmpty(menu.appetizers) && (!String.IsNullOrEmpty(menu.main) || !String.IsNullOrEmpty(menu.dessert) || menu.price != 0)){
            comando = comando + ",";
            coma = true;
        }

        if (!String.IsNullOrEmpty(menu.main))
        {
            comando = comando + " mains='" + menu.main + "'";
            coma = false;
        }
        if (!coma && (!String.IsNullOrEmpty(menu.appetizers) || !String.IsNullOrEmpty(menu.main)) && (!String.IsNullOrEmpty(menu.dessert) || menu.price != 0))
        {
            comando = comando + ",";
            coma = true;
        }
        
        if (!String.IsNullOrEmpty(menu.dessert))
        {
            comando = comando + " desserts='" + menu.dessert + "'";
            coma = false;
        }

        if (!coma && (!String.IsNullOrEmpty(menu.appetizers) || !String.IsNullOrEmpty(menu.main) || !String.IsNullOrEmpty(menu.dessert)) && menu.price != 0)
        {
            comando = comando + ",";
            coma = true;
        }

        if (menu.price != 0)
        {
            comando = comando + " price=" + menu.price.ToString();
        }

        comando = comando + " WHERE dailyMenu = CONVERT(varchar, '" + menu.fecha +"', 111)";
        menu.dessert = comando;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.ExecuteNonQuery();      //devuelve la cantidad de registros afectados
            return true;
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

    public bool delete(ENMenu menu)
    {
        
        SqlConnection conn = null;
        

        String comando = "Delete from [dbo].[Restaurant] where dailyMenu = CONVERT(varchar, '" + menu.fecha + "', 111)";
        menu.dessert = comando;
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.ExecuteNonQuery();
            return true;
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
}
