using System;

public class ENMenu
{
	private float _price;

	public float price
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

    public string fecha     //will act as an id in the database
    {
        get { return _fecha; }
        set { _fecha = value; }
    }
    /// <summary>
    /// default constructor
    /// </summary>
	public ENMenu()
	{
        price = 0;
        main = System.String.Empty;
        dessert = System.String.Empty;
        appetizers = System.String.Empty;
        fecha = DateTime.Today.ToString("d");
    }

    /// <summary>
    /// copy constructor
    /// </summary>
    /// <param name="main"></param>
    /// <param name="dessert"></param>
    /// <param name="appetizers"></param>
    /// <param name="price"></param>
    /// <param name="fecha"></param>
    public ENMenu(string main, string dessert, string appetizers, float price, string fecha)
    {
        this.main = main;
        this.dessert = dessert;
        this.appetizers = appetizers;
        this.price = price;
        this.fecha = fecha;
    }

    /// <summary>
    /// function to show a menu
    /// </summary>
    /// <returns></returns>
    public bool showMenu()
    {
        CADMenu menu = new CADMenu();
        bool show = menu.showMenu(this);
        return show;
    }

    /// <summary>
    /// function to create a menu
    /// </summary>
    /// <returns>returns wether a menu was created or not </returns>
    public bool create()
    {
        CADMenu menu = new CADMenu();
        bool existe = menu.showMenu(this);

        if (existe)
        {
            return false;
        }
        else
        {
            bool creado = menu.create(this);
            return creado;
        }
    }

    /// <summary>
    /// function to update a menu
    /// </summary>
    /// <returns>returns wether a menu was updated or not </returns>
    public bool update()
    {
        CADMenu menu = new CADMenu();
        ENMenu nuevo = new ENMenu(this.main, this.dessert, this.appetizers, this.price, this.fecha);
        bool existe = menu.showMenu(this);
        if (existe)
        {
            this.main = nuevo.main;
            this.dessert = nuevo.dessert;
            this.appetizers = nuevo.appetizers;
            this.price = nuevo.price;
            this.fecha = nuevo.fecha;
            bool update = menu.update(this);
            return update;

        }
        else
        {
            return false;
        }
    }


    /// <summary>
    /// function to delete a menu
    /// </summary>
    /// <returns>returns wether a menu was deleted or not </returns>
    public bool delete()
    {
        CADMenu menu = new CADMenu();

        bool existe = menu.showMenu(this);
        if (existe)
        {
            bool borrado = menu.delete(this);
            return borrado;

        }
        else
        {
            return false;
        }
    }
}
