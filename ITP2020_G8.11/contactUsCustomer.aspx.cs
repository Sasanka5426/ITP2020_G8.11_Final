using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class contactUsCustomer : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Company_phone;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                try {
                    phone1.Text = dt.Rows[0]["phone_no"].ToString();
                    phone2.Text = dt.Rows[1]["phone_no"].ToString();
                }
                catch(Exception ex) {
                    phone1.Text = dt.Rows[0]["phone_no"].ToString();
                }
            
            }

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Company_email;", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count >= 1)
            {
                try
                {
                    email1.Text = dt1.Rows[0]["Email"].ToString();
                    email2.Text = dt1.Rows[1]["Email"].ToString();
                }
                catch (Exception ex)
                {
                    email1.Text = dt1.Rows[0]["Email"].ToString();
                }

            }

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Company_Address;", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if (dt2.Rows.Count >= 1)
            {
                try
                {
                    add1.Text = dt2.Rows[0]["Address"].ToString();
                    add2.Text = dt2.Rows[1]["Address"].ToString();
                }
                catch (Exception ex)
                {
                    add1.Text = dt2.Rows[0]["Address"].ToString();
                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Let_us_call_you(name, phone, email, message) values(@name, @phone, @email,@message)", con);

                cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@message", TextBox5.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deatils sent Successfully');</script>");
               
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}