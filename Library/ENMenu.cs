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

	private float _price;

	public float price
    {
        set { _price = value; }
        get { return _price; }
    }

	private string _starters, _main, _dessert;

	public string starters
    {
        get { return _starters; }
        set { _starters = value; }
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
        starters = System.String.Empty;
    }

    public bool showMenu()
    {
        CADMenu menu = new CADMenu();
        bool show = menu.showToday(this);
        return show;
    }


}
