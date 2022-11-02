using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace houses
{
    public partial class house_allocation : System.Web.UI.Page
    {
        //connection string
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            get_apartments();
            GridView1.DataBind();
        }
        //add
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Checkmember())
            {
                Response.Write("<script>alert('member already exist,try another member ID')</script>");
            }
            else
            {
                add_member();
            }
        }
        //userdefined function
        void add_member() 
        {
            try {
                // file upload code
                //hard coded fill path for default image
                string filepath = "~/upload/apa2.jpg";
                //geting the content from fileupload asp button
                //the file will be posted to the server
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //save the image to the folder that we want to store
                FileUpload1.SaveAs(Server.MapPath("upload/" + filename));
                filepath = "~upload/" + filename;

                //connection object
                SqlConnection con = new SqlConnection(strcon);
                //check if connection is open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //query
                SqlCommand cmd = new SqlCommand("insert into member(firstname,lastname,phone,email,apartment_name,house_number,user_image,username,password,member_ID) values(@firstname,@lastname,@phone,@email,@apartment_name,@house_number,@user_image,@username,@password,@member_ID)", con);
                //get the values
                cmd.Parameters.AddWithValue("@firstname", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname",TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@apartment_name",DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@house_number", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@user_image", filepath);
                cmd.Parameters.AddWithValue("@username", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@member_ID", TextBox8.Text.Trim());

                //execute code
                cmd.ExecuteNonQuery();
                //close the connec tion
                con.Close();
                //message
                GridView1.DataBind();
                Response.Write("<script>alert('Member Added Suucessfully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void get_apartments()
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
                SqlCommand cmd = new SqlCommand("select apa_name from apartments", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "apa_name";
                DropDownList1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        void Delete_house()
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
                SqlCommand cmd = new SqlCommand("delete from member  where member_ID='" + TextBox8.Text.Trim() + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //message
                Response.Write("<script>alert('Member  Deleted Suucessfully')</script>");
                
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        bool Checkmember()
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
                SqlCommand cmd = new SqlCommand("select * from member where member_ID='" + TextBox8.Text.Trim() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                //fill the dattable using the data adapters
                sda.Fill(dt);
                //check if we have any record
                //if we have any record of the same id
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                //else
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                return false;
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Checkmember())
            {
                Delete_house();
            }
            else
            {
                Response.Write("<script>alert('Member Doesnt Exist')</script>");
            }
        }

        void Go()
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
                SqlCommand cmd = new SqlCommand("select * from member where member_ID='" + TextBox8.Text.Trim() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //check if row exist
                if (dt.Rows.Count > 0)
                {
                    
                    TextBox1.Text = dt.Rows[0][0].ToString();
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    DropDownList1.SelectedValue = dt.Rows[0][2].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();
                    TextBox5.Text = dt.Rows[0][7].ToString();
                    TextBox6.Text = dt.Rows[0][5].ToString();
                    TextBox7.Text = dt.Rows[0][3].ToString();
                    TextBox7.Text = dt.Rows[0][9].ToString();
                }
                else
                {
                    Response.Write("<script>alert('invalid ID')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Go();
        }
    }
}