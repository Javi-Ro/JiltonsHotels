using System;

public class ENMenu
{
	//the idea is to show a different menu depending on the day of the week (using an asp net library)

	private int _id;

	public int id
    {
        set { _id = value; }
        get { return _id; }
    }

	private double _price;

	public double price
    {
        set { _price = value; }
        get { return _price; }
    }

	private string _appetizers, _main, _dessert;

	public string appetizers
    {
        get { return _appetizers; }
        set { _appetizers = value; }
    }

    public string main
    {
        get { return _main; }
        set { _main = value; }
    }

    public string dessert
    {
        get { return _dessert; }
        set { _dessert = value; }
    }


	public ENMenu()
	{
        price = 0.0;
        id = 0;
        main = System.String.Empty;
        dessert = System.String.Empty;
        appetizers = System.String.Empty;
    }

    public bool showTodayMenu()
    {
        CADMenu menu = new CADMenu();
        bool show = menu.showTodayMenu(this);
        return show;
    }

    public bool showNextMenu()
    {
        CADMenu menu = new CADMenu();
        bool show = menu.showNextMenu(this);
        return show;
    }

    public bool showPreviousMenu()
    {
        CADMenu menu = new CADMenu();
        bool show = menu.showPreviousMenu(this);
        return show;
    }

}
