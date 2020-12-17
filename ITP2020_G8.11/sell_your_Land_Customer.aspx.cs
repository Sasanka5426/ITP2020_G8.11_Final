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

namespace ITP2020_G8._11
{
    public partial class sell_your_Land_Customer : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_filepath;
        protected void Page_Load(object sender, EventArgs e)
        {
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;

            Button6.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox6.Enabled = true;
            TextBox7.Enabled = true;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = true;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = true;
            Button1.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "~/images/" + Guid.NewGuid().ToString() + "" + Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(MapPath(filepath));

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO sell_yourLand (emil,name,mobile,address,city,price,extent,land_img_link) Values (@emil,@name,@mobile,@address,@city,@price,@extent,@land_img_link)", con);

                cmd.Parameters.AddWithValue("@emil", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@city", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@price", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@extent", TextBox7.Text.Trim());

                cmd.Parameters.AddWithValue("@land_img_link", filepath);

                Button1.Enabled = true;
                Button2.Enabled = true;
                Button6.Enabled = true;


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Land details Add successfully');</script>");



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from sell_yourLand WHERE emil='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["name"].ToString();
                    TextBox3.Text = dt.Rows[0]["mobile"].ToString();
                    TextBox4.Text = dt.Rows[0]["address"].ToString();
                    TextBox5.Text = dt.Rows[0]["city"].ToString();
                    TextBox6.Text = dt.Rows[0]["price"].ToString();
                    TextBox7.Text = dt.Rows[0]["extent"].ToString();

                    global_filepath = dt.Rows[0]["land_img_link"].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid Email');</script>");
                }
                Button6.Enabled = true;
                Button5.Enabled = true;
                Button4.Enabled = true;
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                TextBox4.Enabled = true;
                TextBox5.Enabled = true;
                TextBox6.Enabled = true;
                TextBox7.Enabled = true;
            }




            catch (Exception ex)
            {

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {


                string filepath = "~/images/" + Guid.NewGuid().ToString() + "" + Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(MapPath(filepath));



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE sell_yourLand set emil=@emil ,name=@name,mobile=@mobile,address=@address,city=@city,price=@price,extent=@extent,land_img_link=@land_img_link where emil ='" + TextBox1.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@emil", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@city", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@price", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@extent", TextBox7.Text.Trim());

                cmd.Parameters.AddWithValue("@land_img_link", filepath);

                Button6.Enabled = true;

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Land details  Updated Successfully');</script>");


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from sell_yourLand WHERE emil='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Land Details Deleted Successfully');</script>");



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;

        }
    }
}