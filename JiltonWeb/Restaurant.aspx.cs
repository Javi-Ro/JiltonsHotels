using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Restaurant : System.Web.UI.Page
    {
        DateTime hoy = DateTime.Today.Date;
        DateTime copia = DateTime.Today.Date;
        protected void Page_Load(object sender, EventArgs e)
        {
            CultureInfo c = new CultureInfo("en-EN");
            titulo.Text = DateTime.Today.ToString("dddd", c).ToUpper() + "'S MENU";
        }
        protected void OnPrevious(object sender, EventArgs e)
        {
            copia.AddDays(-1);

            titulo.Text = "MENU OF " + copia.ToString();
            ENMenu menu = new ENMenu();
            menu.fecha = copia.ToString();

            if (menu.showMenu())
            {
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString();
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal2.Visible = false;
            }

        }

        protected void OnNext(object sender, EventArgs e)
        {
            copia.AddDays(1);        //se resetea

            titulo.Text = "MENU OF " + copia.ToString();
            ENMenu menu = new ENMenu();
            menu.fecha = copia.ToString();

            if (menu.showMenu())
            {
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString();
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal2.Visible = false;
            }
        }

        protected void OnToday(object sender, EventArgs e)
        {
            copia = hoy;        //se resetea

            ENMenu menu = new ENMenu();

            menu.fecha = DateTime.Today.Date.ToString();

            if (menu.showMenu())
            {
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString();
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal2.Visible = false;
            }

        }

        protected void OnUpdate(object sender, EventArgs e)
        {
            ENMenu menu = new ENMenu();
            menu.fecha = DateTB.ToString();     //espero que funcione


        }

        protected void OnInsert(object sender, EventArgs e)
        {

        }

        protected void OnDelete(object sender, EventArgs e)
        { 
        
        }
    }
}