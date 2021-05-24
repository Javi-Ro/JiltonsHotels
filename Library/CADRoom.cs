using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;


public class CADRoom
{
	private string constring;

    public CADRoom()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
    }

    public DataSet showAll(ENRoom room)
    {
        DataSet virtualSet = new DataSet();
        try
        {
            SqlConnection conn = new SqlConnection(constring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from room", conn);
            adapter.Fill(virtualSet, "room");
            return virtualSet;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine(ex2.Message + "Error showing all the rooms");
        }
        return virtualSet;
    }

    public bool create(ENRoom room)
    {
        return true;
    }

    public bool delete(ENRoom room)
    {
        return true;
    }

    public bool update(ENRoom room)
    {
        return true;
    }

    public bool searchRoom(ENRoom room)
    {
        return true;
    }


    //public DataSet selectByType(ENRoom room)
    //{
    //    //shows all the available rooms with the selected type
    //    return true;
    //}

    //public DataSet selectByMinSize(ENRoom room)
    //{
    //    //shows all the available rooms that have more than the size selected
    //    return true;
    //}

    public bool selectOrderByPriceUp(ENRoom room)
    {
        //shows all the available rooms in order from the most expensive to the least 
        return true;
    }

    public bool selectOrderByPriceDown(ENRoom room)
    {
        //shows all the available rooms in order from the least expensive to the most 

        return true;
    }

    public bool UpdateNotAvailable(ENRoom room)
    {
        //sets a room not available when the user books a room
        return true;
    }

    public bool UpdateAvailable(ENRoom room)
    {
        //sets a room available when the booking ends or when the user cancels the booking
        return true;
    }


}
