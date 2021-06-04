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

    /// <summary>
    /// function to show all rooms
    /// </summary>
    /// <param name="room"></param>
    /// <returns>DataSet with all the rooms </returns>
    public DataSet showAll(ENRoom room)
    {
        DataSet virtualSet = new DataSet();
        try
        {
            SqlConnection conn = new SqlConnection(constring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from room where bookingNumber is null", conn);
            adapter.Fill(virtualSet, "room");
            return virtualSet;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error showing all the rooms: " + ex2.Message);
        }
        return virtualSet;
    }

    /// <summary>
    /// function to insert 
    /// </summary>
    /// <param name="room"></param>
    /// <returns>wether it was inserted or not</returns>
    public bool Insert(ENRoom room)
    {

        try
        {
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            DataSet virtualSet = new DataSet();
            string sql = "INSERT INTO[dbo].[room]([title],[description],[price],[type],[adultBed],[childBed],[imgURL]) VALUES('" + room.title
                + "', '" + room.description + "', " + room.price + ", '" + room.type + "', " + room.adultBed + ", " + room.childBed + ", '" + room.imageLink + "')";
            SqlDataAdapter adapter = new SqlDataAdapter("select * from room", c);
            adapter.Fill(virtualSet, "room");           //disconnected environment 
            adapter.InsertCommand = new SqlCommand(sql, c);
            adapter.InsertCommand.ExecuteNonQuery();
        
            return true;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error inserting room: {0},{1}", room.id, ex2.Message);
        }
        return false;
    }

    /// <summary>
    /// function to delete a room
    /// </summary>
    /// <param name="room"></param>
    /// <returns>wether if was deleted or not </returns>
    public bool delete(ENRoom room)
    {
        try
        {
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            DataSet virtualSet = new DataSet();
            string sql = "DELETE from room where id = " + room.id;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from room", c);
            adapter.Fill(virtualSet, "room");
            adapter.DeleteCommand = new SqlCommand(sql, c);
            adapter.DeleteCommand.ExecuteNonQuery();

            return true;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error deleting room: {0}" + ex2.Message, room.id);
        }
        return false;
    }

    /// <summary>
    /// function to update the room
    /// </summary>
    /// <param name="room"></param>
    /// <returns>wether if was updated or not </returns>
    public bool update(ENRoom room)
    {
        try
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[room] " +
                "SET title= '" + room.title + "', description='" + room.description + "', price=" + room.price
                + ", type= '" + room.type + "', adultBed=" + room.adultBed + ", childBed=" + room.childBed
                + ", imgURL='" + room.imageLink + "' WHERE id=" + room.id, c);

            adapter.Fill(virtualSet, "room");
            return true;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Error updating the room: " + ex2.Message);
        }
        return false;
    }

    /// <summary>
    /// function  to search an specific room to know if it is in the database or not 
    /// </summary>
    /// <param name="room"> room wich id will be searched </param>
    /// <returns> true if it is found; false otherwise </returns>
    public bool searchRoom(ENRoom room)
    {
        try
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from room where id=" + room.id, c);
            adapter.Fill(virtualSet, "room");
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine("Room {0} was not found: " + e.Message, room.id);
            return false;
        }
    }

}
