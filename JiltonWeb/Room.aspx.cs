using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
            }

            GridView1.DataBind();

            if (Session["id"] != null && Session["id"].ToString() == "admin")
            {
                foreach(GridViewRow row in GridView1.Rows)
                {
                    Panel panel = (Panel)row.FindControl("adminViewRoom");
                    panel.CssClass = "icono";
                }
   
            }
            else
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    Panel panel = (Panel)row.FindControl("adminViewRoom");
                    panel.CssClass = "iconoHidden";
                }
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExtraServices.aspx");
        }
    }
}