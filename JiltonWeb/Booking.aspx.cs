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
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            booking.ID = 1;
            if (!Page.IsPostBack)
            {
                // Add payment methods
                PaymentList.Items.Add("Debit/Credit Card");

                // Filling grid views of the booking resume
                d = booking.getServices();
                GridViewServices.DataSource = d;
                GridViewServices.DataBind();

                d = booking.getRooms();
                GridViewRooms.DataSource = d;
                GridViewRooms.DataBind();

            }
        }

        protected void OnPayNow_Click(object sender, EventArgs e)
        {

        }

        protected virtual void OnTextChanged_Card(object sender, EventArgs e)
        {
            CardNumber.Text = "888888888";
        }

        protected virtual void GridView_ButtonCommand(Object sender, GridViewCommandEventArgs e)
        {
            
        }
    }
}