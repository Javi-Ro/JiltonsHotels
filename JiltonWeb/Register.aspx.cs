using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Context.Items["display"] != null && Context.Items["display"].ToString() == "inline-block")
                {
                    AlreadyExistslbl.CssClass = "showAlreadyExistslbl";
                }
                else
                {
                    if (AlreadyExistslbl != null)
                    {
                        AlreadyExistslbl.CssClass = "hideAlreadyExistslbl";
                    }
                }
            }
            catch (NullReferenceException)
            {
                AlreadyExistslbl.CssClass = "hideAlreadyExistslbl";
            }
        }

        protected void Register_User(object sender, EventArgs e)
        {
            string id = IDText.Text.Trim();
            string fullName = NameText.Text.Trim() + " " + SurnameText.Text.Trim();
            string email = MailText.Text.Trim();
            string birthday = AgeText.Text;
            string password = PasswordText.Text;
            string address = "";

            if (AddressText.Text.Trim() != "")
            {
                address += AddressText.Text.Trim() + ", ";
            }

            if (CityText.Text.Trim() != "")
            {
                address += CityText.Text.Trim() + ", ";
            }

            if (PCText.Text.Trim() != "")
            {
                address += PCText.Text.Trim() + ", ";
            }
            
            if (ProvinceText.Text.Trim() != "")
            {
                address += ProvinceText.Text.Trim();
            }

            ENUser user = new ENUser(id, fullName, email, birthday, address, password);

            if (!user.CreateUser())
            {
                Context.Items.Add("display", "inline-block");
                Server.Transfer("Register.aspx");
            }
            else
            {
                // POP-UP with success and redirect to login

                Context.Items.Add("email", email);
                Server.Transfer("Login.aspx");
            }
        }
    }
}