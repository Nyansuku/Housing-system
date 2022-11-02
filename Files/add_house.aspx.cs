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
    public partial class add_house : System.Web.UI.Page
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
            if (Checkhouse())
            {
                Response.Write("<script>alert('House with that ID already  Exist,try another ID')</script>");
            }
            else
            {
                Add_house();
            }
            
        }
        //delete
        protected void LinkButton2_Click(object sender, EventArgs e)
        {

            if (Checkhouse())
            {
                Delete_house();
            }
            else
            {
                Response.Write("<script>alert('House with that ID doesnt Exist')</script>");
            }
        }
        //userdefined 
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

        void Add_house()
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
                filepath = "~upload/" + filename;

                //connection object
                SqlConnection con = new SqlConnection(strcon);
                //check if connection is open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //query
                SqlCommand cmd = new SqlCommand("insert into house(house_id,house_number,house_type,house_details,house_image,house_apartment) " +
                    "values(@house_id,@house_number,@house_type,@house_details,@house_image,@house_apartment)", con);
                cmd.Parameters.AddWithValue("@house_id",TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@house_number", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@house_type", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@house_details", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@house_image", filepath);
                cmd.Parameters.AddWithValue("@house_apartment", DropDownList1.SelectedItem.Value);

                //execute code
                cmd.ExecuteNonQuery();
                //close the connec tion
                con.Close();
                //message
                Response.Write("<script>alert('House  Added Suucessfully')</script>");
                clearscreen();
                GridView1.DataBind();
            

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
                SqlCommand cmd = new SqlCommand("delete from house  where house_ID='" + TextBox3.Text.Trim() + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //message
                Response.Write("<script>alert('House  Deleted Suucessfully')</script>");
                clearscreen();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

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
                SqlCommand cmd = new SqlCommand("select * from house where house_ID='" + TextBox3.Text.Trim() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //check if row exist
                if (dt.Rows.Count > 0)
                {
                    DropDownList1.SelectedValue = dt.Rows[0][5].ToString();
                    TextBox3.Text = dt.Rows[0][0].ToString();
                    TextBox1.Text = dt.Rows[0][1].ToString();
                    DropDownList2.SelectedValue = dt.Rows[0][2].ToString();
                    TextBox2.Text = dt.Rows[0][3].ToString();
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

        bool Checkhouse()
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
                SqlCommand cmd = new SqlCommand("select * from house where house_ID='" + TextBox3.Text.Trim() + "'", con);
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
        void clearscreen()
        {
            try
            {
                DropDownList1.Text = "";
                DropDownList2.Text = "";
                TextBox3.Text = "";
                TextBox2.Text = "";
                TextBox1.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }
    }
}
