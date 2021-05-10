using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SpaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SpaGym.aspx");
        }

        protected void EventsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Events.aspx");
        }
    }
}