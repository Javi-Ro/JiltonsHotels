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

        protected void Button_Reserve(object sender, GridViewCommandEventArgs e) 
         {
             ENService en = new ENService(); 
             int index = Convert.ToInt32(e.CommandArgument);
             GridViewRow gvRow = ((GridView)sender).Rows[index];
             en.Id = int.Parse(gvRow.Cells[1].Text);
             Session["reserSpa"] = en;
             //ENBooking book = new ENBooking();

            /*DataTable table = (DataTable)Session["reserSpa"];
            table = new DataTable();
            DataColumn id = new DataColumn();
            id.DataType = System.Type.GetType("System.String");
            id.ColumnName = "id";
            DataColumn description = new DataColumn();
            description.DataType = System.Type.GetType("System.String");
            description.ColumnName = "description";
            DataColumn price = new DataColumn();
            price.DataType = System.Type.GetType("System.Single");
            price.ColumnName = "price";
            table.Columns.Add(id);
            table.Columns.Add(description);
            table.Columns.Add(price);

            DataRow dr = table.NewRow();
            dr[0] = gvRow.Cells[1].Text;
            dr[1] = gvRow.Cells[2].Text;
            string cellPrice = gvRow.Cells[3].Text;
            cellPrice = cellPrice.Remove(cellPrice.Length - 2);
            dr[2] = float.Parse(cellPrice);

            table.Rows.Add(dr);
            Session["reserSpa"] = table;*/

            if (Session["id"] == null)
             { //not logged, mandar a login
                 Response.Redirect("Login.aspx");
             }
             else if(Session["id"] != null  )
             { //logged y no tiene booking, mandar a room
                 Response.Redirect("Room.aspx");
             }
             /*else if(Session["id"] != null  )
             { //logged y tiene booking, mandar a pasarela pago
                 Response.Redirect("ExtraPayments.aspx");
             }*/
         }

        protected void Crear(object sender, EventArgs e)
        {
            if(name.Text != "" && maxp.Text != "" && type.Text == "excursion" && id.Text != "" && descr.Text != "" && price.Text != "" && image.Text != "")
            {
                ENService en = new ENService( int.Parse(id.Text), descr.Text, int.Parse(price.Text), name.Text, int.Parse(maxp.Text), image.Text, type.Text);
                if(en.createService() != false)
                {
                    output.Text = "Service created.";
                }
                else
                {
                    output.Text = "Service can't be created."; 
                }
            }
            else
            {
                if (id.Text != "" && descr.Text != "" && price.Text != "" && name.Text == "" && maxp.Text=="" && image.Text!="" && type.Text!="" && type.Text!="excursion")
                {
                    ENService en = new ENService(int.Parse(id.Text), descr.Text, int.Parse(price.Text), image.Text, type.Text);
                    if (en.createService() != false)
                    {
                        output.Text = "Service created.";
                    }
                    else
                    {
                        output.Text = "Service can't be created.";
                    }
                }
                else
                {
                    output.Text = "Error. Wrong data written.";
                }
            }
            
        }

        protected void Borrar(object sender, EventArgs e)
        {
            if(id.Text != "")
            {
                ENService en = new ENService(int.Parse(id.Text), "", 0, "", "");
                if(en.deleteService() == true)
                {
                    output.Text = "Service deleted.";
                }
                else
                {
                    output.Text = "Service can't be deleted.";
                }
            }
            else
            {
                output.Text = "Error. Write the id of the service you want to delete.";
            }
        }

        protected void Update(object sender, EventArgs e)
        {
            if(id.Text != "" && descr.Text != "" && price.Text != "" && type.Text != "")
            {
                ENService en = new ENService(int.Parse(id.Text), descr.Text, int.Parse(price.Text), name.Text, int.Parse(maxp.Text), image.Text, type.Text);
                if(en.updateService() != false)
                {
                    output.Text = "Service updated.";
                }
                else
                {
                    output.Text = "Service can't be updated.";
                }
            }
            else
            {
                output.Text = "Error. Service could not be updated, write the correct fields.";
            }
        }

    }
}