using System;
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
            booking.ID = 1;
            booking.date = dates; 
            if (!Page.IsPostBack)
            {
                // Add payment methods
                PaymentList.Items.Add("Debit/Credit Card");

                // Booking dates
                EntryDateLabel.Text = booking.date.startDate.ToString();
                DepartureDateLabel.Text = booking.date.endDate.ToString();

                // Filling grid views of the booking resume
                d = booking.getServices();
                GridViewServices.DataSource = d;
                GridViewServices.DataBind();

                d = booking.getRooms();
                GridViewRooms.DataSource = d;
                GridViewRooms.DataBind();

                d = booking.getCars();
                GridViewCars.DataSource = d;
                GridViewCars.DataBind();

                d = booking.getPackages();
                GridViewPackages.DataSource = d;
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