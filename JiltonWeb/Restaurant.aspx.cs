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
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            CultureInfo c = new CultureInfo("en-EN");
            titulo.Text = DateTime.Today.ToString("dddd",c).ToUpper() + "'S MENU";
            OnToday(sender, e);
        }
        protected void OnPrevious(object sender, EventArgs e)
        {
            i--;
            copia = copia.AddDays(i);
            titulo.Text = "MENU OF " + copia.ToString("dd'/'MM'/'yyyy");
            ENMenu menu = new ENMenu();
            menu.fecha = copia.ToString("yyyy'/'MM'/'dd");

            if (menu.showMenu())
            {
                APPETIZERS.Text = i.ToString();
                MAINS.Text = copia.ToString("dd'/'MM'/'yyyy");
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString() + "€";
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal3.Visible = false;
            }

        }

        protected void OnNext(object sender, EventArgs e)
        {
            i++;
            copia = copia.AddDays(i);        
            titulo.Text = "MENU OF " + copia.ToString("dd'/'MM'/'yyyy");
            ENMenu menu = new ENMenu();
            menu.fecha = copia.ToString("yyyy'/'MM'/'dd");

            if (menu.showMenu())
            {
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString() + "€";
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal3.Visible = false;
            }
        }

        protected void OnToday(object sender, EventArgs e)
        {
            i = 0;
            copia = hoy;
            ENMenu menu = new ENMenu();

            menu.fecha = DateTime.Today.Date.ToString("yyyy'/'MM'/'dd");

            if (menu.showMenu())
            {
                APPETIZERS.Text = menu.appetizers;
                MAINS.Text = menu.main;
                DESSERTS.Text = menu.dessert;
                PRICE.Text = menu.price.ToString() + "€";
            }
            else
            {
                titulo.Text = "Menu not available";
                meal1.Visible = false;
                meal2.Visible = false;
                meal3.Visible = false;
            }

        }

        protected void OnCreate(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;
            if(String.IsNullOrEmpty(DateTB.Text))
            {
                ErrorDate.Visible = true;
            }
            if (String.IsNullOrEmpty(appetizersTB.Text))
            {
                ErrorApp.Visible = true;
            }
            if (String.IsNullOrEmpty(mainTB.Text))
            {
                ErrorMain.Visible = true;
            }
            if (String.IsNullOrEmpty(dessertTB.Text))
            {
                ErrorDessert.Visible = true;
            }
            if (String.IsNullOrEmpty(priceTB.Text))
            {
                ErrorPrice.Visible = true;
            }
            
            if(!String.IsNullOrEmpty(DateTB.Text) && !String.IsNullOrEmpty(appetizersTB.Text) && !String.IsNullOrEmpty(mainTB.Text) && !String.IsNullOrEmpty(dessertTB.Text) && !String.IsNullOrEmpty(priceTB.Text)){
                string[] aux = new string[3];
                aux = DateTB.Text.Split('/');
                string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
                ENMenu menu = new ENMenu(mainTB.Text, dessertTB.Text, appetizersTB.Text, float.Parse(priceTB.Text), fechaFormateada);
                
                if (menu.create())
                {
                    success.Text = "Menu of day " + DateTB.Text + " inserted succesfully ";
                    success.Visible = true;
                }

                else
                {
                    Error.Visible = true;
                    Error.Text = "Could not insert menu ";
                }
            }

        }

        protected void OnUpdate(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;
            if (String.IsNullOrEmpty(DateTB.Text))
            {
                ErrorDate.Visible = true;
            }

            if (!String.IsNullOrEmpty(DateTB.Text))
            {
                string[] aux = new string[3];
                aux = DateTB.Text.Split('/');
                string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
                ENMenu menu = new ENMenu(mainTB.Text, dessertTB.Text, appetizersTB.Text, float.Parse(priceTB.Text), fechaFormateada);

                if (menu.update() && (!String.IsNullOrEmpty(appetizersTB.Text) || !String.IsNullOrEmpty(mainTB.Text) && !String.IsNullOrEmpty(dessertTB.Text) || !String.IsNullOrEmpty(priceTB.Text)))      //at least one field must be known
                {
                    success.Text = "Menu of day " + DateTB.Text + " updated succesfully ";
                    success.Visible = true;
                }

                else
                {
                    Error.Visible = true;
                    Error.Text = "Could not update menu ";
                }
            }
        }

        protected void OnDelete(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;
            ENMenu menu = new ENMenu();
            if (String.IsNullOrEmpty(DateTB.Text))
            {
                ErrorDate.Visible = true;
            }
            else
            {
                if (menu.delete())
                {
                    success.Visible = true;
                    success.Text = menu.dessert;
                    success.Text = "Menu of day " + DateTB.Text + " deleted succesfully ";
                    
                }

                else
                {
                    Error.Visible = true;
                    Error.Text = menu.dessert; /*"Could not delete menu ";*/
                }
            }


        }

        protected void DeletePage(object sender, EventArgs e)
        {
            ErrorDate.Visible = false;
            ErrorDessert.Visible = false;
            ErrorApp.Visible = false;
            ErrorPrice.Visible = false;
            ErrorMain.Visible = false;
            mainLabel.Visible = false;
            mainTB.Visible = false;
            appetizersTB.Visible = false;
            appetizersLabel.Visible = false;
            dessertTB.Visible = false;
            dessertLabel.Visible = false;
            priceLabel.Visible = false;
            priceTB.Visible = false;
            Create.Visible = false;
            Delete.Visible = true;
            Update.Visible = false;
            success.Visible = false;
            Error.Visible = false;
        }

        protected void UpdatePage(object sender, EventArgs e)
        {
            ErrorDate.Visible = false;
            ErrorDessert.Visible = false;
            ErrorApp.Visible = false;
            ErrorPrice.Visible = false;
            ErrorMain.Visible = false;
            mainLabel.Visible = true;
            mainTB.Visible = true;
            appetizersTB.Visible = true;
            appetizersLabel.Visible = true;
            dessertTB.Visible = true;
            dessertLabel.Visible = true;
            priceLabel.Visible = true;
            priceTB.Visible = true;
            Create.Visible = false;
            Update.Visible = true;
            Delete.Visible = false;
            success.Visible = false;
            Error.Visible = false;
        }

        protected void InsertPage(object sender, EventArgs e)
        {
            ErrorDate.Visible = false;
            ErrorDessert.Visible = false;
            ErrorApp.Visible = false;
            ErrorPrice.Visible = false;
            ErrorMain.Visible = false;
            Create.Visible = true;
            Update.Visible = false;
            Delete.Visible = false;
            mainLabel.Visible = true;
            mainTB.Visible = true;
            appetizersTB.Visible = true;
            appetizersLabel.Visible = true;
            dessertTB.Visible = true;
            dessertLabel.Visible = true;
            priceLabel.Visible = true;
            priceTB.Visible = true;
            success.Visible = false;
            Error.Visible = false;
        }
    }
}