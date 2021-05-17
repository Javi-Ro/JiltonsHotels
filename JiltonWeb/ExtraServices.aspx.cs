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
    public partial class ExtraServices : System.Web.UI.Page
    {
        ENService service = new ENService();
        ENBooking booking = new ENBooking();
        ENPackage package = new ENPackage();

        ENCar car = new ENCar();
        IntervalDate dates = new IntervalDate(new Date(1, 1, 2021), new Date(3, 1, 2021));
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            booking.ID = 1;
            booking.date = dates;
            if (!Page.IsPostBack)
            {
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
                d = booking.getServices();
                GridViewServices.DataSource = d;
                GridViewServices.DataBind();

                d = booking.getRooms();
                GridViewRooms.DataSource = d;
                GridViewRooms.DataBind();

                d = booking.getCars();
                GridViewCars.DataSource = d;
                GridViewCars.DataBind();

                d = booking.getPackages();
                GridViewPackages.DataSource = d;
                GridViewPackages.DataBind();

                // Total price
                TotalPriceLabel.Text = booking.calculatePrice().ToString() + " €";


                // Staff list
                StaffList.Items.Add("Staff not available now");

            }
        }

        protected virtual void GridView_ButtonCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void ContinueButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Booking.aspx");
        }
    }
}