using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class ContactUsAdmin8 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["role"]))
            {
                Response.Write("<script>alert('Error! You have to Login as Admin to access this section.');</script>");
                Response.Redirect("adminLogin.aspx");
            }


            GridView1.DataBind();
            GridView2.DataBind();
            GridView3.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getNumberById();
        }
        void getNumberById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Company_phone where phone_id = '" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox1.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Regex ex = new Regex("^[0-9]{10}");
            bool isValid = ex.IsMatch(TextBox2.Text);
            if (!isValid)
            {
                Response.Write("<script>alert('Please enter valid phone number');</script>");

            }
            else
            {
                insertPhone();
            }
        }
        void insertPhone()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Company_phone (phone_id,phone_No) Values (@phone_id,@phone_No)", con);

                cmd.Parameters.AddWithValue("@phone_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_No", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Add new Phone successfully');</script>");
                clearForm1();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }
        }
        void clearForm3()
        {

            TextBox5.Text = "";
            TextBox6.Text = "";

        }
        void clearForm2()
        {

            TextBox3.Text = "";
            TextBox4.Text = "";

        }
        void clearForm1()
        {

            TextBox1.Text = "";
            TextBox2.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            updatePhone();
        }
        void updatePhone()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Company_phone SET phone_No=@phone_No WHERE phone_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@phone_No", TextBox2.Text.Trim());


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully');</script>");
                clearForm1();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            deletePhone();
        }
        void deletePhone()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from Company_phone WHERE phone_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clearForm1();
                GridView1.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            getEmailById();
        }
        void getEmailById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Company_Email where Email_id = '" + TextBox3.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox4.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            insertEmail();
        }
        void insertEmail()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Company_Email (Email_id,Email) Values (@Email_id,@Email)", con);

                cmd.Parameters.AddWithValue("@Email_id", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox4.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Add new Email successfully');</script>");
                clearForm2();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            updateEmail();
        }
        void updateEmail()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Company_Email SET Email=@Email WHERE Email_id='" + TextBox3.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@Email", TextBox4.Text.Trim());


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully');</script>");
                clearForm2();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            deleteEmail();
        }
        void deleteEmail()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from Company_Email WHERE Email_id='" + TextBox3.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clearForm2();
                GridView2.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            getAddressById();
        }
        void getAddressById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Company_Address where Add_id = '" + TextBox5.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox6.Text = dt.Rows[0][1].ToString();
                    TextBox5.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            insertAddress();
        }
        void insertAddress()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Company_Address (Add_id,Address) Values (@Add_id,@Address)", con);

                cmd.Parameters.AddWithValue("@Add_id", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Add new Address successfully');</script>");
                clearForm3();
                GridView3.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            updateAddress();
        }
        void updateAddress()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Company_Address SET Address=@Address WHERE Add_id='" + TextBox5.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@Address", TextBox6.Text.Trim());


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully');</script>");
                clearForm3();
                GridView3.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            deleteAddress();
        }
        void deleteAddress()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from Company_Address WHERE Add_id='" + TextBox5.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clearForm3();
                GridView3.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}