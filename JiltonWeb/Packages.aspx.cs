using Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Packages : System.Web.UI.Page
    {
  
            ENPackage en = new ENPackage();
            DataSet d = new DataSet();
          
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                d = en.listAllPackages();
                GridView1.DataSource = d;
                GridView1.DataBind();

            }
        }
        protected void CrearClick(object sender, EventArgs e)
        {
            if (IdData.Text != "" && NameDate.Text != "" && PriceData.Text != "" && DescriptionData.Text != "")
            {
                ENPackage pack = new ENPackage(int.Parse(IdData.Text), NameDate.Text, DescriptionData.Text, int.Parse(PriceData.Text));

                if (pack.createPackage() != null)
                {
                    output.Text = "Pack created successfuly!";
                }
                else
                {
                    output.Text = "Pack already created or couldn't create it";
                }

            }
            else
            {
                output.Text = "Not enough information to create the pack, read the instructions again";
            }
        }

        protected void UpdateClick(object sender, EventArgs e)
        {
            if (IdData.Text != "" && (PriceData.Text != "" || DescriptionData.Text != ""))
            {

                ENPackage pack;

                if (DescriptionData.Text != "" && PriceData.Text != "")
                {
                    pack = new ENPackage(int.Parse(IdData.Text), NameDate.Text, DescriptionData.Text, int.Parse(PriceData.Text));

                    if (pack.updateDescPackage()!= null && pack.updatePricePackage() != null)
                    {
                        output.Text = "Pack description and price updated successfuly!";
                    }
                    else
                    {
                        output.Text = "This pack is not on the database";
                    }

                }
                else if (DescriptionData.Text != "")
                {
                    //This means we only are going to update the description, so we must put 0 on price because "" can int.Parse
                    pack = new ENPackage(int.Parse(IdData.Text), NameDate.Text, DescriptionData.Text, 0);

                    if (pack.updateDescPackage() != null)
                    {
                        output.Text = "Pack description updated successfuly!";
                    }
                    else
                    {
                        output.Text = "This pàck is not on the database";
                    }
                }
                else if (PriceData.Text != "")
                {
                    pack = new ENPackage(int.Parse(IdData.Text), NameDate.Text, DescriptionData.Text, int.Parse(PriceData.Text));

                    if (pack.updatePricePackage() != null)
                    {
                        output.Text = "Pack price updated successfuly!";
                    }
                    else
                    {
                        output.Text = "This pack is not on the database";
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
            /*if (IdData.Text != "")
            {
                ENPackage pack;

                //I create this if statement because  price is not needed to delete so there would be empty string, and it cant int.Parse.
                if (PriceData.Text == "")
                {
                    pack = new ENPackage(int.Parse(IdData.Text), NameDate.Text, DescriptionData.Text, DescriptionData.Text);
                }
                else
                {
                    pack = new ENPackage(LicensePlateData.Text, BrandData.Text, ModelData.Text, int.Parse(PriceData.Text), DescriptionData.Text);
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
            }*/

        }
    }
}