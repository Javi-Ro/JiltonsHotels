﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Threading;
using Library;

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

            if (Session["id"] != null)
            {
                RegisterContainer.Visible = false;
                UserContainer.Visible = true;
                RegisterButton.CssClass = "hideRegisterLogin";
                LoginButton.CssClass = "hideRegisterLogin";
                dropdownUser.CssClass = "dropdownUser";
            }
            else
            {
                RegisterContainer.Visible = true;
                UserContainer.Visible = false;
                RegisterButton.CssClass = "Register";
                LoginButton.CssClass = "Register";
                dropdownUser.CssClass = "hideDropdownUser";
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
            ENBooking booking = new ENBooking();
            IntervalDate dates = new IntervalDate(new Date(1, 1, 2021), new Date(3, 1, 2021));  // Fechas deben ser del Entry y Departure date textboxes
            booking.ID = ENBooking.fillId();
            booking.date = dates;
            booking.user = (string)Session["id"];
            Session["bookingInfo"] = booking;
            Response.Redirect("Room.aspx");
            
        }

        protected void LogOutUser(object sender, EventArgs e)
        {
            Session.Abandon();
            Thread.Sleep(500);
            Response.Redirect("MainPage.aspx");
        }
    }
}