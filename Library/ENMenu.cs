using System;

public class ENMenu
{
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

    private string _fecha;

    public string fecha     //will act as an identificator in the database
    {
        get { return _fecha; }
        set { _fecha = value; }
    }

	public ENMenu()
	{
        price = 0.0;
        main = System.String.Empty;
        dessert = System.String.Empty;
        appetizers = System.String.Empty;
        fecha = DateTime.Today.ToString("d");
    }

    public ENMenu(string main, string dessert, string appetizers, float price, string fecha)
    {
        this.main = main;
        this.dessert = dessert;
        this.appetizers = appetizers;
        this.price = price;
        this.fecha = fecha;
    }

    public bool showMenu()
    {
        CADMenu menu = new CADMenu();
        bool show = menu.showMenu(this);
        return show;
    }

    public bool create()
    {
        CADMenu menu = new CADMenu();
        bool existe = menu.showMenu(this);

        if (existe)
        {
            //error label 
            return false;
        }
        else
        {
            bool creado = menu.create(this);
            return creado;
        }
    }
}
