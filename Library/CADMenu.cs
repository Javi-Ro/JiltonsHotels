using System;
using System.Configuration;

public class CADMenu
{
	private string constring;

	public CADMenu()
	{
		constring = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
	}

	public bool showToday(ENMenu menu)
    {
		//shows today's menu based on the day of the week using an asp net library
    }

}
