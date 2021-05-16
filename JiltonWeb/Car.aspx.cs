using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace JiltonWeb
{


    //POSIBLES MEJORAS: Cuando borro o updateo, si es uno no existente no dará problemas (como debe de ser) pero en lugar de
    // mostrar que ha ido bien, podria mostrar algo tipo, no hay coche que actualizar o borrar :))

    public partial class Car : System.Web.UI.Page
    {

        ENCar car = new ENCar("","","",0,"","");
        DataSet d = new DataSet();
              

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                d = car.listAllCars();
                GridView1.DataSource = d;
                GridView1.DataBind();
            }

            if (Session["id"] != null && Session["id"].ToString() == "admin")
            {
                panelAdmin.CssClass = "admin";
            }
            else
            {
                panelAdmin.CssClass = "novisibleAdmin";
            }

        }

        protected void CrearClick(object sender, EventArgs e)
        {
            if(LicensePlateData.Text != "" && BrandData.Text != "" && ModelData.Text != "" && PriceData.Text != "" && DescriptionData.Text != "" && imgURL.Text != "")
            {
                ENCar car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text, imgURL.Text);
                
                if (car.createCar() != null)
                {
                    output.Text = "Car created successfuly!";
                }
                else
                {
                    output.Text = "Car already created or couldn't create it";
                }

            }
            else
            {
                output.Text = "Not enough information to create the car, read the instructions again";
            }
        }

        protected void UpdateClick(object sender, EventArgs e)
        {
            if (LicensePlateData.Text != "" && (PriceData.Text != "" || DescriptionData.Text != ""))
            {

                ENCar car;

                if (DescriptionData.Text != "" && PriceData.Text != "")
                {
                    car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text, imgURL.Text);

                    if (car.updateDescriptionCar(DescriptionData.Text) != null  && car.updatePriceCar(int.Parse(PriceData.Text)) != null)
                    {
                        output.Text = "Car description and price updated successfuly!";
                    }
                    else
                    {
                        output.Text = "This car is not on the database";
                    }

                }
                else if (DescriptionData.Text != "")
                {
                    //This means we only are going to update the description, so we must put 0 on price because "" can int.Parse
                    car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, 0, DescriptionData.Text,imgURL.Text);

                    if (car.updateDescriptionCar(DescriptionData.Text) != null)
                    {
                        output.Text = "Car description updated successfuly!";
                    }
                    else
                    {
                        output.Text = "This car is not on the database";
                    }
                }
                else if (PriceData.Text != "")
                {
                    car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text, imgURL.Text);

                    if (car.updatePriceCar(int.Parse(PriceData.Text)) != null)
                    {
                        output.Text = "Car price updated successfuly!";
                    }
                    else
                    {
                        output.Text = "This car is not on the database";
                    }
                }
                else
                {
                    //Just in case
                    output.Text = "Unexpected error";
                }
            }
            else
            {
                output.Text = "Not enough information to create the car, read the instructions again";
            }
        }

        protected void DeleteClick(object sender, EventArgs e)
        {
            if (LicensePlateData.Text != "")
            {
                ENCar car;

                //I create this if statement because  price is not needed to delete so there would be empty string, and it cant int.Parse.
                if(PriceData.Text == "")
                {
                    car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, 0, DescriptionData.Text, imgURL.Text);
                }
                else
                {
                    car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text,imgURL.Text);
                }

                
                if (car.deleteCar() != null)
                {

                    output.Text = "Deleted car successfuly!";
                }
                else
                {
                    output.Text = car.LicensePlate + " couldn't be deleted";
                }

            }
            else
            {
                output.Text = "Not enough information to delete the car";
            }

        }

    }
}