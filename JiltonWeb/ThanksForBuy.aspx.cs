using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class ThanksForBuy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(!Page.IsPostBack)
            {
                System.Threading.Thread.Sleep(5000);
                Response.Redirect("MainPage.aspx");
            }*/
            
        }

        protected void Boton(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}