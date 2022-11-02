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
    public partial class add_apartment : System.Web.UI.Page
    {
        //connection string
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //add apartment
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Checkapartment())
            {
                Response.Write("<script>alert('Apartment  with that ID already Exists,try another ID')</script>");
            }
            else
            {
                Addapartment();
            }
        }
        
        //delete apartment
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (Checkapartment())
            {
                Deleteapartment();
            }
            else
            {
                Response.Write("<script>alert('apartment doesnt exist,cant delete')</script>");
            }
        }

        //userdefined function
        
        void Addapartment()
        {
            try
            {
                //file upload code
                //hard coded fill path for default image
                string filepath = "~/upload/apa2.jpg";
                //geting the content from fileupload asp button
                //the file will be posted to the server
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //save the image to the folder that we want to store
                FileUpload1.SaveAs(Server.MapPath("upload/" + filename));
                filepath = "~upload/"+filename;


                //connection object
                SqlConnection con = new SqlConnection(strcon);
                //check if connection is open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //query
                SqlCommand cmd = new SqlCommand("insert into apartments(apa_ID,apa_name,total_number,remaining_rooms,apa_image,apa_county,apa_town) values(@apa_ID,@apa_name,@total_number,@remaining_rooms,@apa_image,@apa_county,@apa_town)", con);
                //get the values
                //wwhen we add a  new apartment the total and remaining number should be the same.
                //once we start issuing the rooms to members the total will remain same but remaining will change
                cmd.Parameters.AddWithValue("@apa_ID", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@apa_name", apartment.Text.Trim());
                cmd.Parameters.AddWithValue("@total_number", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@remaining_rooms", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@apa_image", filepath);
                cmd.Parameters.AddWithValue("@apa_county", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@apa_town", TextBox1.Text.Trim());

                
                //execute code
                cmd.ExecuteNonQuery();
                //close the connec tion
                con.Close();
                //message
                Response.Write("<script>alert('Apartment Added Suucessfully')</script>");
                clearscreen();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
       
        bool Checkapartment()
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
                SqlCommand cmd = new SqlCommand("select * from apartments where apa_ID='"+TextBox2.Text.Trim()+"'", con);
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
        
        void Deleteapartment()
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
                SqlCommand cmd = new SqlCommand("delete from apartments where apa_ID='"+TextBox2.Text.Trim()+"' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //message
                Response.Write("<script>alert('Apartment Deleted Suucessfully')</script>");
                clearscreen();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }
        //Go button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Go();
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
                SqlCommand cmd = new SqlCommand("select * from apartments where apa_ID='"+TextBox2.Text.Trim()+"'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //check if row exist
                if (dt.Rows.Count > 0)
                {
                    apartment.Text = dt.Rows[0][1].ToString();
                    TextBox4.Text = dt.Rows[0][2].ToString();
                    TextBox3.Text = dt.Rows[0][3].ToString();
                    TextBox1.Text = dt.Rows[0][6].ToString();
                    TextBox6.Text = dt.Rows[0][3].ToString();
                    //image field to do
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

        void clearscreen()
        {
            try
            {
                apartment.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox1.Text = "";
                TextBox4.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }
    }
}