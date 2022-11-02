using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace houses
{
    public partial class member : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "hello" + " " + Session["FirstName"];
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("account.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("houses.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("rent.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("sell.aspx");
        }
        //logout page
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["FirstName"] = "";
            Session["email address"] ="";
            Response.Redirect("home.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

        }
    }
}