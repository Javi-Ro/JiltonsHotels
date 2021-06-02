﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Windows.Controls;
using Library;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Windows.Forms;


namespace JiltonWeb
{
    public partial class Booking : System.Web.UI.Page
    {
        ENBooking booking = new ENBooking();
        IntervalDate dates = new IntervalDate(new Date(1, 1, 2021), new Date(3, 1, 2021));
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            //booking.ID = 1;
            //booking.date = dates; 
            if (!Page.IsPostBack)
            {
                // Prepare the page
                System.Web.UI.Control c = new System.Web.UI.Control();
                c = Page.Master.FindControl("RegisterBooking");
                c.Visible = false;

                // Filling booking parameters
                ENBooking booking = (ENBooking)Session["bookingInfo"];
                EntryDateLabel.Text = booking.date.startDate.ToString();
                DepartureDateLabel.Text = booking.date.endDate.ToString();

                // Add payment methods
                PaymentList.Items.Add("Debit/Credit Card");

                // Filling grid views of the booking resume
                DataTable t = (DataTable)Session["sessionSelected"];
                GridViewRooms.DataSource = t;
                GridViewRooms.DataBind();

                DataTable tServices = (DataTable)Session["bookingServices"];
                GridViewServices.DataSource = tServices;
                GridViewServices.DataBind();

                DataTable tCars = (DataTable)Session["bookingCars"];
                GridViewCars.DataSource = tCars;
                GridViewCars.DataBind();

                DataTable tPackages = (DataTable)Session["bookingPackages"];
                GridViewPackages.DataSource = tPackages;
                GridViewPackages.DataBind();

                // Total price
                TotalPriceLabel.Text = booking.calculatePrice().ToString() + " €";
            }
        }

        protected void OnPayNow_Click(object sender, EventArgs e)
        {

        }

        protected virtual void GridView_ButtonCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }
    }
}