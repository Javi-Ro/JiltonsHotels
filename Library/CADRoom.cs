using System;


public class CADRoom
{
	private string constring;

    public CADRoom()
    {
        constring = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
    }

    public bool selectAll(ENRoom room)
    {
        //shows all the available rooms
    }

    public bool selectByType(ENRoom room)
    {
        //shows all the available rooms with the selected type
    }

    public bool selectByMinSize(ENRoom room)
    {
        //shows all the available rooms that have more than the size selected
    }

    public bool selectOrderByPriceUp(ENRoom room)
    {
        //shows all the available rooms in order from the most expensive to the least 
    }

    public bool selectOrderByPriceDown(ENRoom room)
    {
        //shows all the available rooms in order from the least expensive to the most 
    }

    public bool UpdateNotAvailable(ENRoom room)
    {
        //sets a room not available when the user books a room
    }

    public bool UpdateAvailable(ENRoom room)
    {
        //sets a room available when the booking ends or when the user cancels the booking
    }

}
