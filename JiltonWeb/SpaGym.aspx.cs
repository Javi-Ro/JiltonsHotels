using Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class SpaGym : System.Web.UI.Page
    {
        ENService en = new ENService();
        DataSet d = new DataSet();
        ENService en2 = new ENService();
        DataSet d2 = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            en.Id = 1;
            en2.Id = 2;
            if(!Page.IsPostBack)
            {
                d = en.listAllSpa();
                GridView1.DataSource = d;
                GridView1.DataBind();

                d2 = en2.listAllGym();
                GridView2.DataSource = d2;
                GridView2.DataBind();
            }
            if (Session["id"] != null && Session["id"].ToString() == "admin")
            {
                adminpage.CssClass = "super";
            }
            else
            {
                adminpage.CssClass = "superadmin";
            }
        }

    }
}