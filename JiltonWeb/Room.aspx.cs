using Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class Room : System.Web.UI.Page
    {
        ENRoom room = new ENRoom();
        DataSet datos = new DataSet();
        private String constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Context.Items["showLowest"] != null)
            //{
            //    SqlDataSource1.SelectCommand += Context.Items["showLowest"];
            //}
            
            if (!IsPostBack)
            {
                this.BindGrid();
            }
            if(Context.Items["Check"] != null)
            {
                DataTable seleccionado = (DataTable)Session["sessionSelected"];
                GridViewRooms.DataSource = seleccionado;
                GridViewRooms.DataBind();
            }

            GridView1.DataBind();

            if (Session["id"] != null && Session["id"].ToString() == "admin")
            {
                //foreach(GridViewRow row in GridView1.Rows)
                //{
                //    Panel panel = (Panel)row.FindControl("adminViewRoom");
                //    panel.CssClass = "icono";
                //}
                adminViewRoom.CssClass = "vistaAdminRoom";
                InsertInterface(sender, e);


            }
            else
            {
                //foreach (GridViewRow row in GridView1.Rows)
                //{
                //    Panel panel = (Panel)row.FindControl("adminViewRoom");
                //    panel.CssClass = "iconoHidden";
                //}
                adminViewRoom.CssClass = "vistaNoAdminRoom";
            }

        }

        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("SELECT * from room");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
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

        protected void showLowest(object sender, EventArgs e)
        {
            Context.Items.Add("showLowest", " order by price");
            Server.Transfer("Room.aspx");
        }

        protected void gridview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();

        }

        protected void DeleteInterface(object sender, EventArgs e)
        {
            InsertOrUpdate.CssClass = "invisible";
            deletePanel.CssClass = "visible";

        }

        protected void InsertInterface(object sender, EventArgs e)
        {
            InsertOrUpdate.CssClass = "visible";
            deletePanel.CssClass = "invisible";
            Update.Visible = false;
            Insert.Visible = true;
        }

        protected void UpdateInterface(object sender, EventArgs e)
        {
            InsertOrUpdate.CssClass = "visible";
            deletePanel.CssClass = "invisible";
            Update.Visible = true;
            Insert.Visible = false;
        }
        protected void addButton(object sender, EventArgs e)
        {
            DataTable seleccionado = (DataTable)Session["sessionSelected"];
            
            if(seleccionado == null)
            {
                seleccionado = new DataTable();
                DataColumn title = new DataColumn();
                title.DataType = System.Type.GetType("System.String");
                title.ColumnName = "title";
                DataColumn price = new DataColumn();
                price.DataType = System.Type.GetType("System.Single");
                price.ColumnName = "price";
                seleccionado.Columns.Add(title);
                seleccionado.Columns.Add(price);
            }

            DataRow dr = seleccionado.NewRow();
  

            Button button1 = (Button)sender;
            GridViewRow gr = (GridViewRow)button1.NamingContainer;
            Label titulo = (Label)gr.FindControl("Label1");
            Label precio = (Label)gr.FindControl("Label9");
            dr["title"] = titulo.Text;
            dr["price"] = float.Parse(precio.Text);
            seleccionado.Rows.Add(dr);
            
            Session["sessionSelected"] = seleccionado;
            Context.Items.Add("Check", true);
            Server.Transfer("Room.aspx");
        }
    }
}