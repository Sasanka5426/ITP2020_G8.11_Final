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
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class Manage_Proposal_Admin : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                SqlCommand cmd = new SqlCommand("UPDATE sell_yourLand SET reply='" + Textbox9.Text.Trim() + "' WHERE sell_id='" + TextBox1.Text.Trim() + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                ////////////////////
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sendersEmail@abc.com", "password");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add(TextBox3.Text);
                msgobj.From = new MailAddress("sendersEmail@abc.com");
                msgobj.Subject = "Reply for the proposal";
                String reply = Textbox9.Text.Trim();
                msgobj.Body = reply;
                //msgobj.Body = TextBodyRep.Text;
                client.Send(msgobj);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Reply Sent Successfully');", true);

                Response.Write("<script>alert('Reply sent successfully');</script>");
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM sell_yourLand WHERE sell_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["name"].ToString();
                    TextBox3.Text = dt.Rows[0]["emil"].ToString();
                    TextBox4.Text = dt.Rows[0]["mobile"].ToString();
                    txtBodymsg.Text = dt.Rows[0]["address"].ToString();
                    
                    TextBox6.Text = dt.Rows[0]["city"].ToString();
                    TextBox8.Text = dt.Rows[0]["extent"].ToString();
                    TextBox7.Text = dt.Rows[0]["price"].ToString();
                    Textbox9.Text = dt.Rows[0]["reply"].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid proposal Id');</script>");
                }
            }
            catch (Exception ex)
            {
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

                SqlCommand cmd = new SqlCommand("UPDATE sell_yourLand SET extent='" + TextBox8.Text.Trim() + "', price='" + TextBox7.Text.Trim() + "' WHERE sell_id='" + TextBox1.Text.Trim() + "';", con);
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM sell_yourLand WHERE sell_id='" + TextBox1.Text.Trim() + "' ;", con);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM sell_yourLand WHERE sell_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)

                {

                    String Proporsal_ID = dt.Rows[0]["sell_id"].ToString();
                    String Address = dt.Rows[0]["address"].ToString();
                    //String Description = dt.Rows[0]["description"].ToString();
                    String City = dt.Rows[0]["city"].ToString();
                    String Extent = dt.Rows[0]["extent"].ToString();
                    String Price = dt.Rows[0]["price"].ToString();
                    String Full_Name = dt.Rows[0]["name"].ToString();
                    String Email = dt.Rows[0]["emil"].ToString();
                    String Tele_No = dt.Rows[0]["mobile"].ToString();
                    //String Message = dt.Rows[0]["message"].ToString();
                    String Reply = dt.Rows[0]["reply"].ToString();

                    using (StringWriter sw = new StringWriter())
                    {
                        using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                        {
                            StringBuilder sb = new StringBuilder();

                            sb.Append("<ul>");
                            sb.Append("<li><b>P_Id :</b>");
                            sb.Append(Proporsal_ID);
                            sb.Append("</li>");
                            sb.Append("<li><b>address :</b>");
                            sb.Append(Address);
                            sb.Append("</li>");
                           
                            sb.Append("<li><b>city :</b>");
                            sb.Append(City);
                            sb.Append("</li>");
                            sb.Append("<li><b>extent :</b>");
                            sb.Append(Extent);
                            sb.Append("</li>");
                            sb.Append("<li><b>price :</b>");
                            sb.Append(Price);
                            sb.Append("</li>");
                            sb.Append("<li><b>full_name :</b>");
                            sb.Append(Full_Name);
                            sb.Append("</li>");
                            sb.Append("<li><b>email :</b>");
                            sb.Append(Email);
                            sb.Append("</li>");
                            sb.Append("<li><b>tele_no :</b>");
                            sb.Append(Tele_No);
                            sb.Append("</li>");
                            
                            sb.Append("<li><b>reply :</b>");
                            sb.Append(Reply);
                            sb.Append("</li>");

                            StringReader sr = new StringReader(sb.ToString());
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            HTMLWorker htmlparser = new HTMLWorker((IDocListener)pdfDoc);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                            pdfDoc.Open();
                            htmlparser.Parse(sr);
                            pdfDoc.Close();
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-dispossition", "attachment;filename-Invoice_" + Proporsal_ID + ".pdf");
                            Response.Cache.SetCacheability(HttpCacheability.NoCache);
                            Response.Write(pdfDoc);
                            Response.End();
                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid Proporsal ID');</script>");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}