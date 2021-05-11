using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Restaurant: System.Web.UI.Page
    {
        DateTime hoy = DateTime.Today;
        protected void Page_Load(object sender, EventArgs e)
        {
            CultureInfo c = new CultureInfo("en-EN");
            titulo.Text = DateTime.Today.ToString("dddd",c).ToUpper() + "'S MENU";            
        }

        //protected void OnPrevious(object sender, EventArgs e)
        //{
        //    ENMenu menu = new ENMenu();

        //    int day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;

        //    if (day - 1 <= 0)
        //    {
        //        day = 7;
        //    }
        //    else
        //    {
        //        day--;
        //    }

        //    menu.id = day;

        //    if (menu.showPreviousMenu())
        //    {
        //        APPETIZERS.Text = menu.appetizers;
        //        MAINS.Text = menu.main;
        //        DESSERTS.Text = menu.dessert;
        //    }
        //    else
        //    {
        //        titulo.Text = "Menu not available";
        //    }

        //}

        //protected void OnNext(object sender, EventArgs e)
        //{
        //    ENMenu menu = new ENMenu();

        //    int day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;

        //    if (day + 1 > 7)
        //    {
        //        day = 7;
        //    }
        //    else
        //    {
        //        day++;
        //    }

        //    menu.id = day;

        //    if (menu.showNextMenu())
        //    {
        //        APPETIZERS.Text = menu.appetizers;
        //        MAINS.Text = menu.main;
        //        DESSERTS.Text = menu.dessert;
        //    }
        //    else
        //    {
        //        titulo.Text = "Menu not available";
        //    }

        //}

        //protected void OnToday(object sender, EventArgs e)
        //{
        //    ENMenu menu = new ENMenu();

        //    int day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
        //    menu.id = day;

        //    if (menu.showTodayMenu())
        //    {
        //        APPETIZERS.Text = menu.appetizers;
        //        MAINS.Text = menu.main;
        //        DESSERTS.Text = menu.dessert;
        //    }
        //    else
        //    {
        //        titulo.Text = "Menu not available";
        //    }

        //}
    }
}