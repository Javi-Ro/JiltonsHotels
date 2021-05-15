using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Context.Items["email"] != null)
                {
                    DataLoginText.Text = Context.Items["email"].ToString();
                }

                if (Context.Items["displayRegister"] != null && Context.Items["displayRegister"].ToString() == "inline-block")
                {
                    NoExistslbl.CssClass = "showNoExistslbl";
                }
                else
                {
                    if (NoExistslbl != null)
                    {
                        NoExistslbl.CssClass = "hideNoExistslbl";
                    }
                }

                if (Context.Items["displayPassword"] != null && Context.Items["displayPassword"].ToString() == "inline-block")
                {
                    WrongPsswd.CssClass = "showWrongPsswd";
                }
                else
                {
                    if (WrongPsswd != null)
                    {
                        WrongPsswd.CssClass = "hideWrongPsswd";
                    }
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        protected void Login_User(object sender, EventArgs e)
        {
            string dataLogin = DataLoginText.Text.Trim();
            string password = PasswordTextLogin.Text;

            ENUser user = new ENUser(dataLogin, password);

            switch (user.LoginUser())
            {
                case 0: // No error
                    Session["id"] = user.LoginData;
                    Server.Transfer("MainPage.aspx");
                    break;
                case 1: // Data doesn't exist
                    Context.Items.Add("displayRegister", "inline-block");
                    Server.Transfer("Login.aspx");
                    break;
                case 2: // Data exists but password is incorrect
                    Context.Items.Add("displayPassword", "inline-block");
                    Server.Transfer("Login.aspx");
                    break;
                default:
                    Server.Transfer("MainPage.aspx");
                    break;
            }

            return;
        }
    }
}