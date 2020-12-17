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
using System.Text;//
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Web.Mail;
using System.Net.Mail;
using System.Net;
using MailMessage = System.Net.Mail.MailMessage;

namespace ITP2020_G8._11
{
    public partial class manageInquiryAdmin : System.Web.UI.Page
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

        }

        //send reply button
        protected void Button5_Click(object sender, EventArgs e)
        {

            addToPending();



        }

        //send reply button click
        protected void Button6_Click(object sender, EventArgs e)
        {
            //updateReplyById();
            try
            {
                
                


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Inquiry_t2 SET Reply='" + TextBodyRep.Text.Trim() + "' WHERE I_id='" + TextBox1.Text.Trim() + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();


                /*using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("sasanka5426@gmail.com");
                    mail.To.Add(TextBox3.Text);
                    mail.Subject = "Testing";
                    mail.Body = "<p>Thank you for your Inquiry on land </p>TextBox5.Text<p>. Testing 1</p>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("sasanka5426@gmail.com", "psycho54269580");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        
                    }
                }*/

                ////////////////
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sendersEmail@abc.com", "password");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add(TextBox3.Text);
                msgobj.From = new MailAddress("sendersEmail@abc.com");
                msgobj.Subject = "Reply for the Inquiry";
                String reply = "Hello " + TextBox2.Text.Trim() + ". Thank you for your Inquiry on land - " + TextBox5.Text.Trim() + "\n" + TextBodyRep.Text + "\n\n" + "Best Regards\nIsury Property Sale (Pvt)Ltd"; 
                msgobj.Body = reply;
                //msgobj.Body = TextBodyRep.Text;
                client.Send(msgobj);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Reply Sent Successfully');",true);

               // Response.Write("<script>alert('Reply sent Successfully');</script>");
                GridView1.DataBind();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }








        }

        //Go button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getInquiryById();
                

        }

        //add note button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            addNote();


        }

        //delete button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            deleteInquiryById();



        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            removePendingInquiry();
        }


        //user defined fuctions

        void removePendingInquiry()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM Inquiry_pending WHERE I_id='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Response.Write("<script>alert('Operation Successful');</script>");
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteInquiryById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM Inquiry_t2 WHERE I_id='"+TextBox1.Text.Trim()+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Inquiry deleted Successfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                txtBodymsg.Text = "";
                TextBodyRep.Text = "";
                TextBodyNote.Text = "";



                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void addToPending()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Inquiry_pending (I_id,Name) VALUES ('" + TextBox1.Text.Trim() + "','"+TextBox2.Text.Trim()+"');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Response.Write("<script>alert('Operation Successful');</script>");
                GridView2.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        } 


        void updateReplyById()
        {
           /* try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Inquiry_t2 SET Reply='" + TextBodyRep.Text.Trim() + "' WHERE I_id='" + TextBox1.Text.Trim() + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Reply updated Successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"');</script>");
            }*/

        }


        void getInquiryById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Inquiry_t2 WHERE I_id='"+TextBox1.Text.Trim()+"';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>=1)
                {
                    TextBox2.Text = dt.Rows[0]["Name"].ToString();
                    TextBox3.Text = dt.Rows[0]["Email"].ToString();
                    TextBox4.Text = dt.Rows[0]["Phone"].ToString();
                    TextBox5.Text = dt.Rows[0]["land_id"].ToString();
                    txtBodymsg.Text = dt.Rows[0]["Message"].ToString();
                    TextBodyRep.Text = dt.Rows[0]["Reply"].ToString();
                    TextBodyNote.Text = dt.Rows[0]["Note"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Inquiry ID');</script>");
                }

            }
            catch(Exception ex)
            {

            }
        }
    
            

        

        void addReply()
        {

        }

        void addNote()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Inquiry_t2 SET Note='" + TextBodyNote.Text.Trim() + "' WHERE I_id='" + TextBox1.Text.Trim() + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Response.Write("<script>alert('Note added Successfully');</script>");
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Inquiry_t2 WHERE I_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    
                    String name = dt.Rows[0]["Name"].ToString();
                    String email = dt.Rows[0]["Email"].ToString();
                    String phone = dt.Rows[0]["Phone"].ToString();
                    String land_id= dt.Rows[0]["land_id"].ToString();
                    String message = dt.Rows[0]["Message"].ToString();
                    String reply = dt.Rows[0]["Reply"].ToString();
                    String note = dt.Rows[0]["Note"].ToString();

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
                            sb.Append("<li><b>Email :</b>");
                            sb.Append(email);
                            sb.Append("</li>");
                            sb.Append("<li><b>Phone :</b>");
                            sb.Append(phone);
                            sb.Append("</li>");
                            sb.Append("<li><b>Land ID :</b>");
                            sb.Append(land_id);
                            sb.Append("</li>");
                            sb.Append("<li><b>Message :</b>");
                            sb.Append(message);
                            sb.Append("</li>");
                            sb.Append("<li><b>Reply :</b>");
                            sb.Append(reply);
                            sb.Append("</li>");
                            sb.Append("<li><b>Note :</b>");
                            sb.Append(note);
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