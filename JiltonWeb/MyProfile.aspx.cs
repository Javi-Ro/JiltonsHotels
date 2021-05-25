using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace JiltonWeb
{
    public partial class MyProfile : System.Web.UI.Page
    {
        DataSet data = new DataSet();
        ENUser user = new ENUser();
        DataRow userRow;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }

            user.LoginData = Session["id"].ToString();
            data = user.GetUserInfo();
            userRow = data.Tables[0].Rows[0];

            incorrectPassword.Visible = false;

            if (Session["id"].ToString() == "admin")
            {
                MyInfoPanel.Visible = false;
                onlyAdmin.Visible = true;
            }
            else
            {
                NameText.Text = userRow.ItemArray.GetValue(2).ToString().ToUpper();
                IDText.Text = userRow.ItemArray.GetValue(0).ToString().ToUpper();
                EmailText.Text = userRow.ItemArray.GetValue(4).ToString();
                AgeText.Text = userRow.ItemArray.GetValue(3).ToString().Substring(0, 10);
                AddressText.Text = userRow.ItemArray.GetValue(5).ToString().ToUpper();
                MyInfoPanel.Visible = true;
                onlyAdmin.Visible = false;
            }
        }

        protected void DeleteAccount(object sender, EventArgs e)
        {

        }

        protected void UpdateAccount(object sender, EventArgs e)
        {
            if (CurrentPasswordText.Text == userRow.ItemArray.GetValue(1).ToString())
            {
                user.ID = IDText.Text;
                user.Address = AddressText.Text;
                user.Password = NewPasswordText.Text;
                user.Birthday = AgeText.Text;
                if (user.UpdateUser())
                {
                    Response.Redirect("MyProfile.aspx");
                }
                else
                {
                    Console.WriteLine("User could not be updated.");
                }
            }
            else
            {
                incorrectPassword.Visible = true;
            }
        }
    }
}