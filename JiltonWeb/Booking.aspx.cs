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


namespace JiltonWeb
{
    public partial class Booking : System.Web.UI.Page
    {
        ENBooking booking = new ENBooking();
        IntervalDate dates = new IntervalDate(new Date(1, 1, 2021), new Date(3, 1, 2021));
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["id"] == null)
                    {
                        Response.Redirect("Register.aspx");
                    }
                    if (Session["bookingInfo"] == null)
                    {
                        Response.Redirect("MainPage.aspx");
                    }
                    booking = (ENBooking)Session["bookingInfo"];

                    // Prepare the page
                    System.Web.UI.Control c = new System.Web.UI.Control();
                    c = Page.Master.FindControl("RegisterBooking");
                    c.Visible = false;

                    EntryDateLabel.Text = booking.date.startDate.ToString();
                    DepartureDateLabel.Text = booking.date.endDate.ToString();

                    // Add payment methods
                    PaymentList.Items.Add("Debit/Credit Card");

                    // Filling grid views of the booking resume
                    DataTable t = (DataTable)Session["sessionSelected"];
                    GridViewRooms.DataSource = t;
                    GridViewRooms.DataBind();

                    DataTable tServices = (DataTable)Session["bookingServices"];
                    GridViewServices.DataSource = tServices;
                    GridViewServices.DataBind();

                    DataTable tCars = (DataTable)Session["bookingCars"];
                    GridViewCars.DataSource = tCars;
                    GridViewCars.DataBind();

                    DataTable tPackages = (DataTable)Session["bookingPackages"];
                    GridViewPackages.DataSource = tPackages;
                    GridViewPackages.DataBind();

                    // Total price
                    TotalPriceLabel.Text = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]).ToString("F") + " €";
                }
            }
            catch(Exception exc) 
            {
                Console.WriteLine("Exception has occurred.Error: {0}", exc.Message);
            }

        }

        protected void OnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                ENBooking booking = (ENBooking)Session["bookingInfo"];

                booking.Price = booking.calculatePrice((DataTable)Session["sessionSelected"], (DataTable)Session["bookingServices"], (DataTable)Session["bookingCars"], (DataTable)Session["bookingPackages"]);
                booking.createBooking();

                DataTable table = (DataTable)Session["sessionSelected"];
                foreach (DataRow dr in table.Rows)
                {
                    ENRoom room = new ENRoom();
                    room.id = (int)(float)dr["id"];
                    booking.addRoom(room);
                }

                table = (DataTable)Session["bookingServices"];
                if (table != null)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        booking.addService(dr);
                    }
                }

                table = (DataTable)Session["bookingCars"];
                if (table != null)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        ENCar car = new ENCar();
                        car.LicensePlate = (string)dr["id"];
                        booking.addCar(car);
                    }
                }

                table = (DataTable)Session["bookingPackages"];
                if (table != null)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        ENPackage package = new ENPackage();
                        package.id = (int)dr["id"];
                        booking.addPackage(package);
                    }
                }
                Session.Remove("bookingServices");
                Session.Remove("sessionSelected");
                Session.Remove("bookingCars");
                Session.Remove("bookingPackages");
                Session.Remove("bookingInfo");

                Response.Redirect("ThanksForBuy.aspx");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception has occurred.Error: {0}", exc.Message);
            }
           
        }

        private void RemoveElement(int index, string command)  // Method to remove elements from booking resume
        {
            try
            {
                DataTable table = (DataTable)Session[command];
                if (command == "sessionSelected")
                {
                    if (table.Rows.Count != 1)
                    {
                        table.Rows.Remove(table.Rows[index]);
                        Session[command] = table;
                        ActualiseGrid(command);
                    }
                    else
                    {
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
            catch (Exception exc)
            {
                Console.WriteLine("Exception has occurred.Error: {0}", exc.Message);
            }
        }

        private void ActualiseGrid(string type)  // Actualise grids from booking resume after a change
        {
            try
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
            catch (Exception exc)
            {
                Console.WriteLine("Exception has occurred.Error: {0}", exc.Message);
            }
            
        }

        protected virtual void GridView_ButtonCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                ENStaff staff = new ENStaff();
                List<string> listStaff = new List<string>();

                // Code to obtain the row of the GridView selected
                int index = Convert.ToInt32(e.CommandArgument);
                RemoveElement(index, e.CommandName);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception has occurred.Error: {0}", exc.Message);
            }
        }
    }
}