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
        protected void Page_Load(object sender, EventArgs e)
        {
            en.Id = 1;
            if(!Page.IsPostBack)
            {
                d = en.listAllServices();
                GridView1.DataSource = d;
                GridView1.DataBind();
            }
        }

    }
}