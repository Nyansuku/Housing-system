using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace houses
{
    public partial class adminpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addlocation_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_apartment.aspx");
        }

        protected void addhouse_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_house.aspx");
        }

        protected void allocation_Click(object sender, EventArgs e)
        {
            Response.Redirect("house_allocation.aspx");
        }

        protected void houseinfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("house_info.aspx");
        }

        protected void complains_Click(object sender, EventArgs e)
        {
            Response.Redirect("complains.aspx");
        }

        protected void rentalinfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("rentals.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");
        }
    }
}