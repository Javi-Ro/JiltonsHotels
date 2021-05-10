using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JiltonWeb
{
    public partial class JiltonMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EntryCalendar.StartDate = DateTime.Now;
                DepartureCalendar.StartDate = DateTime.Now;
                ChildOptions.Items.Add(new ListItem("0", "0"));
                ChildOptions.Items.Add(new ListItem("1", "1"));
                ChildOptions.Items.Add(new ListItem("2", "2"));
                ChildOptions.Items.Add(new ListItem("3", "3"));
                AdultOptions.Items.Add(new ListItem("0", "0"));
                AdultOptions.Items.Add(new ListItem("1", "1"));
                AdultOptions.Items.Add(new ListItem("2", "2"));
            }
        }

        protected void MainMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Restaurant":
                    Response.Redirect("Restaurant.aspx");
                    return;
                case "Spa&Gym":
                    Response.Redirect("SpaGym.aspx");
                    return;
                case "CarLeasing":
                    Response.Redirect("Car.aspx");
                    return;
                case "Packages":
                    Response.Redirect("Packages.aspx");
                    return;
                case "Staff":
                    Response.Redirect("Staff.aspx");
                    return;
                case "AboutUs":
                    Response.Redirect("About.aspx");
                    return;
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void BookButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Room.aspx");
        }
    }
}