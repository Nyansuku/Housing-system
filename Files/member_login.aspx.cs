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
    public partial class member_login : System.Web.UI.Page
    {
        //cpnnection string 
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Member_login();
        }

        
        void Member_login()
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
                SqlCommand cmd = new SqlCommand("select * from member where username='" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "'", con);
                //using connected architecture
                SqlDataReader dr = cmd.ExecuteReader();
                //check if row exsit
                if (dr.HasRows)
                {
                    //if rows exists
                    //read value on the row
                    while (dr.Read())
                    {
                        //will add session variable in this section
                        Session["FirstName"] = dr.GetValue(0).ToString();
                        Session["email address"] = dr.GetValue(3).ToString();
                    }
                    Response.Redirect("member.aspx");
                }
                else
                {
                    Response.Write("<script>alert('wrong credentials')</script");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script");
            }
        }
    }
}