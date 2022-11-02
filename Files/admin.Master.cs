using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace houses
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_apartment.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_house.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("house_allocation.aspx");
        }


        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("complains.aspx");

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("rentals.aspx");

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["email_address"] = "";
            Session["name"] = "";
            Response.Redirect("home.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("house_info.aspx");
        }

    }
}