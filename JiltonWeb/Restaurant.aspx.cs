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
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            CultureInfo c = new CultureInfo("en-EN");
            titulo.Text = DateTime.Today.ToString("dddd",c).ToUpper() + "'S MENU";

            if (Session["id"] != null && Session["id"].ToString() == "admin")
            {
                backgroundR.CssClass = "AdminbackgroundR";
                AdminBlurryBackground.CssClass = "AdminBlurryBackground";
            }
            else
            {
                backgroundR.CssClass = "backgroundR";
                AdminBlurryBackground.CssClass = "noAdmin";
            }

            OnToday(sender, e);


            if(Context.Items["Success"] != null)
            {
                success.Visible = true;
                success.Text = "Operation completed succesfully";
            }
            else
            {
                success.Visible = false;
            }
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

        protected void OnNext(object sender, EventArgs e)
        {
            i++;
            copia = copia.AddDays(i);        
            titulo.Text = "MENU OF " + copia.ToString("dd'/'MM'/'yyyy");
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

        protected void OnToday(object sender, EventArgs e)
        {
            i = 0;
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

        protected void OnCreate(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;
            if(String.IsNullOrEmpty(DateTB.Text))
            {
                ErrorDate.Visible = true;
            }            

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

        protected void OnUpdate(object sender, EventArgs e)
        {
            success.Visible = false;
            Error.Visible = false;
            if (String.IsNullOrEmpty(DateTB.Text))
            {
                ErrorDate.Visible = true;
            }

            else
            {
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
                menu.fecha = DateTB.Text;
                string[] aux = new string[3];
                aux = menu.fecha.Split('/');
                string fechaFormateada = aux[2] + "/" + aux[1] + "/" + aux[0];
                menu.fecha = fechaFormateada;

                if (menu.delete())
                {
                    Context.Items.Add("Success",DateTB.Text);
                    Server.Transfer("Restaurant.aspx");
                }

                else
                {
                    Error.Visible = true;
                    Error.Text = "Could not delete menu";
                }
            }


        }

        protected void DeletePage(object sender, EventArgs e)
        {
            DateTB.Text = String.Empty;
            ErrorDate.Visible = false;
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
            DateTB.Text = String.Empty;
            priceTB.Text = String.Empty;
            appetizersTB.Text = String.Empty;
            mainTB.Text = String.Empty;
            dessertTB.Text = String.Empty;

            ErrorDate.Visible = false;
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
            DateTB.Text = String.Empty;
            priceTB.Text = String.Empty;
            appetizersTB.Text = String.Empty;
            mainTB.Text = String.Empty;
            dessertTB.Text = String.Empty;
            ErrorDate.Visible = false;
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