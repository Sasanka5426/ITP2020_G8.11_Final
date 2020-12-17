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
    public partial class addCustomer : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM add_customer WHERE c_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["cus_name"].ToString();
                    TextBox3.Text = dt.Rows[0]["cus_num"].ToString();
                    txtBodymsg.Text = dt.Rows[0]["address"].ToString();
                    Textbox5.Text = dt.Rows[0]["email"].ToString();
                    TextBox6.Text = dt.Rows[0]["location"].ToString();
                    TextBox7.Text = dt.Rows[0]["price"].ToString();
                    TextBox8.Text = dt.Rows[0]["land_size"].ToString();
                    Textbox9.Text = dt.Rows[0]["date"].ToString();


                }
                else
                {
                    Response.Write("<script>alert('Invalid customer Id');</script>");
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(strcon);

                Console.WriteLine(con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO add_customer(cus_name,cus_num,address,email,location ,land_size,price,date) values(@cus_name,@cus_num,@address,@email,@location ,@land_size,@price,@date)", con);




                //cmd.Parameters.AddWithValue("@c_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@cus_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@cus_num", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtBodymsg.Text.Trim());
                cmd.Parameters.AddWithValue("@email", Textbox5.Text.Trim());
                cmd.Parameters.AddWithValue("@location", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@land_size", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@price", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@date", Textbox9.Text.Trim());


                Button1.Enabled = true;



                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('customer details Add successfully');</script>");


                GridView1.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE add_customer SET cus_name='" + TextBox2.Text.Trim() + "', cus_num='" + TextBox3.Text.Trim() + "',address='" + txtBodymsg.Text.Trim() + "',email='" + Textbox5.Text.Trim() + "',location='" + TextBox6.Text.Trim() + "',price='" + TextBox7.Text.Trim() + "',land_size='" + TextBox8.Text.Trim() + "',date='" + Textbox9.Text.Trim() + "' WHERE c_id='" + TextBox1.Text.Trim() + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Updated successfully');</script>");


                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM add_customer WHERE c_id='" + TextBox1.Text.Trim() + "' ;", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                GridView1.DataBind();
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM add_customer WHERE c_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    String Cus_ID = dt.Rows[0]["c_id"].ToString();
                    String Cus_name = dt.Rows[0]["cus_name"].ToString();
                    String Cus_num = dt.Rows[0]["cus_num"].ToString();
                    String Address = dt.Rows[0]["address"].ToString();
                    String Email = dt.Rows[0]["email"].ToString();
                    String Location = dt.Rows[0]["location"].ToString();
                    String Land_size = dt.Rows[0]["land_size"].ToString();
                    String Price = dt.Rows[0]["price"].ToString();
                    String Date = dt.Rows[0]["date"].ToString();




                    using (StringWriter sw = new StringWriter())
                    {
                        using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                        {
                            StringBuilder sb = new StringBuilder();

                            sb.Append("<ul>");
                            sb.Append("<li><b>c_id :</b>");
                            sb.Append(Cus_ID);
                            sb.Append("</li>");
                            sb.Append("<li><b>cus_name :</b>");
                            sb.Append(Cus_name);
                            sb.Append("</li>");
                            sb.Append("<li><b>cus_num :</b>");
                            sb.Append(Cus_num);
                            sb.Append("</li>");
                            sb.Append("<li><b>address :</b>");
                            sb.Append(Address);
                            sb.Append("</li>");
                            sb.Append("<li><b>email :</b>");
                            sb.Append(Email);
                            sb.Append("</li>");
                            sb.Append("<li><b>location :</b>");
                            sb.Append(Location);
                            sb.Append("</li>");
                            sb.Append("<li><b>land_size :</b>");
                            sb.Append(Land_size);
                            sb.Append("</li>");
                            sb.Append("<li><b>price :</b>");
                            sb.Append(Price);
                            sb.Append("</li>");
                            sb.Append("<li><b>date :</b>");
                            sb.Append(Date);
                            sb.Append("</li>");
                            sb.Append("</ul>");




                            StringReader sr = new StringReader(sb.ToString());
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            HTMLWorker htmlparser = new HTMLWorker((IDocListener)pdfDoc);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                            pdfDoc.Open();
                            htmlparser.Parse(sr);
                            pdfDoc.Close();
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-dispossition", "attachment;filename-Invoice_" + Cus_ID + ".pdf");
                            Response.Cache.SetCacheability(HttpCacheability.NoCache);
                            Response.Write(pdfDoc);
                            Response.End();



                        }
                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid Customer ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}