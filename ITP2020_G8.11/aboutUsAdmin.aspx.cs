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
    public partial class aboutUsAdmin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["role"]))
            {
                Response.Write("<script>alert('Error! You have to Login as Admin to access this section.');</script>");
                Response.Redirect("adminLogin.aspx");
            }

            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM abtUs WHERE id='2';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                TextBox1.Text = dt.Rows[0]["ds"].ToString();
                TextBox2.Text = dt.Rows[0]["vision"].ToString();
                TextBox3.Text = dt.Rows[0]["mision"].ToString();
                TextBox4.Text = dt.Rows[0]["cs"].ToString();
                TextBox5.Text = dt.Rows[0]["qs"].ToString();
                TextBox6.Text = dt.Rows[0]["ln"].ToString();
                


            }

        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO abtUs (ds,vision,mision,cs,qs,ln)Values(@ds,@vision,@mision,@cs,@qs,@ln)", con);

                cmd.Parameters.AddWithValue("@ds", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@vision", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@mision", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@cs", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@qs", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ln", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Insert Successfully');</script>");

            }

            catch (Expection ex)
            {

                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    

   
    

        //update button
        protected void Button40_Click(object sender, EventArgs e)
        {
            updateds();
        }
        void updateds()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE abtUs SET ds='"+ TextBox1.Text.Trim() + "', vision='"+ TextBox2.Text.Trim() + "' , mision='"+ TextBox3.Text.Trim() + "' , cs='"+ TextBox4.Text.Trim() + "' , qs='"+ TextBox5.Text.Trim() + "' ,ln='"+ TextBox6.Text.Trim() + "' WHERE id='2'", con);

               /* cmd.Parameters.AddWithValue("@ds", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@vision", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@mision", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@cs", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@qs", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ln", TextBox6.Text.Trim());*/

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Updated Successfully');</script>");

            }

            catch (Expection ex)
            {

                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        //delete button
        protected void Button60_Click(object sender, EventArgs e)
        {
            deleteds();
        }

        void deleteds()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from abtUs WHERE id='2'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Delete Successfully');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                

            }

            catch (Expection ex)
            {

                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }



        }
    }
}