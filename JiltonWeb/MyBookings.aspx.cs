using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace JiltonWeb
{
    public partial class MyBookings : System.Web.UI.Page
    {
        DataSet datos = new DataSet();
        ENBooking booking = new ENBooking();
        ENUser user = new ENUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!Page.IsPostBack)
            {
                user.Email = Session["id"].ToString();
                string id = user.GetNIF();

                datos = booking.getByID(id);

                GridView1.DataSource = datos;
                GridView1.DataBind();
            }
        }
    }
}