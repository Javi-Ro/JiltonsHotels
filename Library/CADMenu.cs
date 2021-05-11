using System;
using System.Configuration;

public class CADMenu
{
	private string constring;

	public CADMenu()
	{
		constring = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
	}

	public bool showTodayMenu(ENMenu menu)
    {

	}

	public bool showNextMenu(ENMenu menu)
	{
		//shows today's menu based on the day of the week using an asp net library
	}

	public bool showPreviousMenu(ENMenu menu)
	{
		//shows today's menu based on the day of the week using an asp net library
	}
}
