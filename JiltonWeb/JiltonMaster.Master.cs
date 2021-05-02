using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiltonWeb
{
    public partial class JiltonMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EntryCalendar.StartDate = DateTime.Now;
                DepartureCalendar.StartDate = DateTime.Now;
                ChildOptions.Items.Add(new ListItem("0", "0"));
                ChildOptions.Items.Add(new ListItem("1", "1"));
                ChildOptions.Items.Add(new ListItem("2", "2"));
                ChildOptions.Items.Add(new ListItem("3", "3"));
                AdultOptions.Items.Add(new ListItem("0", "0"));
                AdultOptions.Items.Add(new ListItem("1", "1"));
                AdultOptions.Items.Add(new ListItem("2", "2"));
            }
        }
    }
}