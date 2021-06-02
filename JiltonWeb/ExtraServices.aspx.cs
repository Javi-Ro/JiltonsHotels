using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Windows.Controls;
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
                booking = (ENBooking)Session["bookingInfo"];  // Esto deben ser dataTables que se conectarán a cada gridView del booking Resume --> bookingInfo para fecha y user
                                                              // sessionSelected --> rooms, 
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
                DataTable table = (DataTable)Session["sessionSelected"];
                GridViewRooms.DataSource = table;
                GridViewRooms.DataBind();

                /*table = (DataTable)Session["bookingSpa"];
                GridViewServices.DataSource = table;
                GridViewServices.DataBind();

                d = booking.getCars();
                GridViewCars.DataSource = d;
                GridViewCars.DataBind();

                d = booking.getPackages();
                GridViewPackages.DataSource = d;
                GridViewPackages.DataBind();*/

                // Total price
                TotalPriceLabel.Text = booking.calculatePrice().ToString() + " €";


                // Staff list
                StaffList.Items.Add("None");

            }
        }

        private void AddSpa_Grid(GridViewRow row)
        {
            DataTable table = (DataTable)Session["bookingSpa"];

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
                table.Columns.Add(description);
                table.Columns.Add(day);
                table.Columns.Add(hour);
                table.Columns.Add(price);
            }

            // Fill a new row with data selected
            DataRow dr = table.NewRow();
            dr[0] = row.Cells[0].Text;
            string cellPrice = row.Cells[1].Text;
            cellPrice = cellPrice.Remove(cellPrice.Length - 2);
            dr[3] = float.Parse(cellPrice);

            // By the moment, we only keep the information in case it is finally not added  --> it will be added when button AddService is clicked
            Session["auxRow"] = dr;
            Session["bookingSpa"] = table;
        }

        protected virtual void GridView_ButtonCommand(object sender, GridViewCommandEventArgs e)
        {
            ENStaff staff = new ENStaff();
            List<string> listStaff = new List<string>();

            // Code to obtain the row of the GridView selected
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow gvRow = ((GridView)sender).Rows[index];

            // ADD or REMOVE button
            if (e.CommandName == "Remove")
            {
                // Code for removing from a booking
            }
            else
            {
                TextEntry.Enabled = true;
                ShowEntry.Enabled = true;
                HourTextBox.Enabled = true;
                StaffList.Enabled = true;
                AddServiceButton.Enabled = true;
                AddingServiceLabel.Text = gvRow.Cells[0].Text;
                StaffList.Items.Clear();
            }

            if (e.CommandName == "AddSpa")
            {
                ServiceTypeLabel.Text = "SPA";
                try
                {
                    listStaff = staff.FilterByType("massagist");
                    foreach (string name in listStaff)
                    {
                        StaffList.Items.Add(name);
                    }
                    // Add service to GridView of the booking resume
                    AddSpa_Grid(gvRow);
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
                ServiceTypeLabel.Text = "GYM";
                try
                {
                    listStaff = staff.FilterByType("trainer");
                    foreach (string name in listStaff)
                    {
                        StaffList.Items.Add(name);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Gym service adding has failed.Error: {0}", exc.Message);
                    StaffList.Items.Add("Staff not available");
                    AddServiceButton.Enabled = false;
                }
            }
            else if (e.CommandName == "AddExtra")
            {
                ServiceTypeLabel.Text = "EXTRA SERVICES";
                try
                {
                    listStaff = staff.FilterByType("extra");  // Si servicio es kindergarten o excursion, sale staff de ambos
                    foreach (string name in listStaff)
                    {
                        StaffList.Items.Add(name);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Extra service adding has failed.Error: {0}", exc.Message);
                    StaffList.Items.Add("Staff not available");
                    AddServiceButton.Enabled = false;
                }
            }
            else
            {
                ResetLabels();
                if (e.CommandName == "AddCar")
                {
                    // Añadir car a booking
                }
                else
                {
                    // Añadir package a booking
                }
            }
        }

        protected void ContinueButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Booking.aspx");
        }

        private void ActualiseGrid(string type)
        {
            DataTable table = new DataTable();
            table = (DataTable)Session[type];
            GridViewServices.DataSource = table;
            GridViewServices.DataBind();
        }

        private void ResetLabels()
        {
            AddingServiceLabel.Text = "None";
            ServiceTypeLabel.Text = "-";
            TextEntry.Enabled = false;
            ShowEntry.Enabled = false;
            HourTextBox.Enabled = false;
            StaffList.Enabled = false;
            AddServiceButton.Enabled = false;
            StaffList.Items.Clear();
        }

        protected void AddServiceButton_Click(object sender, EventArgs e)  // Add SPA,GYM,EXTRA services
        {
            try
            {
                DataRow auxRow = (DataRow)Session["auxRow"];
                DataTable table = (DataTable)Session["bookingSpa"];

                auxRow[1] = DateTime.ParseExact(TextEntry.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);   // TextEntry.Text en el debugger sale como cadena vacía.
                auxRow[2] = int.Parse(HourTextBox.Text.Substring(0, 2));

                table.Rows.Add(auxRow);
                Session["bookingSpa"] = table;
                ActualiseGrid("bookingSpa");
                ResetLabels();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Extra service adding has failed.Error: {0}", exc.Message);
            }
        }
    }
}