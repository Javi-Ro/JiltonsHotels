using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace JiltonWeb
{
    public partial class Car : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CrearClick(object sender, EventArgs e)
        {
            if(LicensePlateData.Text != "" && BrandData.Text != "" && ModelData.Text != "" && PriceData.Text != "" && DescriptionData.Text != "")
            {
                ENCar car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text);

                if (car.createCar())
                {
                    output.Text = "Car created successfuly!";
                }
                else
                {
                    //FALTA COMPROBAR QUE NO EXISTA ANTES DE INCLUIRLO O LO HACE LA DB?
                    output.Text = car.LicensePlate + " " + car.Brand + " " + car.Model + " " + car.Description + " " + car.Price;
                    //output.Text = "Car already created or couldn't create it";
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

                //Esto no se si esta bien porque no deberia de cambiar nada mas que el precio o descripcion si estos no son nulos :))))))
                ENCar car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text);


                if (car.updateDescriptionCar(LicensePlateData.Text) || car.updatePriceCar(int.Parse(PriceData.Text)))
                {
                    output.Text = "Car updated successfuly!";
                }
                else
                {
                    output.Text = "This car is not on the database";
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

                ENCar car = new ENCar(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text);

                if (car.deleteCar())
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
                output.Text = "Not enough information to delete the user";
            }
        }
    }
}