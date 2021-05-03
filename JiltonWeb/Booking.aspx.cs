using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PaymentList.Items.Add("Debit/Credit Card");
            }
        }

        protected void OnPayNow_Click(object sender, EventArgs e)
        {

        }
    }
}