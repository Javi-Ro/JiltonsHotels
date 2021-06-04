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
        DateTime hoy = new DateTime();
        DateTime copia = new DateTime();
        CultureInfo c = new CultureInfo("en-EN");

        /// <summary>
        /// Page load where the date is checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
            titulo.Text = DateTime.Today.ToString("dddd", c).ToUpper() + "'S MENU";


            if (Session["id"] != null && Session["id"].ToString() == "admin")       //panel to access administrator view
            {
                backgroundR.CssClass = "AdminbackgroundR";
                AdminBlurryBackground.CssClass = "AdminBlurryBackground";
            }
            else
            {
                backgroundR.CssClass = "backgroundR";
                AdminBlurryBackground.CssClass = "noAdmin";
            }


            if (!Page.IsPostBack)           
            {
                Session["dayIter"] = 0;
                hoy = DateTime.Today.Date;
                copia = DateTime.Today.Date;
            }

            if (Session["dayIter"] != null)
            {
                if (Int32.Parse(Session["dayIter"].ToString()) == 0)    //reset 
                {
                    OnToday(sender, e);
                }
            }

            if (Context.Items["Success"] != null)
            {
                success.Visible = true;
                success.Text = "Operation completed succesfully";
            }
            else
            {
                success.Visible = false;
            }
        }

        /// <summary>
        /// Handler to show the previous day menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void OnPrevious(object sender, EventArgs e)
        {

            Session["dayIter"] = Int32.Parse(Session["dayIter"].ToString()) - 1;    //substract one day with AddDays function
            int i = Int32.Parse(Session["dayIter"].ToString());
            copia = DateTime.Now.AddDays(i);
            titulo.Text = copia.ToString("dddd", c).ToUpper() + "'S MENU";
            ENMenu menu = new ENMenu();
            menu.fecha = copia.ToString("yyyy'/'MM'/'dd");

            if (menu.showMenu())
            {
                meal1.Visible = true;
                meal2.Visible = true;
                meal3.Visible = true;
                APPETIZERS.Visible = true;
                MAINS.Visible = true;
                DESSERTS.Visible = true;
                PRICE.Visible = true;
                imagen.Visible = false;
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString() + "€";
                EndMessage.Text = "Feel free to ask for our superb wine selection";
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal3.Visible = false;
                APPETIZERS.Visible = false;
                MAINS.Visible = false;
                DESSERTS.Visible = false;
                PRICE.Visible = false;
                imagen.Visible = true;
                EndMessage.Text = "Our team is working on this menu. Thank you for your consideration. ";
            }


        }

        /// <summary>
        /// handler to show next day's menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnNext(object sender, EventArgs e)
        {
            Session["dayIter"] = Int32.Parse(Session["dayIter"].ToString()) + 1;
            int i = Int32.Parse(Session["dayIter"].ToString());
            copia = DateTime.Now.AddDays(i);
            titulo.Text = copia.ToString("dddd", c).ToUpper() + "'S MENU";
            //titulo.Text = "MENU OF " + copia.ToString("dd'/'MM'/'yyyy");
            ENMenu menu = new ENMenu();
            menu.fecha = copia.ToString("yyyy'/'MM'/'dd");

            if (menu.showMenu())
            {
                meal1.Visible = true;
                meal2.Visible = true;
                meal3.Visible = true;
                APPETIZERS.Visible = true;
                MAINS.Visible = true;
                DESSERTS.Visible = true;
                PRICE.Visible = true;
                imagen.Visible = false;
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString() + "€";
                EndMessage.Text = "Feel free to ask for our superb wine selection";
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal3.Visible = false;
                APPETIZERS.Visible = false;
                MAINS.Visible = false;
                DESSERTS.Visible = false;
                PRICE.Visible = false;
                imagen.Visible = true;
                EndMessage.Text = "Our team is working on this menu. Thank you for your consideration. ";
            }

        }

        /// <summary>
        /// handler to show today's menu, which is the default menu shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnToday(object sender, EventArgs e)
        {
            Session["dayIter"] = 0;
            int i = Int32.Parse(Session["dayIter"].ToString());
            copia = hoy;
            ENMenu menu = new ENMenu();

            menu.fecha = DateTime.Today.Date.ToString("yyyy'/'MM'/'dd");

            if (menu.showMenu())
            {
                meal1.Visible = true;
                meal2.Visible = true;
                meal3.Visible = true;
                APPETIZERS.Visible = true;
                MAINS.Visible = true;
                DESSERTS.Visible = true;
                PRICE.Visible = true;
                imagen.Visible = false;
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString() + "€";
                EndMessage.Text = "Feel free to ask for our superb wine selection";
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal3.Visible = false;
                APPETIZERS.Visible = false;
                MAINS.Visible = false;
                DESSERTS.Visible = false;
                PRICE.Visible = false;
                imagen.Visible = true;
                EndMessage.Text = "Our team is working on this menu. Thank you for your consideration. ";
            }

        }

        /// <summary>
        /// Handler to create menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnCreate(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;

            float precio = float.Parse(priceTB.Text);
            string[] aux = new string[3];
            aux = DateTB.Text.Split('/');
            string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
            ENMenu menu = new ENMenu(mainTB.Text, dessertTB.Text, appetizersTB.Text, precio, fechaFormateada);

            if (menu.create())
            {
                Context.Items.Add("Success", DateTB.Text);
                Server.Transfer("Restaurant.aspx");
            }

            else
            {
                Error.Visible = true;
                Error.Text = "Could not insert menu ";
            }

        }

        /// <summary>
        /// handler to update menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnUpdate(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;

            string[] aux = new string[3];
            aux = DateTB.Text.Split('/');
            string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
            float price = float.Parse(priceTB.Text);
            ENMenu menu = new ENMenu(mainTB.Text, dessertTB.Text, appetizersTB.Text, price, fechaFormateada);


            if (menu.update())
            {
                Context.Items.Add("Success", DateTB.Text);
                Server.Transfer("Restaurant.aspx");
            }
            else
            {
                Error.Visible = true;
                Error.Text = "Could not update menu";
            }
            
        }

        /// <summary>
        /// handler to delete menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDelete(object sender, EventArgs e)
        {
            
            success.Visible = false;
            Error.Visible = false;
            ENMenu menu = new ENMenu();

            menu.fecha = DateTB2.Text;
            string[] aux = new string[3];
            aux = menu.fecha.Split('/');
            string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
            menu.fecha = fechaFormateada;

            if (menu.delete())
            {
                Context.Items.Add("Success",DateTB2.Text);
                Server.Transfer("Restaurant.aspx");
            }

            else
            {
                Error.Visible = true;
                Error.Text = "Could not delete menu";
            }
    }

        /// <summary>
        /// handler for showing the delete menu for administrators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeletePage(object sender, EventArgs e)
        {
            DateTB.Text = String.Empty;
            RestaurantInsertOrUpdate.CssClass = "invisible";
            DeletePanel.CssClass = "adminTextBoxes";
            success.Visible = false;
            Error.Visible = false;
        }

        /// <summary>
        /// handler for showing the update menu for administrators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdatePage(object sender, EventArgs e)
        {
            DateTB.Text = String.Empty;
            priceTB.Text = String.Empty;
            appetizersTB.Text = String.Empty;
            mainTB.Text = String.Empty;
            dessertTB.Text = String.Empty;
            Create.Visible = false;
            Update.Visible = true;
            //Delete.Visible = false;
            RestaurantInsertOrUpdate.CssClass = "adminTextBoxes";
            DeletePanel.CssClass = "invisible";
            success.Visible = false;
            Error.Visible = false;
        }

        /// <summary>
        /// handler for showing the insert menu for administrators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void InsertPage(object sender, EventArgs e)
        {
            DateTB.Text = String.Empty;
            priceTB.Text = String.Empty;
            appetizersTB.Text = String.Empty;
            mainTB.Text = String.Empty;
            dessertTB.Text = String.Empty;
            Create.Visible = true;
            Update.Visible = false;
            RestaurantInsertOrUpdate.CssClass = "adminTextBoxes";
            DeletePanel.CssClass = "invisible";
            success.Visible = false;
            Error.Visible = false;
        }
    }
}