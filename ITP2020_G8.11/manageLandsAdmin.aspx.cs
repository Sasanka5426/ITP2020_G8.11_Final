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
    public partial class manageLandsAdmin : System.Web.UI.Page
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

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Lands WHERE Land_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox1.Text = dt.Rows[0]["Land_id"].ToString();
                    TextBox2.Text = dt.Rows[0]["Located_area"].ToString();
                    TextBox8.Text = dt.Rows[0]["Location"].ToString();
                    TextBox12.Text = dt.Rows[0]["Land_size"].ToString();
                    TextBox9.Text = dt.Rows[0]["Land_price"].ToString();
                    TextBox6.Text = dt.Rows[0]["Land_details"].ToString();
                    TextBox10.Text = dt.Rows[0]["Payment_plan"].ToString();
                    TextBox3.Text = dt.Rows[0]["Facilities"].ToString();
                    TextBox4.Text = dt.Rows[0]["Agent_name"].ToString();
                    TextBox5.Text = dt.Rows[0]["Agent_contact_number"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Land ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("INSERT INTO Lands (Land_id,Located_area,Image_file,Location,Land_size,Land_price,Land_details,Payment_plan,Facilities,Agent_name,Agent_contact_number) Values (@Land_id,@Located_area,@Image_file,@Location,@Land_size,@Land_price,@Land_details,@Payment_plan,@Facilities,@Agent_name,@Agent_contact_number)", con);

                cmd.Parameters.AddWithValue("@Land_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Located_area", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Image_file", filepath);
                cmd.Parameters.AddWithValue("@Location", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@Land_size", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@Land_price", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@Land_details", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@payment_plan", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@Facilities", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Agent_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Agent_contact_number", TextBox5.Text.Trim());





                Button1.Enabled = true;



                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Land details Add successfully');</script>");

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

                SqlCommand cmd = new SqlCommand("UPDATE Lands SET Located_area='" + TextBox2.Text.Trim() + "',Location='" + TextBox8.Text.Trim() + "',Land_size='" + TextBox12.Text.Trim() + "',Land_price='" + TextBox9.Text.Trim() + "',Land_details='" + TextBox6.Text.Trim() + "',Payment_plan='" + TextBox10.Text.Trim() + "',Facilities='" + TextBox3.Text.Trim() + "',Agent_name='" + TextBox4.Text.Trim() + "',Agent_contact_number='" + TextBox5.Text.Trim() + "' WHERE Land_id='" + TextBox1.Text.Trim() + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Updated Successfully');</script>");
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM Lands WHERE Land_id='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Land Details Deleted Successfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox12.Text = "";

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Lands WHERE Land_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    String Land_ID = dt.Rows[0]["Land_id"].ToString();
                    String Located_Area = dt.Rows[0]["Located_area"].ToString();
                    String Location = dt.Rows[0]["Location"].ToString();
                    String Land_Size = dt.Rows[0]["Land_size"].ToString();
                    String Land_Price = dt.Rows[0]["Land_price"].ToString();
                    String Land_Details = dt.Rows[0]["Land_details"].ToString();
                    String Payment = dt.Rows[0]["Payment_plan"].ToString();
                    String Facilities = dt.Rows[0]["Facilities"].ToString();
                    String Agent_Name = dt.Rows[0]["Agent_name"].ToString();
                    String Contact_Num = dt.Rows[0]["Agent_contact_number"].ToString();



                    using (StringWriter sw = new StringWriter())
                    {
                        using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                        {
                            StringBuilder sb = new StringBuilder();

                            sb.Append("<ul>");
                            sb.Append("<li><b>Land ID :</b>");
                            sb.Append(Land_ID);
                            sb.Append("</li>");
                            sb.Append("<li><b>Located Area :</b>");
                            sb.Append(Located_Area);
                            sb.Append("</li>");
                            sb.Append("<li><b>Location :</b>");
                            sb.Append(Location);
                            sb.Append("</li>");
                            sb.Append("<li><b>Land Size :</b>");
                            sb.Append(Land_Size);
                            sb.Append("</li>");
                            sb.Append("<li><b>Land Price :</b>");
                            sb.Append(Land_Price);
                            sb.Append("</li>");
                            sb.Append("<li><b>Land Details :</b>");
                            sb.Append(Land_Details);
                            sb.Append("</li>");
                            sb.Append("<li><b>Payment Plan :</b>");
                            sb.Append(Payment);
                            sb.Append("</li>");
                            sb.Append("<li><b>Facilities :</b>");
                            sb.Append(Facilities);
                            sb.Append("</li>");
                            sb.Append("<li><b>Agent_Name :</b>");
                            sb.Append(Agent_Name);
                            sb.Append("</li>");
                            sb.Append("<li><b>Contact_Num :</b>");
                            sb.Append(Contact_Num);
                            sb.Append("</li>");


                            StringReader sr = new StringReader(sb.ToString());
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            HTMLWorker htmlparser = new HTMLWorker((IDocListener)pdfDoc);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                            pdfDoc.Open();
                            htmlparser.Parse(sr);
                            pdfDoc.Close();
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-dispossition", "attachment;filename-Invoice_" + Land_ID + ".pdf");
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