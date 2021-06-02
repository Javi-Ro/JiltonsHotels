using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Globalization;

namespace JiltonWeb
{
    public partial class ExtraServices : System.Web.UI.Page
    {
        ENService service = new ENService();
        ENBooking booking = new ENBooking();
        ENPackage package = new ENPackage();
        ENCar car = new ENCar();
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                booking = (ENBooking)Session["bookingInfo"];

                // Booking dates
                EntryDateLabel.Text = booking.date.startDate.ToString();
                DepartureDateLabel.Text = booking.date.endDate.ToString();

                // Filling grid views of the accordion panes
                d = service.listAllSpa();
                AccordionPaneSpa.DataSource = d;
                AccordionPaneSpa.DataBind();

                d = service.listAllGym();
                AccordionPaneGym.DataSource = d;
                AccordionPaneGym.DataBind();

                d = service.listMoreServices();
                AccordionPaneExtra.DataSource = d;
                AccordionPaneExtra.DataBind();

                d = car.listAllCars();
                AccordionPaneCars.DataSource = d;
                AccordionPaneCars.DataBind();

                d = car.listAllCars();
                AccordionPaneCars.DataSource = d;
                AccordionPaneCars.DataBind();

                d = package.listAllPackages();
                AccordionPanePackages.DataSource = d;
                AccordionPanePackages.DataBind();

                // Filling grid views of the booking resume
                DataTable tableRooms = (DataTable)Session["sessionSelected"];
                GridViewRooms.DataSource = tableRooms;
                GridViewRooms.DataBind();

                DataTable tableServices = (DataTable)Session["bookingServices"];
                GridViewServices.DataSource = tableServices;
                GridViewServices.DataBind();

                DataTable tableCars = (DataTable)Session["bookingCars"];
                GridViewCars.DataSource = tableCars;
                GridViewCars.DataBind();

                DataTable tablePackages = (DataTable)Session["bookingPackages"];
                GridViewPackages.DataSource = tablePackages;
                GridViewPackages.DataBind();

                // Total price
                TotalPriceLabel.Text = booking.calculatePrice(tableRooms, tableServices, tablePackages, tableCars).ToString() + " €";


                // Staff list
                StaffList.Items.Add("None");

            }

            if (booking.isDiscounted())
            {
                TotalPriceLabel.CssClass = "TotalPriceLabelWithoutDiscount";
                TotalWithDiscount.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString() + " €";
            }
            else
            {
                TotalPriceLabel.CssClass = "TotalPriceLabel";
                TotalWithDiscount.Text = "";
            }
        }

        protected void applyDiscountBooking(object sender, EventArgs e)
        {
            string code = discountTextBox.Text;

            ENDiscount disc = new ENDiscount();

            disc.code = code;

            if (disc.Exists())
            {
                disc.getPercentage();
                booking = (ENBooking)Session["bookingInfo"];
                booking.applyDiscount(disc);
                TotalWithDiscount.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString() + " €";
                Session["bookingInfo"] = booking;
                TotalPriceLabel.CssClass = "TotalPriceLabelWithoutDiscount";
            }
            else
            {
                // Error no existe codigo
            }
        }

        private void AddServices_Grid(GridViewRow row)
        {
            DataTable table = (DataTable)Session["bookingServices"];

            // Case there is no added service yet (table has not been created)
            if (table == null)
            {
                table = new DataTable();
                DataColumn description = new DataColumn();
                description.DataType = System.Type.GetType("System.String");
                description.ColumnName = "description";
                DataColumn day = new DataColumn();
                day.DataType = System.Type.GetType("System.DateTime");
                day.ColumnName = "serviceDay";
                DataColumn price = new DataColumn();
                price.DataType = System.Type.GetType("System.Single");
                price.ColumnName = "price";
                DataColumn hour = new DataColumn();
                hour.DataType = System.Type.GetType("System.Int32");
                hour.ColumnName = "hour";
                DataColumn type = new DataColumn();
                type.DataType = System.Type.GetType("System.String");
                type.ColumnName = "type";
                table.Columns.Add(description);
                table.Columns.Add(day);
                table.Columns.Add(hour);
                table.Columns.Add(price);
                table.Columns.Add(type);
            }

            // Fill a new row with data selected
            DataRow dr = table.NewRow();
            dr[0] = row.Cells[0].Text;
            string cellPrice = row.Cells[1].Text;
            cellPrice = cellPrice.Remove(cellPrice.Length - 2);
            dr[3] = float.Parse(cellPrice);

            // By the moment, we only keep the information in case it is finally not added  --> it will be added when button AddService is clicked
            Session["auxRow"] = dr;
            Session["bookingServices"] = table;
        }

        private void AddCars_Grid(GridViewRow row)
        {
            DataTable table = (DataTable)Session["bookingCars"];

            if (table == null)
            {
                table = new DataTable();
                DataColumn brand = new DataColumn();
                brand.DataType = System.Type.GetType("System.String");
                brand.ColumnName = "brand";
                DataColumn model = new DataColumn();
                model.DataType = System.Type.GetType("System.String");
                model.ColumnName = "model";
                DataColumn price = new DataColumn();
                price.DataType = System.Type.GetType("System.Single");
                price.ColumnName = "price";
                table.Columns.Add(brand);
                table.Columns.Add(model);
                table.Columns.Add(price);
            }

            // Fill a new row with data selected
            DataRow dr = table.NewRow();
            dr[0] = row.Cells[0].Text;
            dr[1] = row.Cells[1].Text;
            string cellPrice = row.Cells[2].Text;
            cellPrice = cellPrice.Remove(cellPrice.Length - 2);
            dr[2] = float.Parse(cellPrice);

            // Add the new row to the grid
            table.Rows.Add(dr);
            Session["bookingCars"] = table;
            ActualiseGrid("bookingCars");
        }

        private void AddPackages_Grid(GridViewRow row)
        {
            DataTable table = (DataTable)Session["bookingPackages"];

            if (table == null)
            {
                table = new DataTable();
                DataColumn name = new DataColumn();
                name.DataType = System.Type.GetType("System.String");
                name.ColumnName = "name";
                DataColumn price = new DataColumn();
                price.DataType = System.Type.GetType("System.Single");
                price.ColumnName = "price";
                table.Columns.Add(name);
                table.Columns.Add(price);
            }

            // Fill a new row with data selected
            DataRow dr = table.NewRow();
            dr[0] = row.Cells[0].Text;
            string cellPrice = row.Cells[1].Text;
            cellPrice = cellPrice.Remove(cellPrice.Length - 2);
            dr[1] = float.Parse(cellPrice);

            // Add the new row to the grid
            table.Rows.Add(dr);
            ActualiseGrid("bookingPackages");
        }

        private void RemoveElement(int index, string command)
        {
            DataTable table = (DataTable)Session[command];
            if (command == "sessionSelected")
            {   
                if(table.Rows.Count != 1)
                {
                    table.Rows.Remove(table.Rows[index]);
                    Session[command] = table;
                    ActualiseGrid(command);
                }
                else
                {
                    // --------------------------------> PONER QUE SALGA ALGO DE ERROR
                }
            }
            else
            {
                table.Rows.Remove(table.Rows[index]);
                Session[command] = table;
                ActualiseGrid(command);
            }
            TotalPriceLabel.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString() + " €";

        }

        protected virtual void GridView_ButtonCommand(object sender, GridViewCommandEventArgs e)
        {
            ENStaff staff = new ENStaff();
            List<string> listStaff = new List<string>();

            // Code to obtain the row of the GridView selected
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow gvRow = ((GridView)sender).Rows[index];

            // ADD or REMOVE button
            if (e.CommandName == "bookingPackages" || e.CommandName == "bookingCars" || e.CommandName == "sessionSelected" || e.CommandName == "bookingServices")
            {
                RemoveElement(index, e.CommandName);
                return;
            }
            else
            {
                // If it is add we enable all the controls for the select service bar
                TextEntry.Enabled = true;
                //ShowEntry.Enabled = true;
                HourTextBox.Enabled = true;
                StaffList.Enabled = true;
                AddServiceButton.Enabled = true;
                AddingServiceLabel.Text = gvRow.Cells[0].Text;
                StaffList.Items.Clear();
            }

            // Depending on the type of service to be added we will do different things
            if (e.CommandName == "AddSpa")
            {
                ServiceTypeLabel.Text = "Spa";
                try
                {
                    listStaff = staff.FilterByType("massagist");
                    foreach (string name in listStaff)
                    {
                        StaffList.Items.Add(name);
                    }
                    // Add service to GridView of the booking resume
                    AddServices_Grid(gvRow);
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Spa service adding has failed.Error: {0}", exc.Message);
                    StaffList.Items.Clear();
                    StaffList.Items.Add("Staff not available");
                    AddServiceButton.Enabled = false;
                }
            }
            else if (e.CommandName == "AddGym")
            {
                ServiceTypeLabel.Text = "Gym";
                try
                {
                    listStaff = staff.FilterByType("trainer");
                    foreach (string name in listStaff)
                    {
                        StaffList.Items.Add(name);
                    }
                    // Add service to GridView of the booking resume
                    AddServices_Grid(gvRow);
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Gym service adding has failed.Error: {0}", exc.Message);
                    StaffList.Items.Clear();
                    StaffList.Items.Add("Staff not available");
                    AddServiceButton.Enabled = false;
                }
            }
            else if (e.CommandName == "AddExtra")
            {
                ServiceTypeLabel.Text = "Extra";
                try
                {
                    listStaff = staff.FilterByType("extra");  // Si servicio es kindergarten o excursion, sale staff de ambos
                    foreach (string name in listStaff)
                    {
                        StaffList.Items.Add(name);
                    }
                    AddServices_Grid(gvRow);
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Extra service adding has failed.Error: {0}", exc.Message);
                    StaffList.Items.Clear();
                    StaffList.Items.Add("Staff not available");
                    AddServiceButton.Enabled = false;
                }
            }
            else if (e.CommandName == "AddCar")
            {
                ResetLabels();
                AddCars_Grid(gvRow);
                TotalPriceLabel.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString() + " €";
            }
            else if (e.CommandName == "AddPackage")
            {
                ResetLabels();
                AddPackages_Grid(gvRow);
                TotalPriceLabel.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString() + " €";
            }
            else { }
        }

        protected void ContinueButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Booking.aspx");
        }

        private void ActualiseGrid(string type)
        {
            DataTable table = new DataTable();
            table = (DataTable)Session[type];
            if (type == "bookingServices")
            {
                GridViewServices.DataSource = table;
                GridViewServices.DataBind();
            }
            else if (type == "bookingCars")
            {
                GridViewCars.DataSource = table;
                GridViewCars.DataBind();
            }
            else if (type == "sessionSelected")
            {
                GridViewRooms.DataSource = table;
                GridViewRooms.DataBind();
            }
            else
            {
                GridViewPackages.DataSource = table;
                GridViewPackages.DataBind();
            }
        }

        private void ResetLabels()  // Disable controls of the selected service bar after the adding has been completed
        {
            AddingServiceLabel.Text = "None";
            ServiceTypeLabel.Text = "-";
            TextEntry.Enabled = false;
            //ShowEntry.Enabled = false;
            HourTextBox.Enabled = false;
            StaffList.Enabled = false;
            AddServiceButton.Enabled = false;
            TextEntry.Text = "";
            HourTextBox.Text = "";
            StaffList.Items.Clear();
            StaffList.Items.Add("None");
        }

        protected void AddServiceButton_Click(object sender, EventArgs e)  // Add SPA,GYM,EXTRA services
        {
            try
            {
                DataRow auxRow = (DataRow)Session["auxRow"];
                DataTable table = (DataTable)Session["bookingServices"];

                auxRow[1] = DateTime.ParseExact(TextEntry.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                auxRow[2] = int.Parse(HourTextBox.Text.Substring(0, 2));
                auxRow["type"] = AddingServiceLabel.Text;

                table.Rows.Add(auxRow);
                Session["bookingServices"] = table;
                ActualiseGrid("bookingServices");
                TotalPriceLabel.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString() + " €";
                ResetLabels();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Extra service adding has failed.Error: {0}", exc.Message);
            }
        }
    }
}