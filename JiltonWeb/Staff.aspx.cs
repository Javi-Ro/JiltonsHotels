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
    public partial class Staff : System.Web.UI.Page
    {

        ENStaff staff = new ENStaff();
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                d = staff.listAllStaff();
                GridView2.DataSource = d;
                GridView2.DataBind();
            }


        }

        protected void CrearClick(object sender, EventArgs e)
        {
            if (EmailData.Text != "" && NameData.Text != "" && TypeData.Text != "" && DescriptionData.Text != "" && imgURL.Text != "")
            {
                ENStaff staff = new ENStaff(EmailData.Text,NameData.Text,TypeData.Text,DescriptionData.Text, imgURL.Text);

                if (staff.createStaff() != null)
                {
                    output.Text = "Staff created successfuly!";
                }
                else
                {
                    output.Text = "Staff already created or couldn't create it";
                }

            }
            else
            {
                output.Text = "Not enough information to create the staff member, read the instructions again";
            }
        }

        protected void UpdateClick(object sender, EventArgs e)
        {
            if (EmailData.Text != "" && DescriptionData.Text != "")
            {
                //As the other fields wont be updated we can put it as empty strings here
                ENStaff staff = new ENStaff(EmailData.Text, "", "", DescriptionData.Text,imgURL.Text);

                if (staff.updateDescriptionStaff(DescriptionData.Text) != null)
                {
                    output.Text = "Staff description updated successfuly!";
                }
                else
                {
                    output.Text = "Staff description couldn't be updated ";
                }

            }
            else
            {
                output.Text = "Not enough information to update the staff member, read the instructions again";
            }
        }

        protected void DeleteClick(object sender, EventArgs e)
        {
            if (EmailData.Text != "")
            {
                ENStaff staff = new ENStaff(EmailData.Text, "", "", "","");

                if (staff.deleteStaff() != null)
                {
                    output.Text = "Staff deleted successfuly!";
                }
                else
                {
                    output.Text = "Staff couldn't be deleted ";
                }

            }
            else
            {
                output.Text = "Not enough information to delete the staff member, read the instructions again";
            }
        }
    }
}