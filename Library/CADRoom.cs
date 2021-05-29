﻿using Library;
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
            Console.WriteLine("Error showing all the rooms: " + ex2.Message);
        }
        return virtualSet;
    }

    public bool Insert(ENRoom room)
    {

        try
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "INSERT INTO[dbo].[room]([title],[description],[price],[type],[adultBed],[childBed],[imgURL],[ratings]) VALUES('" + room.title
                + "', '" + room.description + "', " + room.price + ", '" + room.type + "', " + room.adultBed + ", " + room.childBed + ", '" + room.imageLink +  "', " + room.ratings +")", c);
            adapter.Fill(virtualSet, "room");
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

    public bool delete(ENRoom room)
    {
        try
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "DELETE from room where id = " + room.id, c);
            adapter.Fill(virtualSet, "room");
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

    public bool update(ENRoom room)
    {
        try
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [dbo].[room] " +
                "SET title= '" + room.title + "', description='" + room.description + "', price=" + room.price
                + ", type= '" + room.type + "', adultBed=" + room.adultBed + ", childBed=" + room.childBed + ", ratings=" + room.ratings
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
