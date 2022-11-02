using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace houses
{
    public partial class admin_login : System.Web.UI.Page
    {
        //cpnnection string 
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Admin_login();
        
            }
        //user defined funtion
        void Admin_login()
        {
            try
            {
                //connection object
                SqlConnection con = new SqlConnection(strcon);
                //check if connection is open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //query
                SqlCommand cmd = new SqlCommand("select * from admin where admin_email='"+TextBox3.Text.Trim()+"' AND admin_password='"+TextBox4.Text.Trim()+"'", con);
                //using connected architecture
                SqlDataReader dr = cmd.ExecuteReader();
                //check if row exsit
                if (dr.HasRows)
                {
                    //if rows exists
                    //read value on the row
                    while (dr.Read()){
                        //will add session variable in this section
                        Session["email_address"] = dr.GetValue(3).ToString();
                        Session["name"] = dr.GetValue(1).ToString();
                    }
                    Response.Redirect("adminpage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('wrong credentials')</script");
                }

            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script");
            }
        }
    }
}