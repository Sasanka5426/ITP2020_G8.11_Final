using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    
    public partial class adminProfile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["role"]))
            {
                Response.Write("<script>alert('Error! You have to Login as Admin to access this section.');</script>");
                Response.Redirect("adminLogin.aspx");
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text==""|| TextBox2.Text == ""|| TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "")
            {
                Response.Write("<script>alert('Please make sure you have filled all the fields');</script>");
            }
            else if (checkIfExists())
            {
                Response.Write("<script>alert('Admin with this Username already exists. Please try using a different one');</script>");
            }
            else
            {
                addNewAdmin();
            }
        }

        void addNewAdmin()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO UserRegistration(FirstName, LastName, Contact, Gender, Address, Username, Password) values(@Fname, @lname, @number, @gender, @add, @un, @pw)", con);

                cmd.Parameters.AddWithValue("@Fname", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@lname", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@number", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@add", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@un", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pw", TextBox7.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('New Admin added Successfully');</script>");
                clearForm();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        bool checkIfExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from UserRegistration where Username = '" + TextBox6.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }



            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            updateDetails();
        }

        private void updateDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE UserRegistration SET FirstName=@Fname, LastName=@lname, Contact=@number, Gender=@gender, Address=@add, Username=@un, Password=@pw WHERE Username='" + TextBox6.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@Fname", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@lname", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@number", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@add", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@un", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pw", TextBox7.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Details Updated Successfully');</script>");
                //clearForm();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            getAdminbyUsername();
        }

        void getAdminbyUsername()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from UserRegistration where Username = '" + TextBox6.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox1.Text = dt.Rows[0]["FirstName"].ToString();
                    TextBox2.Text = dt.Rows[0]["LastName"].ToString();
                    TextBox3.Text = dt.Rows[0]["Contact"].ToString();
                    TextBox4.Text = dt.Rows[0]["Gender"].ToString();
                    TextBox5.Text = dt.Rows[0]["Address"].ToString();
                    TextBox6.Text = dt.Rows[0]["Username"].ToString();
                    TextBox7.Text = dt.Rows[0]["Password"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Username');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            deleteadmin();
        }

        void deleteadmin()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from UserRegistration WHERE Username='" + TextBox6.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Admin Deleted Successfully');</script>");
                clearForm();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            getpdf();
        }

        void getpdf()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from UserRegistration where Username = '" + TextBox6.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    String name = dt.Rows[0]["FirstName"].ToString() + dt.Rows[0]["LastName"].ToString();
                    String Contact = dt.Rows[0]["Contact"].ToString();
                    String Gender = dt.Rows[0]["Gender"].ToString();
                    String Address = dt.Rows[0]["Address"].ToString();
                    String Username = dt.Rows[0]["Username"].ToString();
                    String Password = dt.Rows[0]["Password"].ToString();

                    using (StringWriter sw = new StringWriter())
                    {
                        using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                        {
                            StringBuilder sb = new StringBuilder();

                            sb.Append("<center>");

                            sb.Append("<h3><b>Isury Property Sale (Pvt)Ltd</b></h3>");
                            sb.Append("</br>");


                            sb.Append("<ul>");

                            sb.Append("<li><b>Name :</b>");
                            sb.Append(name);
                            sb.Append("</li>");
                            sb.Append("<li><b>Contact No :</b>");
                            sb.Append(Contact);
                            sb.Append("</li>");
                            sb.Append("<li><b>Gender :</b>");
                            sb.Append(Gender);
                            sb.Append("</li>");
                            sb.Append("<li><b>Address :</b>");
                            sb.Append(Address);
                            sb.Append("</li>");
                            sb.Append("<li><b>Username :</b>");
                            sb.Append(Username);
                            sb.Append("</li>");
                            sb.Append("<li><b>Password :</b>");
                            sb.Append(Password);
                            sb.Append("</li>");
                            sb.Append("</ul>");
                            sb.Append("</center>");

                            StringReader sr = new StringReader(sb.ToString());
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                            pdfDoc.Open();
                            htmlparser.Parse(sr);
                            pdfDoc.Close();
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-dispossition", "attachment;filename-Invoice_" + name + ".pdf");
                            Response.Cache.SetCacheability(HttpCacheability.NoCache);
                            Response.Write(pdfDoc);
                            Response.End();



                        }
                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid Inquiry ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}