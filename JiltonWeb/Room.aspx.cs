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
using System.Threading;

namespace JiltonWeb
{
    public partial class Room : System.Web.UI.Page
    {
        ENRoom room = new ENRoom();
        DataSet datos = new DataSet();
        private String constring = ConfigurationManager.ConnectionStrings["Database"].ToString();

        /// <summary>
        /// Page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            errorRepeated.Visible = false;
            if (Session["sessionSelected"] != null)     //to control the grid view of selected rooms
            {
                DataTable seleccionado = (DataTable)Session["sessionSelected"];
                goButton.Visible = true;
                GridViewRooms.DataSource = seleccionado;
                GridViewRooms.DataBind();
            }

            this.BindGrid();
            GridView1.DataBind();
            GridViewRooms.DataBind();

            if (Session["id"] != null && Session["id"].ToString() == "admin")   //administrator view 
            {

                GridView1.Columns[0].Visible = false;
                adminViewRoom.CssClass = "visible";
                roomIDUpdate.Visible = false;
                InsertInterface(sender, e);                 //we go directly to the insert view

            }
            else
            {
                GridView1.Columns[0].Visible = false;
                adminViewRoom.CssClass = "invisible";
            }

        }

        /// <summary>
        /// personalized version of DataBind()
        /// </summary>
        private void BindGrid()    
        {
            string comando = "select * from room where bookingNumber is null ";
            if(Session["filters"] != null)          //to keep selected filters
            {
                comando = Session["filters"].ToString();
            }
            string constr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(comando);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        /// <summary>
        /// Function to send the selected rooms to booking or register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GoButton_Click(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("Register.aspx");     //if the user is unknown, they are sent to the register page
            }
            Response.Redirect("ExtraServices.aspx");
        }

        /// <summary>
        /// Handler to control pagination. It is triggered when the index of the page changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();

        }

        /// <summary>
        /// Function to show all the buttons necessary to make an insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void InsertInterface(object sender, EventArgs e)
        {
            InsertOrUpdate.CssClass = "visible";
            deletePanel.CssClass = "invisible";
            Update.Visible = false;
            Insert.Visible = true;
            error.Visible = false;
            roomIDUpdate.Visible = false;
            success.Visible = false;
            onlyUpdateID.CssClass = "invisible";
        }

        /// <summary>
        /// function to show all the buttons necessary to make a delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteInterface(object sender, EventArgs e)
        {
            InsertOrUpdate.CssClass = "invisible";
            deletePanel.CssClass = "visible";
            onlyUpdateID.CssClass = "invisible";
            error.Visible = false;
            success.Visible = false;

        }

        /// <summary>
        /// Function to show all the buttons necessary to make an update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateInterface(object sender, EventArgs e)
        {
            InsertOrUpdate.CssClass = "visible";
            deletePanel.CssClass = "invisible";
            roomIDUpdate.Visible = true;
            Update.Visible = true;
            Insert.Visible = false;
            error.Visible = false;
            success.Visible = false;
            onlyUpdateID.CssClass = "visible";
        }

        /// <summary>
        /// Handler to do the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onUpdate(object sender, EventArgs e)
        {
            error.Visible = false;
            success.Visible = false;
            int id = int.Parse(roomIDUpdate.Text);
            float precio = float.Parse(priceTB.Text);
            int single = int.Parse(childBedTB.Text);
            int king = int.Parse(kingBedTB.Text);
            string imagen = imageTB.Text;
            if (string.IsNullOrEmpty(imageTB.Text))
            {
                imagen = "assets/room1.jpg";        //default image
            }
            ENRoom room = new ENRoom(id, nameTB.Text, descriptionTB.Text, precio, single, king, TypeTB.SelectedValue, null, imagen);

            if (room.update())
            {

                success.Visible = true;
                success.Text = "Room updated succesfully";
            }
            else
            {
                error.Visible = true;
                error.Text = "Could not update the room " + room.id;

            }

            Thread.Sleep(500);
            Server.Transfer("Room.aspx");
        }

        /// <summary>
        /// Handler to do the insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onInsert(object sender, EventArgs e)
        {
            error.Visible = false;
            success.Visible = false;

            float precio = float.Parse(priceTB.Text);
            int single = int.Parse(childBedTB.Text);
            int king = int.Parse(kingBedTB.Text);
            string imagen = imageTB.Text;
            if (string.IsNullOrEmpty(imageTB.Text))
            {
                imagen = "assets/room1.jpg";
            }
            //All the validations have been done with range validators and require field validators
            ENRoom room = new ENRoom(0, nameTB.Text, descriptionTB.Text, precio,single,king, TypeTB.SelectedValue, null, imagen);

            if (room.insertRoom())
            {
                success.Visible = true;
                success.Text = "Room inserted succesfully";
            }

            else
            {
                error.Visible = true;
                error.Text = "Could not insert room ";
            }

            Thread.Sleep(500);
            Server.Transfer("Room.aspx");

        }
       /// <summary>
       /// Handler to do the delete
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void onDelete(object sender,EventArgs e)
        { 
            ENRoom room = new ENRoom();
            if (String.IsNullOrEmpty(roomID.Text))
            {
                error.Visible = true;
            }
            else
            {
                room.id = int.Parse(roomID.Text);

                if (room.delete())
                {
                    success.Visible = true;
                    success.Text = "Room deleted succesfully";
                }

                else
                {
                    error.Visible = true;
                    error.Text = "Could not delete room " + room.id;
                }
            }

            Thread.Sleep(500);
            Server.Transfer("Room.aspx");
        }

        /// <summary>
        /// Handler of the button to add a room to the selected rooms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void addButton(object sender, EventArgs e)
        {
               
            DataTable seleccionado = (DataTable)Session["sessionSelected"];

            if (seleccionado == null)       //we create a table and we insert columns id, title and price
            {
                seleccionado = new DataTable();
                DataColumn id = new DataColumn();
                id.DataType = System.Type.GetType("System.Single");
                id.ColumnName = "id";
                DataColumn title = new DataColumn();
                title.DataType = System.Type.GetType("System.String");
                title.ColumnName = "title";
                DataColumn price = new DataColumn();
                price.DataType = System.Type.GetType("System.Single");
                price.ColumnName = "price";
                seleccionado.Columns.Add(id);
                seleccionado.Columns.Add(title);
                seleccionado.Columns.Add(price);
                
            }

            goButton.Visible = true;
            DataRow dr = seleccionado.NewRow();

            Button button1 = (Button)sender;
            GridViewRow gr = (GridViewRow)button1.NamingContainer;

            bool repeated = false;
            Label idLabel = (Label)gr.FindControl("idLabel");

            if (GridViewRooms.Rows.Count >= 1)          //if the table has more than zero rows, we control that the new room is not already selected
            {
                foreach (GridViewRow row in GridViewRooms.Rows)
                {

                    if (row.Cells[0].Text == idLabel.Text)
                    {
                        
                        repeated = true;

                    }    
                }
            }
        
            if (repeated == false)      //if it is not repeated, we insert the new row
            {
                Label titulo = (Label)gr.FindControl("Label1");
                Label precio = (Label)gr.FindControl("Label9");
                dr["id"] = int.Parse(idLabel.Text);
                dr["title"] = titulo.Text;
                dr["price"] = float.Parse(precio.Text);
                
                seleccionado.Rows.Add(dr);
                Session["sessionSelected"] = seleccionado;
                Context.Items.Add("Check", true);
                Response.Redirect("Room.aspx");
            }
            else
            {
                errorRepeated.Visible = true;
            }

        }

        /// <summary>
        /// Handler to apply the search filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onSearch(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            string comando = "Select * from room where bookingNumber is null ";

            if (typeList.SelectedValue != "unselected")         //drop down list with types
            {
                comando = comando + "and type = '" + typeList.SelectedValue + "' ";

            }

            comando = comando + "and price <= " + Control.Text;

            switch (orderList.SelectedValue){       //drop down list with the order 
                case "Lowest":
                    comando = comando + " order by price ";
                    break;
                case "Highest":
                    comando = comando + " order by price DESC ";
                    break;
                default:
                    comando = comando + ' ';
                    break;
            }

            Session["filters"] = comando;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(comando);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }
    }
}